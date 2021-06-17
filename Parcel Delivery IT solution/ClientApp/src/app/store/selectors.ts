import { createFeatureSelector, createSelector } from "@ngrx/store";
import { StoreStateInterface } from "./store-state.interface";

const appFeatureSelector = createFeatureSelector<StoreStateInterface>("appState");

export const selectCustomer = createSelector(
  appFeatureSelector,
  (state: StoreStateInterface) => {
    return state.selectedCustomer;
  }
);

export const selectBookingInformation = createSelector(
  appFeatureSelector,
  (state: StoreStateInterface) => {
    return state.bookingInformation;
  }
);

export const selectOffer = createSelector(
  appFeatureSelector,
  (state) => {
    return state.selectedOffer;
  }
);

export const selectOffers = createSelector(
  appFeatureSelector,
  (state: StoreStateInterface) => {
    return state.offers;
  }
);
