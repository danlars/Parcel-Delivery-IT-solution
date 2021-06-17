import { Component, Input, OnInit } from "@angular/core";
import { OfferService } from "./offer.service";
import { OfferInterface } from "src/app/interfaces/offer.interface";
import { StoreStateService } from "src/app/store/store-state.service";
import * as uuid from "uuid";

@Component({
  selector: "app-offer",
  templateUrl: "./offer.component.html",
  styleUrls: ["./offer.component.scss"],
})
export class OfferComponent implements OnInit {
  offerId: string = "";
  constructor(private readonly offerService: OfferService) {
    this.offerId = uuid.v4();
  }

  @Input()
  offer: OfferInterface = {
    price: 1,
    time: 1,
    routeType: ''
  };

  ngOnInit() {
  }

  getDays() {
    const days = (this.offer.time / 24);
    if (days < 1) {
      return this.offer.time + ' hours';
    }
    return Math.ceil(days) + ' days';
  }

  getOfferType() {
    return this.offer.routeType;
  }

  isSelectedOffer() {
    return this.offerService.isSameOffer(this.offer);
  }

  setOffer() {
    this.offerService.setOffer(this.offer);
  }
}
