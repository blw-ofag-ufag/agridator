import { Component, OnInit } from '@angular/core';
import { LocalStorageService } from 'src/app/service/local-storage.service';
import {TranslateService} from "@ngx-translate/core";
import { FeldkalenderDto } from 'src/app/dto/feldkalender-dto';

@Component({
  selector: 'app-feldkalender',
  templateUrl: './feldkalender.component.html',
  styleUrls: ['./feldkalender.component.scss']
})
export class FeldkalenderComponent implements OnInit {

  feldkalenderArray?: FeldkalenderDto[];

  constructor(private localStorageService: LocalStorageService,  private translate: TranslateService) {}

  useLanguage(language: string): void {
    this.translate.use(language); 
    }

  ngOnInit(): void {
    this.feldkalenderArray = this.localStorageService.getFeldkalender();
  }
}
