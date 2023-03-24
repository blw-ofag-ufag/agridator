import { Component, OnInit } from '@angular/core';
import { LocalStorageService } from 'src/app/service/local-storage.service';
import {TranslateService} from "@ngx-translate/core";
import { FeldkalenderDto } from 'src/app/dto/feldkalender-dto';
import { DataService } from 'src/app/service/data.service';

@Component({
  selector: 'app-feldkalender',
  templateUrl: './feldkalender.component.html',
  styleUrls: ['./feldkalender.component.scss']
})
export class FeldkalenderComponent implements OnInit {

  feldkalenderArray?: FeldkalenderDto[];

  constructor(private localStorageService: LocalStorageService,  private translate: TranslateService,
    private dataService: DataService) {}

  useLanguage(language: string): void {
    this.translate.use(language);
    }

  ngOnInit(): void {
    this.feldkalenderArray = this.localStorageService.getFeldkalender();
  }

  getCultureByKey(key:any)
  {
    return this.dataService.getCultures().find(o => o.id == key);
  }

  getWorkByKey(key:any)
  {
    return this.dataService.getTypeOfWork().find(o => o.id == key);
  }

  getOwnedFieldByKey(key:any)
  {
    console.log(this.dataService.getOwnedFields());
    return this.dataService.getOwnedFields().find(o => o.key == key);
  }
}
