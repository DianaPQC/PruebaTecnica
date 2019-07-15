import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from "rxjs";
import { CategoriaService } from '../../models/categoria.service';
import { Categoria } from '../../models/categoria';


@Component({
  selector: 'app-categoria-list',
  templateUrl: './categoria-list.component.html',
  styleUrls: ['./categoria-list.component.css']
})
export class CategoriaListComponent implements OnInit {

  categorias: Observable<Categoria[]>;
  constructor(private categoriaService: CategoriaService, private router: Router) { }

  ngOnInit() {
    this.reloadData();
  }

  reloadData()
  // tslint:disable-next-line:one-line
  {
    this.categorias = this.categoriaService.getCategoriasList();
  }
}
