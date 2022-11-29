import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { TestimonyDTOModel } from '../models/testimony-dto.model';
import { ResourceTypeEnum } from '../models/resource-type.enum';
import { ResourceModel } from '../models/resource.model';


@Injectable({
  providedIn: 'root'
})
export class TestimonyService {

  baseUrl: string = "/api/Testimony/";
  constructor(private _http: HttpClient) { }

  getTestimonyInfo():Observable<TestimonyDTOModel> {
    return this._http.get<TestimonyDTOModel>(this.baseUrl)
  }
  getTestimonyResourceByType(type: ResourceTypeEnum):Observable<ResourceModel> {
    return this._http.get<ResourceModel>(this.baseUrl+'resource/'+type)
  }
}
