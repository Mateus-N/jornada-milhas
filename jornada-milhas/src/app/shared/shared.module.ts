import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ReactiveFormsModule } from "@angular/forms";

import { FooterComponent } from "./footer/footer.component";
import { BannerComponent } from "./banner/banner.component";
import { CardComponent } from "./card/card.component";
import { ContainerComponent } from "./container/container.component";
import { DropdownUfComponent } from "./dropdown-uf/dropdown-uf.component";
import { HeaderComponent } from "./header/header.component";
import { FormBaseComponent } from "./form-base/form-base.component";
import { MaterialModule } from "../core/material/material.module";
import { AppRoutingModule } from "../app-routing.module";

@NgModule({
  declarations: [
    FooterComponent,
    BannerComponent,
    CardComponent,
    ContainerComponent,
    HeaderComponent,
    DropdownUfComponent,
    FormBaseComponent,
  ],
  imports: [
    CommonModule,
    MaterialModule,
    ReactiveFormsModule,
    AppRoutingModule
  ],
  exports: [
    FooterComponent,
    BannerComponent,
    CardComponent,
    ContainerComponent,
    HeaderComponent,
    DropdownUfComponent,
    FormBaseComponent,
  ]
})
export class SharedModule { }