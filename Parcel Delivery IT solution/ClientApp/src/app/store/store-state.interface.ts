import { BookingInformationInterface } from "../interfaces/booking-information.interface";
import { OfferInterface } from "../interfaces/offer.interface";
import { CustomerInterface } from "../interfaces/customer.interface";
import { InvoiceInterface } from "../interfaces/invoice.interface";

export interface StoreStateInterface {
    selectedOffer: null | OfferInterface,
    bookingInformation: null | BookingInformationInterface,
    selectedCustomer: null | CustomerInterface,
    offers: OfferInterface[],
    createdInvoice: null | InvoiceInterface
  }