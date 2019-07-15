import { Component, OnInit } from '@angular/core';
import { CategoriaService } from '../../models/categoria.service';
import { Categoria } from '../../models/categoria';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-categoria',
  templateUrl: './create-categoria.component.html',
  styleUrls: ['./create-categoria.component.css']
})
export class CreateCategoriaComponent implements OnInit {

  categoria: Categoria = new Categoria();
  submitted = false;

  constructor(private categoriaService: CategoriaService, private router: Router) { }

  ngOnInit() {
  }

  newCategoria(): void {
    this.submitted = false;
    this.categoria = new Categoria();
  }

  save() {
    this.categoriaService.createCategoria(this.categoria)
      .subscribe(data => console.log(data), error => console.log(error));
    this.categoria = new Categoria();
    this.gotoList();
  }

  onSubmit() {
    this.submitted = true;
    this.save();
  }

  gotoList() {
    this.router.navigate(['/categorias']);
  }

}
