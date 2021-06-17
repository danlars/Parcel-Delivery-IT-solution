import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookingConfirmationComponent } from './booking-confirmation.component';

const routes: Routes = [
  {
    path: '',
    component: BookingConfirmationComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class BookingConfirmationRoutingModule {}