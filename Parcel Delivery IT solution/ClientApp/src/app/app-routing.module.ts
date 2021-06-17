import { NgModule } from '@angular/core';
import { RouterModule, Routes, PreloadAllModules } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadChildren: () => import('./pages/product/product.module').then(m => m.ProductModule) 
  },
  {
    path: 'booking-confirmation',
    loadChildren: () => import('./pages/booking-confirmation/booking-confirmation.module').then(m => m.BookingConfirmationModule)
  },
  {
    path: 'invoice',
    loadChildren: () => import('./pages/invoice/invoice.module').then(m => m.InvoiceModule)
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}
