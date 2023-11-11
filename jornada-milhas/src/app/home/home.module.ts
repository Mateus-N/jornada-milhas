import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { CardBuscaComponent } from "./card-busca/card-busca.component";
import { CardDepoimentosComponent } from "./card-depoimentos/card-depoimentos.component";
import { HomeComponent } from "./home.component";
import { MaterialModule } from "src/app/core/material/material.module";
import { SharedModule } from "src/app/shared/shared.module";
import { FormBuscaModule } from "../form-busca/form-busca.module";
import { HomeRoutingModule } from "./home-routing.module";

@NgModule({
  declarations: [
    CardBuscaComponent,
    CardDepoimentosComponent,
    HomeComponent,
  ],
  imports: [
    CommonModule,
    MaterialModule,
    SharedModule,
    FormBuscaModule,
    HomeRoutingModule
  ],
  exports: [
    HomeComponent,
  ]
})
export class HomeModule { }