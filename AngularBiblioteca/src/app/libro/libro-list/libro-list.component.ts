import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from "rxjs";
import { LibroService } from '../../models/libro.service';
import { Libro } from '../../models/libro';

@Component({
  selector: 'app-libro-list',
  templateUrl: './libro-list.component.html',
  styleUrls: ['./libro-list.component.css']
})
export class LibroListComponent implements OnInit {

  libros: Observable<Libro[]>;
  constructor(private libroService: LibroService, private router: Router) { }

  ngOnInit() {
    this.reloadData();
  }

  reloadData()
  // tslint:disable-next-line:one-line
  {
    this.libros = this.libroService.getLibrosList();
  }


}
