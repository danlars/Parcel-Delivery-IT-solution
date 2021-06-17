import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BookingInformationInterface } from "src/app/interfaces/booking-information.interface";

@Injectable()
export class OfferService {
  constructor(private readonly http: HttpClient) {}

  getOffers(bookingInformation: BookingInformationInterface) {
    this.http.get("/Offers", {
      params: {
        ...bookingInformation,
      },
    });
  }
}
