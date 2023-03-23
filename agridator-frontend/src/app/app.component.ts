import { Component } from '@angular/core';
import {  FormBuilder } from '@angular/forms';
import { DataService } from './service/data.service';
import {TranslateService} from "@ngx-translate/core";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent  {
  title = 'Agridator';


    constructor(private dataService: DataService, private translate: TranslateService) {
		this.actions = this.dataService.getActions();
		translate.setDefaultLang('de');
		translate.use('de'); 
	}


  useLanguage(language: string): void {
     this.translate.use(language); 
  }
}
