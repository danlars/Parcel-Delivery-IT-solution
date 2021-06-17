import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { CompanyLogoComponent } from './company-logo.component';

@NgModule({
  declarations: [CompanyLogoComponent],
  imports: [
    CommonModule
  ],
  exports: [CompanyLogoComponent],
})
export class CompanyLogoModule { }
