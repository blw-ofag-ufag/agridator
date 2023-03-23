import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor() { }

  getActionTypes ()
  {
    return [ 
      {key:"keyA", value: "Aktion A"},
      {key:"keyB", value: "Aktion B"},
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
}
