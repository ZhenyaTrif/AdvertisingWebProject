import { Injectable } from '@angular/core';
import { Advertising } from '../advertising-panel/models/advertising';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AdvertisingService {

  formData: Advertising;

  readonly BaseURL = 'http://localhost:53285/api';

  constructor(private http: HttpClient) { }

  postAdvertising(formData: Advertising){
    return this.http.post(this.BaseURL+"/AdvertisingModels", formData);
  }
}
