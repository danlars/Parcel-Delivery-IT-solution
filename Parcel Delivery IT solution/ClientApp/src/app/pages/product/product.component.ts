import { Component, OnInit } from "@angular/core";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { Observable } from "rxjs";
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
  offers$: Observable<OfferInterface[]>;
  cities = [
    "Amatave",
    "Cairo",
    "Dakar",
    "De Kanariske Oeer",
    "Guldkysten",
    "Hvalbugten",
    "Kap Guardafui",
    "Kap St Marie",
    "Kapstaden",
    "Mocamique",
    "Sierra Leone",
    "Slavekysten",
    "St. Helena",
    "Suakin",
    "Tanger",
    "Tunis",
  ];
  bookingForm = new FormGroup({
    departure: new FormControl("", [Validators.required]),
    from: new FormControl(this.cities[0], [Validators.required]),
    to: new FormControl(this.cities[1], [Validators.required]),
    height: new FormControl("", [Validators.required]),
    length: new FormControl("", [Validators.required]),
    weight: new FormControl("", [Validators.required]),
    width: new FormControl("", [Validators.required]),
  });
  constructor(
    private stateService: StoreStateService,
    private offerService: OfferService
  ) {
    this.offers$ = this.stateService.offers$;
  }

  ngOnInit(): void {
    this.stateService.selectedBookingInformation$.subscribe(
      (bookingInformation) => {
        if (bookingInformation) {
          // Apply previous session input..
          this.bookingForm.patchValue(bookingInformation);
          this.bookingForm.patchValue({
            departure: bookingInformation.departure.toISOString(),
          });
        }
      }
    );

    this.stateService.selectedOffer$.subscribe((offer) => {
      this.selectedOffer = offer;
    });
  }

  submitBookingInformation() {
    const bookingInformation = JSON.parse(
      JSON.stringify(this.bookingForm.value)
    ) as BookingInformationInterface;
    const [year, month, day] = (
      bookingInformation.departure as unknown as string
    ).split("-");
    bookingInformation.departure = new Date(+year, +month, +day);
    this.offerService.getOffers(bookingInformation);
    this.setBookingInformation(bookingInformation);
  }

  setBookingInformation(bookingInformation: BookingInformationInterface) {
    this.stateService.setBookingInformation(bookingInformation);
  }
}
