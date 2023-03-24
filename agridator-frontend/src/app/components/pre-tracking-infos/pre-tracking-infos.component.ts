import { ViewEncapsulation } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormArray, FormBuilder, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { DataService } from './../../service/data.service';
import {TranslateService} from "@ngx-translate/core";

@Component({
  selector: 'app-root',

  templateUrl: './pre-tracking-infos.component.html',
  styleUrls: ['./pre-tracking-infos.component.scss'],
  
})
export class PreTrackingInfosComponent implements OnInit {
  title = 'Agridator';
  showFertilizerList = false;
  showPlantProtectionProducts = false;
  ownedFields: any[] = [];
  workTypes: any[] = [];
  fertilizers: any[] = [];
  plantProtectionProducts: any[] = [];
  form: FormGroup = new FormGroup({});

  constructor(private dataService: DataService, private fb: FormBuilder, private router: Router, private translate: TranslateService) {
    this.workTypes = this.dataService.getActionTypes();
    this.ownedFields = this.dataService.getOwnedFields();
    this.fertilizers = this.dataService.getFertilizier();
    this.plantProtectionProducts = this.dataService.getPlantProtectionProducts();
  
  }

useLanguage(language: string): void {
this.translate.use(language); 
}

  ngOnInit(): void {
    this.form = this.fb.group({
      field: [null, [Validators.required]],
      actions: this.fb.array([], this.atLeastOne()),
      fertilizer: [null],
      plantProtectionProduct: [null]
    });

    this.addActions();
  }

  get actions() {
    return this.form.controls["actions"] as FormArray;
  }

  addActions() {
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
    console.log(event);
    switch (event.source.value) {
      case "keyA":
        this.showFertilizerList = event.checked;
        break;
      case "keyB":
        this.showPlantProtectionProducts = event.checked
        break;
      default: break;
    }
  }
}
