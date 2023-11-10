export interface DadosBusca {
  somenteIda?: boolean;
  passageirosAdultos?: number;
  passageirosCriancas?: number;
  passageirosBebes?: number;
  tipo?: string;
  origemId?: string;
  destinoId?: string;
  precoMin?: number;
  precoMax?: number;
  conexoes?: number;
  tempoVoo?: number;
  dataIda: string;
  dataVolta?: string;
  companhiasId?: string;
  pagina: number;
  porPagina: number;
}
