import { Companhia } from "./Companhia"
import { Orcamento } from "./Orcamento"
import { UnidadeFederativa } from "./UnidadeFederativa"

export interface Passagem {
  tipo: string,
  precoIda: number,
  precoVolta: number,
  taxaEmbarque: number,
  conexoes: number,
  tempoVoo: number,
  origem: UnidadeFederativa,
  destino: UnidadeFederativa,
  companhia: Companhia,
  dataIda: Date,
  dataVolta: Date | null,
  total: number,
  orcamento: Orcamento[]
}