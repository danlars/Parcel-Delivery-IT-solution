import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BookingInformationInterface } from "src/app/interfaces/booking-information.interface";

@Injectable()
export class OfferService {
  constructor(private http: HttpClient) {}

  getOffers(bookingInformation: BookingInformationInterface) {
    this.http.get("/Offers", {
      params: {
        from: bookingInformation.from,
        to: bookingInformation.to,
        weight: bookingInformation.weight,
        height: bookingInformation.height,
        length: bookingInformation.length,
        width: bookingInformation.width,
      },
    });
  }
}
