import { DOCUMENT } from '@angular/common';
import {  Component, ElementRef, Renderer2, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Inject } from "@angular/core"
import { LocalStorageService } from 'src/app/service/local-storage.service';
import { DataService } from './../../service/data.service';


@Component({
  selector: 'app-post-tracking-infos',
  templateUrl: './post-tracking-infos.component.html',
  styleUrls: ['./post-tracking-infos.component.scss']
})
export class PostTrackingInfosComponent  {
  config: any;
  points: any[] =[];
  ownedFields: any[] = [];
  workTypes: any[] = [];
  fertilizers: any[] = [];
  plantProtectionProducts: any[] = [];
  map : any = null;
  center : google.maps.LatLng = new google.maps.LatLng({lat:0, lng: 0});

  constructor(private router: Router,  @Inject(DOCUMENT) private document: Document,
  private renderer2: Renderer2, private dataService: DataService, private localStorageService: LocalStorageService)
  {

    let state = this.router.getCurrentNavigation()?.extras.state;
    if (state !== undefined) {
      this.config = state['config'];
      this.points = state['points'];
      this.workTypes = this.dataService.getTypeOfWork();
      this.ownedFields = this.dataService.getOwnedFields();
      this.fertilizers = this.dataService.getFertilizier();
      this.plantProtectionProducts = this.dataService.getPlantProtectionProducts();
    }
    else {
      this.router.navigate(["/pre-tracking-infos"])
    }
  }


  ngOnInit() {
    this.center = this.calculateCenter();
  }

  public onMapReady(map: google.maps.Map): void {
    
    console.log("hey", map)
    this.map = map;

    
    const flightPlanCoordinates = [
      { lat: 47.5644, lng: 7.5715 },
      { lat: 47.5654, lng: 7.5710 },
      { lat: 47.5642, lng: 7.4715 },
      { lat: 47.5644, lng: 7.5715 },
    ];
  

    const flightPath = new google.maps.Polyline({
      path: this.points,
      geodesic: true, 
      strokeColor: "#FF0000",
      strokeOpacity: 1.0,
      strokeWeight: 2,
    });
    flightPath.setMap(map);
  }
  calculateCenter()
  {
    let sumPos = { lat:0, long:0 }
    for(let p of this.points )
    {
      sumPos.lat += p.lat;
      sumPos.long += p.lng;
    }

    sumPos.lat /= this.points.length;
    sumPos.long /= this.points.length;

    return new google.maps.LatLng({lat: sumPos.lat, lng: sumPos.long}, true);
  }

  moveToCalendar() 
  {
    this.localStorageService.setFeldkalender(['todo']);
    this.router.navigate(["/feldkalender"])
  }
}
