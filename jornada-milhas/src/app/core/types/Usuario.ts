import { UnidadeFederativa } from "./UnidadeFederativa";

export interface Usuario {
  nome: string,
  nascimento: string,
  cpf: string,
  telefone: string,
  email: string,
  senha: string,
  cidade: string,
  estado: UnidadeFederativa
}