import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PreTrackingInfosComponent } from './components/pre-tracking-infos/pre-tracking-infos.component';
import { TrackingComponent } from './components/tracking/tracking.component';
import { PostTrackingInfosComponent } from './components/post-tracking-infos/post-tracking-infos.component';

@NgModule({
  declarations: [
    AppComponent,
    PreTrackingInfosComponent,
    TrackingComponent,
    PostTrackingInfosComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
