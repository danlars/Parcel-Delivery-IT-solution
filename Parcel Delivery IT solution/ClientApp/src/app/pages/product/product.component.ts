import { Component, OnInit } from '@angular/core';
import { BookingInformationInterface } from 'src/app/interfaces/booking-information.interface';
import { OfferInterface } from 'src/app/interfaces/offer.interface';
import { StoreStateService } from 'src/app/store/store-state.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {
  offers: OfferInterface[] = [];
  bookingInformation: BookingInformationInterface = {};
  constructor(private readonly stateService: StoreStateService) {
    this.stateService.offers$.subscribe((offers) => {
      this.offers = offers;
    });
    this.stateService.selectedBookingInformation$.subscribe((bookingInformation) => {
      if (bookingInformation) {
        this.bookingInformation = bookingInformation;
      }
    });
   }

  ngOnInit(): void {
  }

  submitBookingInformation() {
    this.setBookingInformation();
  }

  setBookingInformation() {

  }
}
