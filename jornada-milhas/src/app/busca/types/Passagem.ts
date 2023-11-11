import { Orcamento } from "src/app/core/types/Orcamento";
import { UnidadeFederativa } from "src/app/core/types/UnidadeFederativa";
import { Companhia } from "./Companhia";

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