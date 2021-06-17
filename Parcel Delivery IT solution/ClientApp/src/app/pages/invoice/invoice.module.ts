import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InvoiceRoutingModule } from './invoice-routing.module';
import { InvoiceComponent } from './invoice.component';
import { CompanyLogoModule } from 'src/app/components/company-logo/company-logo.module';

@NgModule({
  declarations: [InvoiceComponent],
  imports: [
    CommonModule,
    InvoiceRoutingModule,
    CompanyLogoModule
  ]
})
export class InvoiceModule { }
