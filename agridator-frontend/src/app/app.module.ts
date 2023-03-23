import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

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
import { MatCardModule } from '@angular/material/card';
import { PreTrackingInfosComponent } from './components/pre-tracking-infos/pre-tracking-infos.component';
import { TrackingComponent } from './components/tracking/tracking.component';
import { PostTrackingInfosComponent } from './components/post-tracking-infos/post-tracking-infos.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: 'pre-tracking-infos', component: PreTrackingInfosComponent},
  {path: 'tracking', component: TrackingComponent},
  {path: 'post-tracking-infos', component: PostTrackingInfosComponent},
  {path: '**', pathMatch: 'full', redirectTo: 'pre-tracking-infos'}
]

@NgModule({
  declarations: [
    AppComponent,
    PreTrackingInfosComponent,
    TrackingComponent,
    PostTrackingInfosComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes, {useHash: true}),
    BrowserModule,
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
    MatCardModule,
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
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
