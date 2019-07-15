import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';


@Injectable({
  providedIn: 'root'
})
export class LibroService {

  private baseUrl = environment.apiUrl +  'libros/GetAllLibros';

  constructor(private http: HttpClient) { }

  getLibro(id: number): Observable<object> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }

  createLibro(libro: any): Observable<object> {
    return this.http.post(`${this.baseUrl}`, libro);
  }

  updateLibro(id: number, value: any): Observable<object> {
    return this.http.put(`${this.baseUrl}/${id}`, value);
  }

  deleteLibro(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/${id}`, { responseType: 'text' });
  }

  getLibrosList(): Observable<any> {
    return this.http.get(`${this.baseUrl}`);
  }
}

