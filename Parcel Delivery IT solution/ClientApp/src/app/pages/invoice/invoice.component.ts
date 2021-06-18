import { Component, OnInit } from '@angular/core';
import { InvoiceInterface } from 'src/app/interfaces/invoice.interface';
import { StoreStateService } from 'src/app/store/store-state.service';

@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styleUrls: ['./invoice.component.scss']
})
export class InvoiceComponent implements OnInit {
  selectedInvoice: InvoiceInterface | null = null;

  constructor(private readonly storeStateService: StoreStateService) { 
    this.storeStateService.createdInvoice$.subscribe((invoice) => {
      this.selectedInvoice = invoice;
    });
  }

  ngOnInit(): void {
  }

}
