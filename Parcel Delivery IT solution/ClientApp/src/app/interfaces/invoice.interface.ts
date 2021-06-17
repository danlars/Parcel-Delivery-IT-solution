import { CustomerInterface } from "./customer.interface";
import { OfferInterface } from "./offer.interface";

export interface InvoiceInterface {
    customer: CustomerInterface;
    offer: OfferInterface;
}