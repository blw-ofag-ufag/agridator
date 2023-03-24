import { Injectable } from '@angular/core';
import {TranslateService} from "@ngx-translate/core";


@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(
    private translate: TranslateService) {
      translate.setDefaultLang('de');
      translate.use('de'); 
}

useLanguage(language: string): void {
  this.translate.use(language); 
  }

  // keys are used to determine additional lists in pre-trakcing-infos
  getActionTypes ()
  {
    return [ 
      {key:"keyA", value: "Dünger - Engrais - Concimi"},
      {key:"keyB", value: "Pflanzenschutzmittel - Produits phytosanitaires - Prodotti fitosanitari"},
      {key:"keyC", value: "Action C"}
    ]
  };


  getOwnedFields()
  {
    return [
      {key:"keyX", value: "Feld X"},
      {key:"keyY", value: "Feld Y"},
      {key:"keyZ", value: "Feld Z"}
    ]
  }

  getFertilizier()
  {
    return [
      {key:"keyfa",value: "Fertilizier A"},
      {key:"keyfa",value: "Fertilizier B"},
      {key:"keyfa",value: "Fertilizier C"},
      {key:"keyfa",value: "Fertilizier D"},
    ]
  }

  getPlantProtectionProducts()
  {
    return [
      {key:"keyPPPA", value:"Pflanzenschutzmittel A"},
      {key:"keyPPPB", value:"Pflanzenschutzmittel B"},
      {key:"keyPPPC", value:"Pflanzenschutzmittel C"},
      {key:"keyPPPD", value:"Pflanzenschutzmittel D"},
    ]
  }
}
