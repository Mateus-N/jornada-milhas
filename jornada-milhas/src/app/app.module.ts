import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './shared/footer/footer.component';
import { BannerComponent } from './shared/banner/banner.component';
import { CardComponent } from './shared/card/card.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { ContainerComponent } from './shared/container/container.component';
import { HomeComponent } from './pages/home/home.component';
import { HeaderComponent } from './shared/header/header.component';
import { CardBuscaComponent } from './shared/card-busca/card-busca.component';
import { MatCardModule } from '@angular/material/card';
import { CardDepoimentosComponent } from './shared/card-depoimentos/card-depoimentos.component';
import { FormBuscaComponent } from './shared/form-busca/form-busca.component';
import { MatButtonToggleModule } from '@angular/material/button-toggle';
import { MatIconModule } from '@angular/material/icon';
import { MatChipsModule } from '@angular/material/chips';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { ModalComponent } from './shared/modal/modal.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatSliderModule } from '@angular/material/slider';
import { MatRadioModule } from '@angular/material/radio';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatDividerModule } from '@angular/material/divider';

import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { DropdownUfComponent } from './shared/form-busca/dropdown-uf/dropdown-uf.component';
import { BotaoControleComponent } from './shared/botao-controle/botao-controle.component';
import { SeletorPassageirosComponent } from './shared/seletor-passageiros/seletor-passageiros.component';
import { LoginComponent } from './pages/login/login.component';
import { FormBaseComponent } from './shared/form-base/form-base.component';
import { CadastroComponent } from './pages/cadastro/cadastro.component';
import { PerfilComponent } from './pages/perfil/perfil.component';
import { AutenticationInterceptor } from './core/interceptors/autentication.interceptor';
import { BuscaComponent } from './pages/busca/busca.component';
import { PassagemComponent } from './shared/passagem/passagem.component';
import { FiltrosComplementaresComponent } from './shared/form-busca/filtros-complementares/filtros-complementares.component';
import { CompanhiasComponent } from './shared/form-busca/filtros-complementares/companhias/companhias.component';
import { LabelComponent } from './shared/form-busca/filtros-complementares/label/label.component';
import { ParadasComponent } from './shared/form-busca/filtros-complementares/paradas/paradas.component';
import { PrecosComponent } from './shared/form-busca/filtros-complementares/precos/precos.component';
import { CardDestaquesComponent } from './shared/card-destaques/card-destaques.component';

@NgModule({
    declarations: [
        AppComponent,
        FooterComponent,
        BannerComponent,
        CardComponent,
        ContainerComponent,
        HomeComponent,
        HeaderComponent,
        CardBuscaComponent,
        CardDepoimentosComponent,
        FormBuscaComponent,
        ModalComponent,
        DropdownUfComponent,
        BotaoControleComponent,
        SeletorPassageirosComponent,
        LoginComponent,
        FormBaseComponent,
        CadastroComponent,
        PerfilComponent,
        BuscaComponent,
        PassagemComponent,
        FiltrosComplementaresComponent,
        CompanhiasComponent,
        LabelComponent,
        ParadasComponent,
        PrecosComponent,
        CardDestaquesComponent
    ],
    providers: [{
        provide: HTTP_INTERCEPTORS,
        useClass: AutenticationInterceptor,
        multi: true
    }],
    bootstrap: [AppComponent],
    imports: [
        BrowserModule,
        AppRoutingModule,
        BrowserAnimationsModule,
        MatToolbarModule,
        MatButtonModule,
        MatCardModule,
        MatButtonToggleModule,
        MatIconModule,
        MatChipsModule,
        MatFormFieldModule,
        MatInputModule,
        MatDatepickerModule,
        MatNativeDateModule,
        MatDialogModule,
        HttpClientModule,
        ReactiveFormsModule,
        MatAutocompleteModule,
        MatRadioModule,
        MatDividerModule,
        MatCheckboxModule,
        MatSliderModule
    ]
})
export class AppModule { }
