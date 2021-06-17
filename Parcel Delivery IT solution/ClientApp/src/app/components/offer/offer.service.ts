import { Injectable } from '@angular/core';
import { OfferInterface } from 'src/app/interfaces/offer.interface';
import { StoreStateService } from 'src/app/store/store-state.service';

@Injectable()
export class OfferService {
  private selectedOffer: OfferInterface | null = null;
  
  constructor(private readonly storeStateService: StoreStateService) {
    this.storeStateService.selectedOffer$.subscribe((offer) => {
      this.selectedOffer = offer;
    });
  }

  setOffer(offer: OfferInterface) {
    this.storeStateService.setOffer(offer);
  }

  isSameOffer(offer: OfferInterface) {
    if (!this.selectedOffer) {
      return false;
    }
    
    return this.selectedOffer.price === offer.price && this.selectedOffer.time === offer.time && this.selectedOffer.routeType === offer.routeType;
  }
}
