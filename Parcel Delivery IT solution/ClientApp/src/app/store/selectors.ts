import { createSelector } from "@ngrx/store";
import { StoreStateInterface } from "./store-state.interface";

export const selectCustomer = createSelector((state: StoreStateInterface) => {
    return state.selectedCustomer;
}, (customer) => customer);

export const selectBookingInformation = createSelector((state: StoreStateInterface) => {
    return state.bookingInformation;
}, (bookingInformation) => bookingInformation);

export const selectOffer = createSelector((state: StoreStateInterface) => {
    return state.selectedOffer;
}, (offer) => offer);

export const selectOffers = createSelector((state: StoreStateInterface) => {
    return state.offers;
}, (offers) => offers);