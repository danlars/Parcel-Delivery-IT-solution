import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CustomerService } from './customer/customer.service';
import { InvoiceService } from './invoice/invoice.service';
import { OfferService } from './offer/offer.service';

@NgModule({
  providers: [CustomerService, InvoiceService, OfferService],
  imports: [
    HttpClientModule,
  ]
})
export class HttpModule { }
