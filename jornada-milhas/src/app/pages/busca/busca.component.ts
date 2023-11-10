import { Component, OnInit } from '@angular/core';
import { take } from 'rxjs';
import { FormBuscaService } from 'src/app/core/services/form-busca.service';
import { PassagensService } from 'src/app/core/services/passagens.service';
import { DadosBusca } from 'src/app/core/types/DadosBusca';
import { Destaques } from 'src/app/core/types/Destaques';
import { Passagem } from 'src/app/core/types/Passagem';

@Component({
  selector: 'app-busca',
  templateUrl: './busca.component.html',
  styleUrls: ['./busca.component.scss']
})
export class BuscaComponent implements OnInit {

  passagens: Passagem[] = []
  destaques!: Destaques | undefined

  constructor(
    private readonly passagensService: PassagensService,
    private readonly formBuscaService: FormBuscaService
  ) {}

  ngOnInit(): void {
    const busca = this.formBuscaService.obterDadosDeBusca()
    this.busca(busca)
  }

  busca(dados: DadosBusca) {
    this.passagensService.getPassagens(dados)
      .pipe(take(1))
      .subscribe({
        next: res => {
          this.passagens = res.resultado
          this.destaques = this.passagensService.obterPassagensDestaques(this.passagens)
          this.formBuscaService.formBusca.patchValue({
            precoMin: res.precoMin,
            precoMax: res.precoMax,
          })
        }
      })
  }
}
