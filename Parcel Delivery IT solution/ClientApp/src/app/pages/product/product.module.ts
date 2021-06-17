import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductComponent } from './product.component';
import { FormsModule } from '@angular/forms';
import { ProductRoutingModule } from './product-routing.module';
import { OfferModule } from 'src/app/components/offer/offer.module';

@NgModule({
  declarations: [ProductComponent],
  imports: [
    CommonModule,
    FormsModule,
    ProductRoutingModule,
    OfferModule,
  ]
})
export class ProductModule { }
