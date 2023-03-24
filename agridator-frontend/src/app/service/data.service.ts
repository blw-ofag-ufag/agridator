import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor() { }

  // keys are used to determine additional lists in pre-trakcing-infos
  getActionTypes ()
  {
    return [ 
      {key:"keyA", value: "Düngen"},
      {key:"keyB", value: "Sprühen"},
      {key:"keyC", value: "Aktion C"}
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
      {key:"keyPPPA", value:"Pflanzenschutzproduct A"},
      {key:"keyPPPB", value:"Pflanzenschutzproduct B"},
      {key:"keyPPPC", value:"Pflanzenschutzproduct C"},
      {key:"keyPPPD", value:"Pflanzenschutzproduct D"},
    ]
  }
}
