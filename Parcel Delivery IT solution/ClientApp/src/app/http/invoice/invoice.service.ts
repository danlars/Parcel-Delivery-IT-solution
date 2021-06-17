import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { InvoiceInterface } from 'src/app/interfaces/invoice.interface';

@Injectable()
export class InvoiceService {

  constructor(private readonly http: HttpClient) {}

  insertInvoice(invoice: InvoiceInterface) {
    this.http.post("/Package/InsertPackage", { params: {...invoice} });
  }
}
