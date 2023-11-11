import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PaginaNaoEncontradoComponent } from './pagina-nao-encontrado/pagina-nao-encontrado.component';

const routes: Routes = [
  {
    'path': 'paginaNaoEncontrada',
    component: PaginaNaoEncontradoComponent
  },
  {
    path: '**',
    redirectTo: '/paginaNaoEncontrada',
    pathMatch: 'full'
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ErroRoutingModule { }
