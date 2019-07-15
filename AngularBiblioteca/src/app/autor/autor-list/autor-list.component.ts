import { Component, OnInit } from '@angular/core';
import { AutorService } from '../../models/autor.service';
import { Router } from '@angular/router';
import { Observable } from "rxjs";
import { Autor } from '../../models/autor';

@Component({
  selector: 'app-autor-list',
  templateUrl: './autor-list.component.html',
  styleUrls: ['./autor-list.component.css']
})
export class AutorListComponent implements OnInit {

  autores: Observable<Autor[]>;
  constructor(private autorService: AutorService, private router: Router) { }

  ngOnInit() {
    this.reloadData();
  }

  reloadData()
  // tslint:disable-next-line:one-line
  {
    this.autores = this.autorService.getAutoresList();
  }

}
