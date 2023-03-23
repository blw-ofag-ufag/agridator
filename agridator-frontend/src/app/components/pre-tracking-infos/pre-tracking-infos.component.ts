import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormArray, FormBuilder, FormGroup, ValidationErrors, ValidatorFn, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { DataService } from './../../service/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './pre-tracking-infos.component.html',
  styleUrls: ['./pre-tracking-infos.component.scss']
})
export class PreTrackingInfosComponent implements OnInit {
  title = 'Agridator';
  ownedFields : any[] = [];
  allowedActionTypes : any[] = [];
  form: FormGroup = new FormGroup({});

  constructor(private dataService: DataService,
              private fb: FormBuilder,
              private router: Router) {
    this.allowedActionTypes = this.dataService.getActionTypes();
    this.ownedFields = this.dataService.getOwnedFields();
  }

  ngOnInit(): void {
    this.form = this.fb.group({
      field: [null, [Validators.required]],
      actions: this.fb.array([], this.atLeastOne())
    });
  }


  get actions() {
    return this.form.controls["actions"] as FormArray;
  }

  addAction() {
    const actionForm = this.fb.group({
        actionType: ['', Validators.required]
    });

    this.actions.push(actionForm);
  }

  deleteAction(actionIndex: number) {
      this.actions.removeAt(actionIndex);
  }

  atLeastOne(): ValidatorFn {
    return (control:AbstractControl) : ValidationErrors | null => {
      return (control as FormArray).controls.length == 0 ?  {noAction: control.value} : null;
    }
  }

  onSubmit(form: FormGroup) {
    this.router.navigate(['tracking']);
  }
}
