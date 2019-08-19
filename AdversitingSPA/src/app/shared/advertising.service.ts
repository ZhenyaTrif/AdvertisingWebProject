import { Injectable } from '@angular/core';
import { Advertising } from '../advertising-panel/models/advertising';
import { HttpClient } from '@angular/common/http';
import { AdvertisingCategory } from '../advertising-panel/models/advertisingCategory';

@Injectable({
  providedIn: 'root'
})
export class AdvertisingService {

  list: Advertising[];
  clist: AdvertisingCategory[];

  formData: Advertising;
  formCData: AdvertisingCategory;

  readonly BaseURL = 'http://localhost:53285/api';

  constructor(private http: HttpClient) { }

  postAdvertising(formData: Advertising){
    return this.http.post(this.BaseURL+"/AdvertisingModels", formData);
  }

  postAdCategory(formCData: AdvertisingCategory){
    return this.http.post(this.BaseURL+"/AdvertisingCategories", formCData);
  }

  updateList(){
    this.http.get(this.BaseURL+'/AdvertisingModels')
    .toPromise()
    .then(res => this.list = res as Advertising[]);
  }

  updateCList(){
    this.http.get(this.BaseURL+'/AdvertisingCategories')
    .toPromise()
    .then(res => this.clist = res as AdvertisingCategory[]);
  }

  getAdDetails(id: number){
    return this.http.get(this.BaseURL + '/AdvertisingModels/' + id);
  }


}
