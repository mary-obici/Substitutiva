import { Component } from '@angular/core';
import { Aluno } from '../../../Models/aluno.model';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
@Component({
  selector: 'app-aluno-cadastrar',
  templateUrl: './aluno-cadastrar.component.html',
  styleUrl: './aluno-cadastrar.component.css'
})
export class AlunoCadastrarComponent {

  constructor(
    private client: HttpClient,
    private router: Router,
  ) {}
  alunoId: string = "";
  nome: string = "";
  nasc: string = "";

 
  cadastrarAlunos(): void {
    let alunos = {
      nome: this.nome,
      nasc: this.nasc
    };

   this.client
  .post<Aluno>(
    "https://localhost:7269/api/aluno/cadastrar",
    alunos
  )
  .subscribe({
    next: (aluno) => {
      this.router.navigate(["pages/aluno/aluno-listar"]);
      alert('Aluno cadastrado com sucesso');
    },
    error: (erro) => {
      console.log(erro);
      alert('Erro ao cadastrar aluno');
    },
  });

  }
}
