import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BuscaComponent } from './busca.component';
import { CardDestaquesComponent } from './card-destaques/card-destaques.component';
import { CompanhiasComponent } from './filtros-complementares/companhias/companhias.component';
import { FiltrosComplementaresComponent } from './filtros-complementares/filtros-complementares.component';
import { LabelComponent } from './filtros-complementares/label/label.component';
import { ParadasComponent } from './filtros-complementares/paradas/paradas.component';
import { PassagemComponent } from './passagem/passagem.component';
import { PrecosComponent } from './filtros-complementares/precos/precos.component';
import { SharedModule } from '../shared/shared.module';
import { MaterialModule } from '../core/material/material.module';
import { ReactiveFormsModule } from '@angular/forms';
import { FormBuscaModule } from '../form-busca/form-busca.module';
import { BuscaRoutingModule } from './busca-routing.module';

@NgModule({
  declarations: [
    BuscaComponent,
    PassagemComponent,
    FiltrosComplementaresComponent,
    CompanhiasComponent,
    LabelComponent,
    ParadasComponent,
    PrecosComponent,
    CardDestaquesComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    MaterialModule,
    ReactiveFormsModule,
    FormBuscaModule,
    BuscaRoutingModule
  ],
  exports: [
    BuscaComponent,
  ]
})
export class BuscaModule { }
