import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { CustomerInterface } from "src/app/interfaces/customer.interface";
import { StoreStateService } from "src/app/store/store-state.service";

@Injectable()
export class CustomerService {
  constructor(private readonly http: HttpClient, private readonly storeStateService: StoreStateService) {}

  getCustomer(customerId: string) {
    this.http.get("/Customer", { params: {customerId} }).subscribe((response) => {
      const customer = response as CustomerInterface;
      this.storeStateService.setCustomer(customer);
    });
  }
}
