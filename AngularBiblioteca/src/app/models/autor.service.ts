import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})

export class AutorService {

  private baseUrl = environment.apiUrl +  'autores/GetAllAutores';

  constructor(private http: HttpClient) { }

  getAutor(id: number): Observable<object> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }

  createAutor(autor: any): Observable<object> {
    return this.http.post(`${this.baseUrl}`, autor);
  }

  updateAutor(id: number, value: any): Observable<object> {
    return this.http.put(`${this.baseUrl}/${id}`, value);
  }

  deleteAutor(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/${id}`, { responseType: 'text' });
  }

  getAutoresList(): Observable<any> {
    return this.http.get(`${this.baseUrl}`);
  }
}
