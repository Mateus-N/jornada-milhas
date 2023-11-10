import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { BuscaModel } from '../types/BuscaModel';
import { Observable, take } from 'rxjs';
import { DadosBusca } from '../types/DadosBusca';
import { Passagem } from '../types/Passagem';
import { Destaques } from '../types/Destaques';

@Injectable({
  providedIn: 'root'
})
export class PassagensService {

  apiUrl: string = environment.apiUrl
  precoMin: number = 0
  precoMax: number = 0

  constructor(
    private readonly http: HttpClient
  ) { }

  getPassagens(search: DadosBusca): Observable<BuscaModel> {
    const params = this.converterParametrosParaString(search)
    const obs = this.http.get<BuscaModel>(`${this.apiUrl}/search?${params}`)
    obs.pipe(take(1)).subscribe(res => {
      this.precoMin = res.precoMin
      this.precoMax = res.precoMax
    })
    return obs
  }

  converterParametrosParaString(busca: DadosBusca) {
    const query = Object.entries(busca)
      .map(([key, value]) => {
        if (!value) {
          return ''
        }
        return `${key}=${value}`
      })
      .join('&')
    return query
  }

  obterPassagensDestaques(passagens: Passagem[]): Destaques | undefined {
    if (!passagens.length) {
      return undefined
    }

    let ordenadoPorTempo = [...passagens].sort(
      (a, b) => a.tempoVoo - b.tempoVoo
    );

    let ordenadoPorPreco = [...passagens].sort((a, b) => a.total - b.total);

    let maisRapida = ordenadoPorTempo[0];
    let maisBarata = ordenadoPorPreco[0];

    let ordenadoPorMedia = [...passagens].sort((a, b) => {
      let pontuacaoA =
        (a.tempoVoo / maisBarata.tempoVoo + a.total / maisBarata.total) / 2;
      let pontuacaoB =
        (b.tempoVoo / maisBarata.total + b.total / maisBarata.total) / 2;
      return pontuacaoA - pontuacaoB;
    });
    let sugerida = ordenadoPorMedia[0];

    return { maisRapida, maisBarata, sugerida };
  }
}
