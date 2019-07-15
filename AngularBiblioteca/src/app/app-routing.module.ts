import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CategoriaListComponent } from './categoria/categoria-list/categoria-list.component';
import { AutorListComponent } from './autor/autor-list/autor-list.component';
import { LibroListComponent } from './libro/libro-list/libro-list.component';
import { CreateCategoriaComponent } from './categoria/create-categoria/create-categoria.component';


const routes: Routes = [
  { path: 'categorias', component: CategoriaListComponent },
  { path: 'autores', component: AutorListComponent },
  { path: 'libros', component: LibroListComponent },
  { path: 'addCategoria', component: CreateCategoriaComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
