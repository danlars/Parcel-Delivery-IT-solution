import { Injectable } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { BookingInformationInterface } from '../interfaces/booking-information.interface';
import { CustomerInterface } from '../interfaces/customer.interface';
import { InvoiceInterface } from '../interfaces/invoice.interface';
import { OfferInterface } from '../interfaces/offer.interface';
import { setBookingInformation, setCustomer, setOffer, setOffers, setInvoice } from './actions';
import { selectBookingInformation, selectCustomer, selectOffer, selectOffers, selectCreatedInvoice } from './selectors';
import { StoreStateInterface } from './store-state.interface';

@Injectable()
export class StoreStateService {
  selectedOffer$: Observable<OfferInterface | null>;
  selectedCustomer$: Observable<CustomerInterface | null>;
  selectedBookingInformation$: Observable<BookingInformationInterface | null>;
  offers$: Observable<OfferInterface[]>;
  createdInvoice$: Observable<InvoiceInterface | null>;

  constructor(private readonly store: Store<StoreStateInterface>) { 
    this.selectedCustomer$ = this.store.pipe(select(selectCustomer));
    this.selectedOffer$ = this.store.pipe(select(selectOffer));
    this.selectedBookingInformation$ = this.store.pipe(select(selectBookingInformation));
    this.offers$ = this.store.pipe(select(selectOffers));
    this.createdInvoice$ = this.store.pipe(select(selectCreatedInvoice));
  }

  setCustomer(customer: CustomerInterface | null) {
    this.store.dispatch(setCustomer({customer}));
  }

  setOffer(offer: OfferInterface) {
    this.store.dispatch(setOffer({offer}));
  }

  setBookingInformation(bookingInformation: BookingInformationInterface) {
    this.store.dispatch(setBookingInformation({bookingInformation}));
  }

  setOffers(offers: OfferInterface[]) {
    this.store.dispatch(setOffers({offers}));
  }

  setInvoice(invoice: InvoiceInterface) {
    this.store.dispatch(setInvoice({invoice}));
  }
}
