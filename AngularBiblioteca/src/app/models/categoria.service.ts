import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';



@Injectable({
  providedIn: 'root'
})
export class CategoriaService {

  private baseUrl = environment.apiUrl +  'categorias/GetAllCategorias';

  constructor(private http: HttpClient) { }

  getCategoria(id: number): Observable<object> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }

 /* createCategoria(nombre: string, descripcion: string ): Observable<object> {
    this.baseUrl = environment.apiUrl +  'categorias/AddCategoria';
    return this.http.post(`${this.baseUrl}`, {'nombre': nombre, 'descripcion': descripcion });
  }*/

  updateCategoria(id: number, value: any): Observable<object> {
    return this.http.put(`${this.baseUrl}/${id}`, value);
  }

  deleteCategoria(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/${id}`, { responseType: 'text' });
  }

  getCategoriasList(): Observable<any> {
    return this.http.get(`${this.baseUrl}`);
  }
}
