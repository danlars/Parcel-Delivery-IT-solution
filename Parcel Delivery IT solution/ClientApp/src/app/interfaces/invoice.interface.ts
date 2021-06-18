import { BookingInformationInterface } from "./booking-information.interface";
import { CustomerInterface } from "./customer.interface";
import { OfferInterface } from "./offer.interface";

export interface InvoiceInterface {
    customer: CustomerInterface;
    offer: OfferInterface;
    bookingInformation: BookingInformationInterface;
    createdAt: Date;
}