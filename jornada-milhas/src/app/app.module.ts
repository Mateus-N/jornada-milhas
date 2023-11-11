import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { SharedModule } from './shared/shared.module';
import { MaterialModule } from './core/material/material.module';
import { AutenticacaoModule } from './autenticacao/autenticacao.module';
import { AutenticationInterceptor } from './autenticacao/autentication.interceptor';
import { HomeModule } from './home/home.module';
import { BuscaModule } from './busca/busca.module';
import { FormBuscaModule } from './form-busca/form-busca.module';
import { ErroModule } from './core/erro/erro.module';
import { ErrosInterceptor } from './core/erro/erros.interceptor';

@NgModule({
    declarations: [
        AppComponent
    ],
    providers: [
        {
            provide: HTTP_INTERCEPTORS,
            useClass: AutenticationInterceptor,
            multi: true
        },
        {
            provide: HTTP_INTERCEPTORS,
            useClass: ErrosInterceptor,
            multi: true
        },
    ],
    bootstrap: [AppComponent],
    imports: [
        BrowserModule,
        AppRoutingModule,
        BrowserAnimationsModule,
        SharedModule,
        HttpClientModule,
        ReactiveFormsModule,
        MaterialModule,
        HomeModule,
        AutenticacaoModule,
        BuscaModule,
        FormBuscaModule,
        ErroModule
    ]
})
export class AppModule { }
