import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { InvoiceInterface } from "src/app/interfaces/invoice.interface";
import { StoreStateService } from "src/app/store/store-state.service";

@Injectable()
export class InvoiceService {
  constructor(
    private readonly http: HttpClient,
    private readonly storeStateService: StoreStateService,
    private readonly router: Router
  ) {}

  insertInvoice(invoice: InvoiceInterface) {
    this.http
      .post("/Package", {
        customerId: invoice.customer.customerId,
        email: invoice.customer.email,
        name: invoice.customer.name,
        telephoneNumber: invoice.customer.telephoneNumber,
        price: invoice.offer.price,
        time: invoice.offer.time,
        height: invoice.bookingInformation.height,
        width: invoice.bookingInformation.width,
        length: invoice.bookingInformation.length,
        cityFrom: invoice.bookingInformation.from,
        cityTo: invoice.bookingInformation.to,
        date: invoice.bookingInformation.departure,
      })
      .subscribe(() => {
        this.storeStateService.setInvoice(invoice);
        this.router.navigate(["invoice"]);
      });
  }
}
