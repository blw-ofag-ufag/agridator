import { ViewEncapsulation } from '@angular/compiler';
import { getTestBed } from '@angular/core/testing';
import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormArray, FormBuilder, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { DataService } from './../../service/data.service';
import { ApiService } from '../../api.service';

const USE_API = false;

@Component({
  selector: 'app-root',

  templateUrl: './pre-tracking-infos.component.html',
  styleUrls: ['./pre-tracking-infos.component.scss'],
  
})
export class PreTrackingInfosComponent implements OnInit {
  title = 'Agridator';
  showFertilizerList = false;
  showCultures = false;
  showPlantProtectionProducts = false;
  ownedFields: any[] = [];
  workTypes: any[] = [];
  fertilizers: any[] = [];
  cultures: any[] = [];
  plantProtectionProducts: any[] = [];
  form: FormGroup = new FormGroup({});

  constructor(private apiService: ApiService, private dataService: DataService, private fb: FormBuilder, private router: Router) {
    this.ownedFields = this.dataService.getOwnedFields();
    if(!USE_API){
      this.workTypes = this.dataService.getTypeOfWork();
      this.cultures = this.dataService.getCultures();
      this.fertilizers = this.dataService.getFertilizier();
      this.plantProtectionProducts = this.dataService.getPlantProtectionProducts();
      this.plantProtectionProducts.map(item=>item.companyNameShort = item.companyName.split("-")[0]);      // this.addActions();
    }

  }

  ngOnInit(): void {
    this.form = this.fb.group({
      field: [null, [Validators.required]],
      actions: this.fb.array([], this.atLeastOne()),
      fertilizer: [null],
      cultures:[null],
      plantProtectionProduct: [null]
    });
    if(USE_API){
      this.apiService.getTypeOfWork().subscribe((data)=>{
        // console.log(JSON.stringify(data));
        this.workTypes = data as any[];
        this.addActions();
      });

      this.apiService.getFertilizers().subscribe((data)=>{
        // console.log(JSON.stringify(data));
        this.fertilizers = data as any[];
      });

      this.apiService.getPlantProtectionProducts().subscribe((data)=>{
        console.log(JSON.stringify(data));
        this.plantProtectionProducts = data as any[];
        this.plantProtectionProducts.map(item=>item.companyNameShort = item.companyName.split("-")[0]);      // this.addActions();
      });

      this.apiService.getCultures().subscribe((data)=>{
        // console.log(JSON.stringify(data));
        this.cultures = data as any[];
      });
    }else{
      this.addActions();
    }

  }

  get actions() {
    return this.form.controls["actions"] as FormArray;
  }

  addActions() {
    console.log("this.workTypes",this.workTypes);
    this.workTypes.forEach(() => this.actions.push(new FormControl(false)))
  }

  onSubmit() {
    this.router.navigate(["/tracking"], {
      state: this.form.value
    })
  }

  atLeastOne(): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
      return (control as FormArray).controls.some(x => x.value == true) ? null : { noAction: control.value };
    }
  }

  toggleAdditionalOptions(event: any) {
    console.log("event",event);
    switch (event.source.value) {
      case 1:
        this.showCultures = event.checked;
        break;
      case 2:
        this.showFertilizerList = event.checked;
        break;
      case 3:
        this.showPlantProtectionProducts = event.checked
        break;
      default: break;
    }
  }
}
