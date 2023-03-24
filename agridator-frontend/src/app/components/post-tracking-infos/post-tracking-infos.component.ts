import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LocalStorageService } from 'src/app/service/local-storage.service';
import { DataService } from './../../service/data.service';

@Component({
  selector: 'app-post-tracking-infos',
  templateUrl: './post-tracking-infos.component.html',
  styleUrls: ['./post-tracking-infos.component.scss']
})
export class PostTrackingInfosComponent {
  config: any;
  points: any[] =[];
  ownedFields: any[] = [];
  workTypes: any[] = [];
  fertilizers: any[] = [];
  plantProtectionProducts: any[] = [];
  
  constructor(private dataService: DataService,
              private router : Router,
              private localStorageService: LocalStorageService)
  {
    let state = this.router.getCurrentNavigation()?.extras.state;
    if(state !== undefined)
    {
      this.config = state['config'];
      this.points = state['points'];
      this.workTypes = this.dataService.getActionTypes();
      this.ownedFields = this.dataService.getOwnedFields();
      this.fertilizers = this.dataService.getFertilizier();
      this.plantProtectionProducts = this.dataService.getPlantProtectionProducts();
    }
    else 
    {
      this.router.navigate(["/pre-tracking-infos"])
    }
  }

  moveToCalendar() 
  {
    this.localStorageService.setFeldkalender(this.points);
    this.router.navigate(["/feldkalender"])
  }
}
