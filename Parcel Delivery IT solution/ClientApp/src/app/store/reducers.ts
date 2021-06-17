import { createReducer, on } from "@ngrx/store";
import { setBookingInformation, setCustomer, setOffer, setOffers } from "./actions";
import { StoreStateInterface } from "./store-state.interface";

export const initialState: StoreStateInterface = {
    selectedCustomer: null,
    bookingInformation: null,
    selectedOffer: null,
    offers: [],
};

export const selectedCustomerReducer = createReducer(initialState.selectedCustomer, on(setCustomer, (state, {customer}) => customer));
export const selectedOfferReducer = createReducer(initialState.selectedOffer, on(setOffer, (state, {offer}) => offer));
export const bookingInformationReducer = createReducer(initialState.bookingInformation, on(setBookingInformation, (state, {bookingInformation}) => bookingInformation));
export const offersReducer = createReducer(initialState.offers, on(setOffers, (state, {offers}) => offers));

// export const storeReducer = createReducer(
//     initialState,
//     on(setCustomer, (state, {customer}) => {
//         return {
//             ...state,
//             selectedCustomer: customer
//         };
//     }),
//     on(setOffer, (state, {offer}) => {
//         return {
//             ...state,
//             selectedOffer: offer
//         };
//     }),
//     on(setBookingInformation, (state, {bookingInformation}) => {
//         return {
//             ...state,
//             bookingInformation
//         };
//     }),
//     on(setOffers, (state, {offers}) => {
//         return {
//             ...state,
//             offers
//         };
//     }),
// );