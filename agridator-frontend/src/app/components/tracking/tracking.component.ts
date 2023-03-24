import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tracking',
  templateUrl: './tracking.component.html',
  styleUrls: ['./tracking.component.scss']
})
export class TrackingComponent {
  points: any[] = [];
  tracking = false;
  interval = 1000;
  timer: any = null;
  config: any = null;
  constructor(private router: Router) {
    this.config = this.router.getCurrentNavigation()?.extras.state;
  }

  getIcon() {
    return this.tracking ? "stop" : "play_arrow";
  }

  hasValidTracking() {
    return !this.tracking && this.points.length > 2;
  }

  toggleTracking() {

    this.tracking = !this.tracking;

    if (this.tracking) {
      this.startRecording();
    }
    else {
      this.stopRecording();
    }
  }

  startRecording() {
    this.timer = setInterval(() => this.getLocation(), this.interval);
  }

  getLocation() {
    if (navigator.geolocation) {
      navigator.geolocation.getCurrentPosition(
        (position) => {
          if (position) {
            console.log(position.coords.latitude, position.coords.longitude);
            this.points.push(
              {
                lat: position.coords.latitude,
                lng: position.coords.longitude,
              }
            )
          }
        },
        (error) => { console.log(error) }
      )
    } else {
      alert("Geolocation is not supported by this browser");
    }
  }

  stopRecording() {
    clearInterval(this.timer);
    this.timer = null;
  }

  finishTracking() {
    this.router.navigate(["/post-tracking-infos"], {
      state:
      {
        config: this.config,
        points: this.points
      }
    })
  }

  moveToPreTracking() 
  {
    this.router.navigate(["/pre-tracking-infos"])
  }
}
