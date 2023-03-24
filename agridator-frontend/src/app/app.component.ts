import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router, Routes } from '@angular/router';
import { DataService } from './service/data.service';
import {TranslateService} from "@ngx-translate/core";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent  {
  title = 'Agridator';


  constructor(private dataService: DataService,
              private fb: FormBuilder,
              private router: Router,
              private translate: TranslateService) {
                translate.setDefaultLang('de');
                translate.use('de'); 
  }

  useLanguage(language: string): void {
    this.translate.use(language); 

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
