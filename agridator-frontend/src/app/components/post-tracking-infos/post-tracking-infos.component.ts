import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-post-tracking-infos',
  templateUrl: './post-tracking-infos.component.html',
  styleUrls: ['./post-tracking-infos.component.scss']
})
export class PostTrackingInfosComponent {
  config: any;
  points: any[] =[];
  constructor(private router : Router )
  {
    let state = this.router.getCurrentNavigation()?.extras.state;
    if(state !== undefined)
    {
      this.config = state['config'];
      this.points = state['points'];
    }
    else 
    {
      this.router.navigate(["/pre-tracking-infos"])
    }
  }
}
