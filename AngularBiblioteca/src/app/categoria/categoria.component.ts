import { Component, OnInit } from '@angular/core';
import {Categoria} from 'modules/categoria';
import {CategoriaService} from 'modules/categoria.service';
import { Observable } from "rxjs";
import { Router } from '@angular/router';

@Component({
  selector: 'app-categoria',
  templateUrl: './categoria.component.html',
  styleUrls: ['./categoria.component.scss']
})
export class CategoriaComponent implements OnInit {

  categorias: Observable<Categoria[]>;

  constructor(private categoriaService: CategoriaService, private router: Router) { }

  ngOnInit() {
    this.reloadData();
  }
  reloadData() {
    this.categorias = this.categoriaService.getCategorias();
  }
}
