import { Component, OnInit } from "@angular/core";
import { OfferService } from "src/app/http/offer/offer.service";
import { BookingInformationInterface } from "src/app/interfaces/booking-information.interface";
import { OfferInterface } from "src/app/interfaces/offer.interface";
import { StoreStateService } from "src/app/store/store-state.service";

@Component({
  selector: "app-product",
  templateUrl: "./product.component.html",
  styleUrls: ["./product.component.scss"],
})
export class ProductComponent implements OnInit {
  selectedOffer: OfferInterface | null = null;
  offers: OfferInterface[] = [];
  bookingInformation: BookingInformationInterface = {
    from: "",
    to: "",
    height: "",
    length: "",
    weight: "",
    width: "",
  };
  constructor(private stateService: StoreStateService, private offerService: OfferService) {
  }

  ngOnInit(): void {
    this.stateService.offers$.subscribe((offers) => {
      this.offers = offers;
    });

    this.stateService.selectedBookingInformation$.subscribe(
      (bookingInformation) => {
        if (bookingInformation) {
          this.bookingInformation = bookingInformation;
        }
      }
    );

    this.stateService.selectedOffer$.subscribe((offer) => {
      this.selectedOffer = offer;
    });
  }

  submitBookingInformation() {
    this.offerService.getOffers(this.bookingInformation);
    this.setBookingInformation();
  }

  setBookingInformation() {
    this.stateService.setBookingInformation(this.bookingInformation);
  }
}
