import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { BotaoControleComponent } from './botao-controle/botao-controle.component';
import { FormBuscaComponent } from './form-busca.component';
import { ModalComponent } from './modal/modal.component';
import { SeletorPassageirosComponent } from './seletor-passageiros/seletor-passageiros.component';
import { MaterialModule } from 'src/app/core/material/material.module';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [
    FormBuscaComponent,
    ModalComponent,
    BotaoControleComponent,
    SeletorPassageirosComponent,
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MaterialModule,
    SharedModule
  ],
  exports: [
    FormBuscaComponent
  ]
})
export class FormBuscaModule { }
