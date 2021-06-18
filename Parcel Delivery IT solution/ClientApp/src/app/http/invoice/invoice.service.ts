import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { InvoiceInterface } from 'src/app/interfaces/invoice.interface';
import { StoreStateService } from 'src/app/store/store-state.service';

@Injectable()
export class InvoiceService {

  constructor(private readonly http: HttpClient, private readonly storeStateService: StoreStateService) {}

  insertInvoice(invoice: InvoiceInterface) {
    this.http.post("/Package/InsertPackage", { params: {...invoice} }).subscribe(() => {
      this.storeStateService.setInvoice(invoice);
    });
  }
}
