import { NgModule } from '@angular/core';
import { StoreStateService } from './store-state.service';
import {StoreModule} from '@ngrx/store';
import { bookingInformationReducer, offersReducer, selectedOfferReducer } from './reducers';


@NgModule({
  imports: [
    StoreModule.forRoot({
      selectedOffer: selectedOfferReducer,
      bookingInformation: bookingInformationReducer,
      selectedCustomer: selectedOfferReducer,
      offers: offersReducer,
    })
  ],
  providers: [
    StoreStateService
  ]
})
export class AppStoreModule { }
