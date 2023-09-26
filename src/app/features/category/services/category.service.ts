import { HttpClient } from '@angular/common/http';
import { AddCategoryRequest } from '../models/add-category-request.model';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private http:HttpClient) { }

  addCategory(model: AddCategoryRequest): Observable <void>{
    return this.http.post<void>('https://localhost:7222/api/catagories', model);

  }

}
