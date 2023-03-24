import { DOCUMENT } from '@angular/common';
import {  Component, ElementRef, Renderer2, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Inject } from "@angular/core"
import { FeldkalenderDto } from 'src/app/dto/feldkalender-dto';
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
    const flightPlanCoordinates = [
      { lat: 46.947975, lng: 7.447447 },
      { lat: 46.9479732, lng: 7.4474413 },
      { lat: 46.947974873, lng: 7.447445322 },
      { lat: 46.9479751232232, lng: 7.447446821312 },
      { lat: 46.947975013123123, lng: 7.4474469322 },
    ];

    this.center = this.calculateCenter(flightPlanCoordinates);
  }

  public onMapReady(map: google.maps.Map): void {

    console.log("hey", map)
    this.map = map;


    const flightPlanCoordinates = [
      { lat: 46.947465, lng: 7.447447 },
      { lat: 46.9479432, lng: 7.4474513 },
      { lat: 46.947984813, lng: 7.447445322 },
      { lat: 46.9479551234232, lng: 7.44742321312 },
      { lat: 46.947975013123123, lng: 7.4473469322 },
    ];


    const flightPath = new google.maps.Polygon({
      paths: [flightPlanCoordinates],
      geodesic: true, 
      strokeColor: "#FF0000",
      strokeOpacity: 1.0,
      strokeWeight: 2,
    });
    flightPath.setMap(map);
  }

  discardTrack()
  {
    this.router.navigate(["pre-tracking-infos"]);
  }

  calculateCenter(points :any[])
  {
    let sumPos = { lat:0, long:0 }
    for(let p of points )
    {
      sumPos.lat += p.lat;
      sumPos.long += p.lng;
    }

    sumPos.lat /=  points.length;
    sumPos.long /= points.length;

    return new google.maps.LatLng({lat: sumPos.lat, lng: sumPos.long}, true);
  }

  moveToCalendar()
  {
    const feldkalenderArray = this.localStorageService.getFeldkalender();
    const feldkalenderDto = new FeldkalenderDto();
    feldkalenderDto.config = this.config;
    feldkalenderDto.points = this.points;
    feldkalenderArray.push(feldkalenderDto);
    this.localStorageService.setFeldkalender(feldkalenderArray);
    this.router.navigate(["/feldkalender"])
  }


  convexHull(points : any[]) {
    // Sort points lexicographically
    points.sort(function(a, b) {
      return a.lat - b.lat || a.lng - b.lng;
    });

    // Find lower hull
    var lower = [];
    for (var i = 0; i < points.length; i++) {
      while (lower.length >= 2 && this.cross(lower[lower.length - 2], lower[lower.length - 1], points[i]) <= 0) {
        lower.pop();
      }
      lower.push(points[i]);
    }

    // Find upper hull
    var upper = [];
    for (var i = points.length - 1; i >= 0; i--) {
      while (upper.length >= 2 && this.cross(upper[upper.length - 2], upper[upper.length - 1], points[i]) <= 0) {
        upper.pop();
      }
      upper.push(points[i]);
    }

    // Concatenate and return hull
    return lower.slice(0, lower.length - 1).concat(upper.slice(0, upper.length - 1));
  }

  // Compute cross product of vectors p1p2 and p2p3
  cross(p1:any, p2:any, p3:any) {
    return (p2.lat - p1.lat) * (p3.lng - p2.lng) - (p2.lng - p1.lng) * (p3.lat - p2.lat);
  }

  getFertilizerByKey(key:any)
  {

    return this.dataService.getFertilizier().find(o => o.id == key);
  }

  getPPP(key:any)
  {
    console.log(key,this.dataService.getPlantProtectionProducts())
    return this.dataService.getPlantProtectionProducts().find(o => o.id == key);
  }

  getWorkByKey(key:any)
  {
    return this.dataService.getTypeOfWork().find(o => o.id == key);
  }

  getOwnedFieldByKey(key:any)
  {

    return this.dataService.getOwnedFields().find(o => o.key == key);
  }

  getCultureByKey(catId:any)
  {
    console.log(this.dataService.getCultures());
    return this.dataService.getCultures().find(o => o.catId == catId);
  }
}
