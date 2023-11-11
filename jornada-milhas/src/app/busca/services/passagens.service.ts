import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable, take } from 'rxjs';
import { BuscaModel } from '../types/BuscaModel';
import { DadosBusca } from '../types/DadosBusca';
import { Destaques } from '../types/Destaques';
import { Passagem } from '../types/Passagem';

@Injectable({
  providedIn: 'root'
})
export class PassagensService {

  apiUrl: string = environment.apiUrl;
  precoMin = 0;
  precoMax = 0;

  constructor(
    private readonly http: HttpClient
  ) { }

  getPassagens(search: DadosBusca): Observable<BuscaModel> {
    const params = this.converterParametrosParaString(search);
    const obs = this.http.get<BuscaModel>(`${this.apiUrl}/search?${params}`);
    obs.pipe(take(1)).subscribe(res => {
      this.precoMin = res.precoMin;
      this.precoMax = res.precoMax;
    });
    return obs;
  }

  converterParametrosParaString(busca: DadosBusca) {
    const query = Object.entries(busca)
      .map(([key, value]) => {
        if (!value) {
          return '';
        }
        return `${key}=${value}`;
      })
      .join('&');
    return query;
  }

  obterPassagensDestaques(passagens: Passagem[]): Destaques | undefined {
    if (!passagens.length) {
      return undefined;
    }

    const ordenadoPorTempo = [...passagens].sort(
      (a, b) => a.tempoVoo - b.tempoVoo
    );

    const ordenadoPorPreco = [...passagens].sort((a, b) => a.total - b.total);

    const maisRapida = ordenadoPorTempo[0];
    const maisBarata = ordenadoPorPreco[0];

    const ordenadoPorMedia = [...passagens].sort((a, b) => {
      const pontuacaoA =
        (a.tempoVoo / maisBarata.tempoVoo + a.total / maisBarata.total) / 2;
      const pontuacaoB =
        (b.tempoVoo / maisBarata.total + b.total / maisBarata.total) / 2;
      return pontuacaoA - pontuacaoB;
    });
    const sugerida = ordenadoPorMedia[0];

    return { maisRapida, maisBarata, sugerida };
  }
}
