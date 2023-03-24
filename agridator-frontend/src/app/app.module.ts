import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { GoogleMapsModule } from '@angular/google-maps';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatNativeDateModule } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSortModule } from '@angular/material/sort';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatSelectModule } from '@angular/material/select';
import { MatRadioModule } from '@angular/material/radio';
import { MatButtonModule } from '@angular/material/button';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatCardModule } from '@angular/material/card';
import { MatDividerModule } from '@angular/material/divider';
import { PreTrackingInfosComponent } from './components/pre-tracking-infos/pre-tracking-infos.component';
import { TrackingComponent } from './components/tracking/tracking.component';
import { PostTrackingInfosComponent } from './components/post-tracking-infos/post-tracking-infos.component';
import {TranslateLoader, TranslateModule} from '@ngx-translate/core';
import {TranslateHttpLoader} from '@ngx-translate/http-loader';
import {HttpClient, HttpClientModule} from '@angular/common/http';
import { FormGroup, FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { FeldkalenderComponent } from './components/feldkalender/feldkalender.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { SettingsComponent } from './components/settings/settings.component'; 


const routes: Routes = [
  {path: 'pre-tracking-infos', component: PreTrackingInfosComponent},
  {path: 'tracking', component: TrackingComponent},
  {path: 'post-tracking-infos', component: PostTrackingInfosComponent},
  {path: 'feldkalender', component: FeldkalenderComponent},
  {path: 'settings', component: SettingsComponent},
  {path: '**', pathMatch: 'full', redirectTo: 'pre-tracking-infos'}
]


@NgModule({
  declarations: [
    AppComponent,
    PreTrackingInfosComponent,
    TrackingComponent,
    PostTrackingInfosComponent,
    FeldkalenderComponent,
    SettingsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(routes, {useHash: true}),
    BrowserAnimationsModule,
    MatTableModule,
    MatSortModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatIconModule,
    MatSelectModule,
    MatRadioModule,
    MatButtonModule,
    HttpClientModule,
    MatCheckboxModule,
    MatDividerModule,
    FlexLayoutModule,
    MatCardModule,
    ReactiveFormsModule,
    GoogleMapsModule,
    TranslateModule.forRoot({
      loader: {
          provide: TranslateLoader,
          useFactory: HttpLoaderFactory,
          deps: [HttpClient]
      }
  })
],
exports: [
    MatTableModule,
    MatSortModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatIconModule,
    MatSelectModule,
    MatRadioModule,
    MatButtonModule,
    MatCardModule,
    RouterModule
],
  providers: [ HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }

export function HttpLoaderFactory(http: HttpClient): TranslateHttpLoader {
  return new TranslateHttpLoader(http, './assets/i18n/');
}
