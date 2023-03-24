import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tracking',
  templateUrl: './tracking.component.html',
  styleUrls: ['./tracking.component.scss']
})
export class TrackingComponent {
  points : any[] = [];
  tracking = false;


  constructor(private router : Router)
  {
  }

  getIcon()
  {
    return this.tracking ? "stop": "play_arrow" ;
  }

  hasValidTracking()
  {
    return !this.tracking  && this.points.length > 2;
  }

  toggleTracking()
  {
    setInterval(() => this.points.push({x:3,y:3}), 1000);
    this.tracking = !this.tracking;
  }

  finishTracking()
  {
    this.router.navigate(["/post-tracking-infos"])
  }
}
