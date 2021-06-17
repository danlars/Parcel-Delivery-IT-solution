import { createAction, props } from "@ngrx/store";
import { BookingInformationInterface } from "../interfaces/booking-information.interface";
import { CustomerInterface } from "../interfaces/customer.interface";
import { OfferInterface } from "../interfaces/offer.interface";

export const setCustomer = createAction('[Customer] Set the selected Customer', props<{customer: null | CustomerInterface}>());
export const setBookingInformation = createAction('[Booking Information] Set the selected Booking Information', props<{bookingInformation: null | BookingInformationInterface}>());
export const setOffer = createAction('[Offers] Set the Selected Offer', props<{offer: null | OfferInterface}>());
export const setOffers = createAction('[Offers] Set all Offers', props<{offers: OfferInterface[]}>());