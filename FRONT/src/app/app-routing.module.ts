import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AlunoListarComponent } from "./pages/aluno/aluno-listar/aluno-listar.component";
import { ImcListarComponent } from "./pages/imc/imc-listar/imc-listar.component";
import { AlunoCadastrarComponent } from "./pages/aluno/aluno-cadastrar/aluno-cadastrar.component";
import { ImcCadastrarComponent } from "./pages/imc/imc-cadastrar/imc-cadastrar.component";
const routes: Routes = [{
    path: "",
    component: AlunoListarComponent,
},

{
    path: "pages/aluno/aluno-listar",
    component: AlunoListarComponent,
},
{
    path: "pages/aluno/aluno-cadastrar",
    component: AlunoCadastrarComponent,
},
{
    path: "pages/imc/imc-listar",
    component: ImcListarComponent,
},
{
    path: "pages/imc/imc-cadastrar",
    component: ImcCadastrarComponent,
}
];
@NgModule({
    imports:
        [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule { } 