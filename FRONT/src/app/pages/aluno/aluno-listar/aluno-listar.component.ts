import { Component } from '@angular/core';
import { Aluno } from '../../../Models/aluno.model';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-aluno-listar',
  templateUrl: './aluno-listar.component.html',
  styleUrl: './aluno-listar.component.css'
})
export class AlunoListarComponent {
  alunos: Aluno[] = []
  constructor(private client: HttpClient,) { }
  ngOnInit(): void {
    console.log("Componente ok");
    this.client.get<Aluno[]>(" https://localhost:7269/api/aluno/listar")
      .subscribe({
        next: (alunos) => {
          this.alunos = alunos;
          console.table(alunos);
        }, error: (erro) => { console.log(erro); }
      })
  }
}
