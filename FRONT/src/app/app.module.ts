import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { AlunoListarComponent } from './pages/aluno/aluno-listar/aluno-listar.component';
import { BrowserModule } from '@angular/platform-browser';
import { ImcListarComponent } from './pages/imc/imc-listar/imc-listar.component';
import { AlunoCadastrarComponent } from './pages/aluno/aluno-cadastrar/aluno-cadastrar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms'; // Importe o FormsModule
import { ImcCadastrarComponent } from './pages/imc/imc-cadastrar/imc-cadastrar.component';

@NgModule({
  declarations: [AppComponent,
    AlunoListarComponent, AlunoCadastrarComponent, ImcListarComponent, ImcCadastrarComponent],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule, BrowserAnimationsModule, FormsModule],
  providers: [], bootstrap: [AppComponent]
}) export class AppModule { }