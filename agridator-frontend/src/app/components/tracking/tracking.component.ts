import { Component } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tracking',
  templateUrl: './tracking.component.html',
  styleUrls: ['./tracking.component.scss']
})
export class TrackingComponent {
  form: FormGroup = new FormGroup({});

  constructor(private router: Router) {}

  onSubmit(form: FormGroup) {
    this.router.navigate(['post-tracking-infos']);
  }
}
