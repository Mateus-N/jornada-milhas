import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';
import { PassagensService } from '../../services/passagens.service';
import { FormBuscaService } from 'src/app/form-busca/services/form-busca.service';

@Component({
  selector: 'app-precos',
  templateUrl: './precos.component.html',
  styleUrls: ['./precos.component.scss']
})
export class PrecosComponent {
  precoMin: FormControl<number>;
  precoMax: FormControl<number>;

  constructor(
    public readonly passagemService: PassagensService,
    private readonly formBuscaService: FormBuscaService
  ) {
    this.precoMin = this.formBuscaService.obterControle<number>('precoMin');
    this.precoMax = this.formBuscaService.obterControle<number>('precoMax');
  }
}
