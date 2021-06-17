import { NgModule } from '@angular/core';
import { StoreStateService } from './store-state.service';
import {StoreModule} from '@ngrx/store';
import { reducers } from './reducers';


@NgModule({
  imports: [
    StoreModule.forRoot({
      appState: reducers
    })
  ],
  providers: [
    StoreStateService
  ]
})
export class AppStoreModule { }
