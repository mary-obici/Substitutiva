import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Imc } from '../../../Models/imc.model';

@Component({
  selector: 'app-imc-listar',
  templateUrl: './imc-listar.component.html',
  styleUrl: './imc-listar.component.css'
})
export class ImcListarComponent {
  imcs: Imc[] = []
  constructor(private client: HttpClient,) { }
  ngOnInit(): void {
    console.log("Componente ok");
    this.client.get<Imc[]>(" https://localhost:7269/api/imc/listar")
      .subscribe({
        next: (imcs) => {
          this.imcs = imcs;
          console.table(imcs);
        }, error: (erro) => { console.log(erro); }
      })
  }
}
