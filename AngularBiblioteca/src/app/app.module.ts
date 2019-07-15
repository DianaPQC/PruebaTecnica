import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { CategoriaListComponent } from './categoria/categoria-list/categoria-list.component';
import { AutorListComponent } from './autor/autor-list/autor-list.component';
import { LibroListComponent } from './libro/libro-list/libro-list.component';
import { CreateCategoriaComponent } from './categoria/create-categoria/create-categoria.component';
@NgModule({
  declarations: [
    AppComponent,
    CategoriaListComponent,
    AutorListComponent,
    LibroListComponent,
    CreateCategoriaComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
