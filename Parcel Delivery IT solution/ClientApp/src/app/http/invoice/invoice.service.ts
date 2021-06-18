import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { InvoiceInterface } from "src/app/interfaces/invoice.interface";
import { StoreStateService } from "src/app/store/store-state.service";

@Injectable()
export class InvoiceService {
  constructor(
    private readonly http: HttpClient,
    private readonly storeStateService: StoreStateService
  ) {}

  insertInvoice(invoice: InvoiceInterface) {
    const url = new URL(location.protocol + "//" + location.host + "/Package");
    url.searchParams.append('customerId', invoice.customer.customerId as unknown as string);
    url.searchParams.append('email', invoice.customer.email as unknown as string);
    url.searchParams.append('name', invoice.customer.name as unknown as string);
    url.searchParams.append('telephoneNumber', invoice.customer.telephoneNumber as unknown as string);
    url.searchParams.append('price', invoice.offer.price as unknown as string);
    url.searchParams.append('time', invoice.offer.time as unknown as string);
    url.searchParams.append('height', invoice.bookingInformation.height as unknown as string);
    url.searchParams.append('width', invoice.bookingInformation.width as unknown as string);
    url.searchParams.append('length', invoice.bookingInformation.length as unknown as string);
    url.searchParams.append('cityFrom', invoice.bookingInformation.from as unknown as string);
    url.searchParams.append('cityTo', invoice.bookingInformation.to as unknown as string);
    url.searchParams.append('date', invoice.bookingInformation.departure as unknown as string);
    this.http
      .post(url.href, {})
      .subscribe(() => {});
    this.storeStateService.setInvoice(invoice);
  }
}
