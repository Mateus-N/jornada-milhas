import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ErroRoutingModule } from './erro-routing.module';
import { PaginaNaoEncontradoComponent } from './pagina-nao-encontrado/pagina-nao-encontrado.component';
import { SharedModule } from 'src/app/shared/shared.module';


@NgModule({
  declarations: [
    PaginaNaoEncontradoComponent
  ],
  imports: [
    CommonModule,
    ErroRoutingModule,
    SharedModule
  ]
})
export class ErroModule { }
