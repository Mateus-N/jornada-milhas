import { UnidadeFederativa } from "./UnidadeFederativa";

export interface FormCadastroValue {
  nome: string,
  cpf: string,
  telefone: string,
  email: string,
  senha: string,
  cidade: string,
  estado: UnidadeFederativa,
}