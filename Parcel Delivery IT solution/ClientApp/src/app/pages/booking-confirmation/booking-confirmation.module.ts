import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CompanyLogoModule } from 'src/app/components/company-logo/company-logo.module';
import { BookingConfirmationComponent } from './booking-confirmation.component';
import { BookingConfirmationRoutingModule } from './booking-confirmation-routing.module';
import { OfferModule } from 'src/app/components/offer/offer.module';

@NgModule({
  declarations: [BookingConfirmationComponent],
  imports: [
    CommonModule,
    CompanyLogoModule,
    BookingConfirmationRoutingModule,
    OfferModule,
  ]
})
export class BookingConfirmationModule { }
