import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class CustomerService {
  constructor(private readonly http: HttpClient) {}

  getCustomer(customerId: string) {
    this.http.get("/Customer", { params: {customerId} });
  }
}
