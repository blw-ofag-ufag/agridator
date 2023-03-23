import { Component, OnInit } from '@angular/core';
import { LocalStorageService } from 'src/app/service/local-storage.service';

@Component({
  selector: 'app-feldkalender',
  templateUrl: './feldkalender.component.html',
  styleUrls: ['./feldkalender.component.scss']
})
export class FeldkalenderComponent implements OnInit {

  feldkalenderArray?: string[];

  constructor(private localStorageService: LocalStorageService) {}

  ngOnInit(): void {
    this.feldkalenderArray = this.localStorageService.getFeldkalender();
  }
}
