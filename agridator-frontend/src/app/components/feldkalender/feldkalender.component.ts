import { Component, OnInit } from '@angular/core';
import { LocalStorageService } from 'src/app/service/local-storage.service';

@Component({
  selector: 'app-feldkalender',
  templateUrl: './feldkalender.component.html',
  styleUrls: ['./feldkalender.component.scss']
})
export class FeldkalenderComponent implements OnInit {

  feldkalender?: string[];

  constructor(private localStorageService: LocalStorageService) {}

  ngOnInit(): void {
    this.feldkalender = this.localStorageService.getFeldkalender();
  }
}
