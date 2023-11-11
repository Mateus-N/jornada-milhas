import { FormCadastroValue } from "src/app/core/types/FormCadastroValue";

export class UsuarioDto {
  nome!: string;
  nascimento!: Date;
  cpf!: string;
  telefone!: string;
  email!: string;
  senha!: string;
  cidade!: string;
  estadoId!: string;

  constructor(value: FormCadastroValue, nascimento: Date) {
    this.nome = value.nome;
    this.nascimento = nascimento;
    this.cpf = value.cpf;
    this.telefone = value.telefone;
    this.email = value.email;
    this.senha = value.senha;
    this.cidade = value.cidade;
    this.estadoId = value.estado.id;
  }
}
