import { Injectable } from '@angular/core';
import { FeldkalenderDto } from '../dto/feldkalender-dto';

@Injectable({
  providedIn: 'root'
})
export class LocalStorageService {

  constructor() { }

  setFeldkalender(feldkalender: FeldkalenderDto[]) {
    localStorage.setItem('feldkalender', JSON.stringify(feldkalender));
  }

  getFeldkalender(): FeldkalenderDto[] {
    const feldkalender = localStorage.getItem('feldkalender');
    if (feldkalender) {
      return JSON.parse(feldkalender);
    }
    return [];
  }
}
