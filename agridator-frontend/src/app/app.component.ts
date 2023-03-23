import { Component } from '@angular/core';
import { DataService } from './service/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Agridator';
  actions : string[] = [];

  constructor(private dataService: DataService) {
    this.actions = this.dataService.getActions();
  }

}
