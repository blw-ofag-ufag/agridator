import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router, Routes } from '@angular/router';
import { DataService } from './service/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent  {
  title = 'Agridator';

  constructor(private dataService: DataService,
              private fb: FormBuilder,
              private router: Router) {
  }

  home() {
    this.router.navigate(['home']);
  }

  feldkalender() {
    this.router.navigate(['feldkalender']);
  }

  settings() {
    this.router.navigate(['settings']);
  }
}
