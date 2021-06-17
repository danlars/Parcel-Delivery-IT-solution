import { Component, Input, OnInit } from '@angular/core';
import * as uuid from 'uuid';

@Component({
  selector: 'app-offer',
  templateUrl: './offer.component.html',
  styleUrls: ['./offer.component.scss']
})
export class OfferComponent implements OnInit {
  offerId: string = '';
  
  @Input()
  deliveryTime: string = '';

  @Input()
  packageType: string = '';

  ngOnInit() {
    //this.offerId = uuid.v4();
  }

}
