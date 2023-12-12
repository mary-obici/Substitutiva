import { Component } from '@angular/core';
import { Aluno } from '../../../Models/aluno.model';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Imc } from '../../../Models/imc.model';

@Component({
  selector: 'app-imc-cadastrar',
  templateUrl: './imc-cadastrar.component.html',
  styleUrl: './imc-cadastrar.component.css'
})
export class ImcCadastrarComponent {

  constructor(
    private client: HttpClient,
    private router: Router,
  ) {}
  altura: number = 0;
  peso: number = 0;
  alunoId: number = 0;
  ImcId: number = 0;
  valorImc: number = 0;
  classificacao: string = "";
  alunos: Aluno[] = [];
  
  ngOnInit(): void {
    this.client
      .get<Aluno[]>("https://localhost:7269/api/aluno/listar")
      .subscribe({
        next: (alunos) => {
          console.table(alunos);
          this.alunos = alunos;
        },
      });
  }
  cadastrarImc(): void {
    let imcs: Imc = {
      altura: this.altura,
      peso: this.peso,
      alunoId: this.alunoId,
      ImcId: this.ImcId,
      valorImc: this.valorImc,
      classificacao: this.classificacao,
    };

    this.client
      .post<Imc>("https://localhost:7269/api/imc/cadastrar", imcs)
      .subscribe({
        next: (imc) => {
          this.router.navigate(["pages/imc/imc-listar"]);
          alert('imc cadastrado com sucesso');
        },
        error: (erro) => {
          console.log(erro);
          alert('Erro ao cadastrar imc');
        },
      });
  }
} 
