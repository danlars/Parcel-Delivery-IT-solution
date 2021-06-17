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
  bookingForm = new FormGroup({
    from: new FormControl('', [Validators.required]),
    to: new FormControl('', [Validators.required]),
    height: new FormControl('', [Validators.required]),
    length: new FormControl('', [Validators.required]),
    weight: new FormControl('', [Validators.required]),
    width: new FormControl('', [Validators.required]),
  });
  constructor(private stateService: StoreStateService, private offerService: OfferService) {
    this.offers$ = this.stateService.offers$;
  }

  ngOnInit(): void {
    this.stateService.selectedBookingInformation$.subscribe(
      (bookingInformation) => {
        if (bookingInformation) {
          // Apply previous session input..
          this.bookingForm.patchValue(bookingInformation);
        }
      }
    );

    this.stateService.selectedOffer$.subscribe((offer) => {
      this.selectedOffer = offer;
    });
  }

  submitBookingInformation() {
    const bookingInformation = this.bookingForm.value as BookingInformationInterface;
    this.offerService.getOffers(bookingInformation);
    this.setBookingInformation(bookingInformation);
  }

  setBookingInformation(bookingInformation: BookingInformationInterface) {
    this.stateService.setBookingInformation(bookingInformation);
  }
}
