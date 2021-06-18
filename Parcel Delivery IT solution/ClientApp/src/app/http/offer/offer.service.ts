import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BookingInformationInterface } from "src/app/interfaces/booking-information.interface";
import { OfferInterface } from "src/app/interfaces/offer.interface";
import { StoreStateService } from "src/app/store/store-state.service";

@Injectable()
export class OfferService {
  constructor(
    private http: HttpClient,
    private readonly storeStateService: StoreStateService
  ) {}

  getOffers(bookingInformation: BookingInformationInterface) {
    this.http
      .get("/Offers", {
        params: {
          from: bookingInformation.from,
          to: bookingInformation.to,
          weight: bookingInformation.weight,
          height: bookingInformation.height,
          length: bookingInformation.length,
          width: bookingInformation.width,
          date: bookingInformation.departure.toISOString()
        },
      })
      .subscribe((response) => {
        const offers = response as unknown as OfferInterface[];
        this.storeStateService.setOffers(offers);
        this.storeStateService.setOffer(offers[0]);
      });
  }
}
