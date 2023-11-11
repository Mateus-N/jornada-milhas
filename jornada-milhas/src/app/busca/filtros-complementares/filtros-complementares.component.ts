import { Component, EventEmitter, Output } from '@angular/core';
import { PassagensService } from '../services/passagens.service';
import { FormBuscaService } from 'src/app/form-busca/services/form-busca.service';

@Component({
  selector: 'app-filtros-complementares',
  templateUrl: './filtros-complementares.component.html',
  styleUrls: ['./filtros-complementares.component.scss']
})
export class FiltrosComplementaresComponent {
  @Output()
  realizarBusca = new EventEmitter();

  constructor(
    public readonly formBuscaService: FormBuscaService,
    private readonly passagemService: PassagensService
  ) {}

  busca() {
    if (!this.formBuscaService.formEstaValido) {
      this.formBuscaService.formBusca.markAllAsTouched();
      window.scroll({
        top: 0,
        left: 0,
        behavior: 'smooth'
      });
      return;
    }
    this.realizarBusca.emit(this.formBuscaService.obterDadosDeBusca());
  }

  limparFiltros() {
    this.formBuscaService.formBusca.patchValue({
      conexoes: null,
      companhias: null,
      precoMin: this.passagemService.precoMin,
      precoMax: this.passagemService.precoMax
    });
  }
}
