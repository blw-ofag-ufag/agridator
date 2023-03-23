import { Component } from '@angular/core';
import {  FormBuilder } from '@angular/forms';
import { DataService } from './service/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent  {
  title = 'Agridator';

  constructor(private dataService: DataService, private fb: FormBuilder) {

  }

}
