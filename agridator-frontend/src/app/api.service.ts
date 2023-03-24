import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private httpClient: HttpClient) { }

  public getTypeOfWork(){
    return this.httpClient.get(`http://localhost:5011/api/Catalog/TypeOfWork`);
  }

  public getCultures(){
    return this.httpClient.get(`http://localhost:5011/api/Catalog/Cultures`);
  }

  public getCultureCategories(){
    return this.httpClient.get(`http://localhost:5011/api/Catalog/CultureCategories`);
  }

  public getFertilizers(){
    return this.httpClient.get(`http://localhost:5011/api/Catalog/Fertilizers`);
  }

  public getPlantProtectionProducts(){
    return this.httpClient.get(`http://localhost:5011/api/Catalog/PlantProtectionProducts`);
  }

  public getUsageTypes(){
    return this.httpClient.get(`http://localhost:5011/api/Catalog/UsageTypes`);
  }
  
  
}

