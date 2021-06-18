import { createReducer, on } from "@ngrx/store";
import { setBookingInformation, setCustomer, setInvoice, setOffer, setOffers } from "./actions";
import { StoreStateInterface } from "./store-state.interface";

export const initialState: StoreStateInterface = {
    selectedCustomer: null,
    bookingInformation: null,
    selectedOffer: null,
    offers: [],
    createdInvoice: null
};

export const reducers = createReducer(initialState, 
    on(setCustomer, (state, {customer}) => ({...state, selectedCustomer: customer})),
    on(setBookingInformation, (state, {bookingInformation}) => ({...state, bookingInformation})),
    on(setOffer, (state, {offer}) => ({...state, selectedOffer: offer})),
    on(setOffers, (state, {offers}) => ({...state, offers})),
    on(setInvoice, (state, {invoice}) => ({...state, createdInvoice: invoice})),
);