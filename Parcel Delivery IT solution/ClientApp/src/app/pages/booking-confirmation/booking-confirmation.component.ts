import { Component, OnInit } from '@angular/core';
import { BookingInformationInterface } from 'src/app/interfaces/booking-information.interface';
import { StoreStateService } from 'src/app/store/store-state.service';

@Component({
  selector: 'app-booking-confirmation',
  templateUrl: './booking-confirmation.component.html',
  styleUrls: ['./booking-confirmation.component.scss']
})
export class BookingConfirmationComponent implements OnInit {
  bookingInformationDetails: BookingInformationInterface = {};
  bookingInformation: BookingInformationInterface | null;

  // constructor(private readonly storeStateService: StoreStateService) { 
  //   this.storeStateService.selectedBookingInformation$.subscribe((bookingInformation: null | BookingInformationInterface) => {
  //     this.bookingInformationDetails = {
  //       ...bookingInformation
  //     };
  //   });
  // }

  ngOnInit(): void {
  }
}
