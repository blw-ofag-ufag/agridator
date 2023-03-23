import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LocalStorageService {

  constructor() { }

  setFeldkalender(feldkalender: string[]) {
    localStorage.setItem('feldkalender', JSON.stringify(feldkalender));
  }

  getFeldkalender(): string[] | undefined {
    const feldkalender = localStorage.getItem('feldkalender');
    if (feldkalender) {
      return JSON.parse(feldkalender);
    }
    return undefined;
  }
}
