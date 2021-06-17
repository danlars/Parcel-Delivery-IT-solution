import { Component, OnInit } from "@angular/core";
import { FormControl, Validators } from "@angular/forms";
import { CustomerService } from "src/app/http/customer/customer.service";
import { BookingInformationInterface } from "src/app/interfaces/booking-information.interface";
import { CustomerInterface } from "src/app/interfaces/customer.interface";
import { OfferInterface } from "src/app/interfaces/offer.interface";
import { StoreStateService } from "src/app/store/store-state.service";

@Component({
  selector: "app-booking-confirmation",
  templateUrl: "./booking-confirmation.component.html",
  styleUrls: ["./booking-confirmation.component.scss"]
})
export class BookingConfirmationComponent implements OnInit {
  selectedBookingInformation: BookingInformationInterface | null = null;
  selectedCustomer: CustomerInterface | null = null;
  selectedOffer: OfferInterface | null = null;
  customerFormControl = new FormControl('', [Validators.required]);

  constructor(private stateService: StoreStateService, private customerService: CustomerService) {

  }
  ngOnInit(): void {
    this.stateService.selectedCustomer$.subscribe((customer) => {
      this.selectedCustomer = customer;
    });
    this.stateService.selectedOffer$.subscribe((offer) => {
      this.selectedOffer = offer;
    });
    this.stateService.selectedBookingInformation$.subscribe((bookingInformation) => {
      this.selectedBookingInformation = bookingInformation;
    });
  }

  getCustomer() {
    this.customerService.getCustomer(this.customerFormControl.value);
  }
}
