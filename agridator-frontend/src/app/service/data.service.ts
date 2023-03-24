import { Injectable } from '@angular/core';
import  Cultures  from './Cultures.json';
import  PlantProtectionProducts  from './PlantProtectionProducts.json';
import  Fertilizers  from './Fertilizers.json';
import  TypeOfWork  from './TypeOfWork.json';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor() { }

  // keys are used to determine additional lists in pre-trakcing-infos
  getTypeOfWork ()
  {
    return TypeOfWork
  };


  getOwnedFields()
  {
    return [
      {key:"keyX", value: "Feld neben Bauernhaus"},
      {key:"keyY", value: "Feld beim Wald"},
      {key:"keyZ", value: "Feld gepachtet von Hansruedi"}
    ]
  }

  getCultures()
  {
    return Cultures
  }

  getFertilizier()
  {
    return Fertilizers
  }

  getPlantProtectionProducts()
  {
    return PlantProtectionProducts
  }
}
