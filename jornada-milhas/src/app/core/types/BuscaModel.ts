import { Passagem } from "./Passagem";

export interface BuscaModel {
  paginaAtual: number,
  ultimaPagina: number,
  total: number,
  precoMin: number,
  precoMax: number,
  resultado: Passagem[]
}