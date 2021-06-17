import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OfferComponent } from './offer.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { OfferService } from './offer.service';

@NgModule({
  declarations: [OfferComponent],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [
    OfferComponent
  ],
  providers: [
    OfferService
  ]
})
export class OfferModule { }
