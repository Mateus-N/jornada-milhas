import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { CadastroService } from 'src/app/core/services/cadastro.service';
import { FormularioService } from 'src/app/core/services/formulario.service';
import { TokenService } from 'src/app/core/services/token.service';
import { UserService } from 'src/app/core/services/user.service';
import { Usuario } from 'src/app/core/types/Usuario';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss']
})
export class PerfilComponent implements OnInit {
  pageTitle: string = ''
  textButton = 'ATUALIZAR'

  token: string = ''
  perfil!: Usuario

  form!: FormGroup<any> | null

  constructor(
    private readonly tokenService: TokenService,
    private readonly cadastroService: CadastroService,
    private readonly formularioService: FormularioService,
    private readonly router: Router,
    private readonly userService: UserService
  ) {}

  ngOnInit(): void {
    this.token = this.tokenService.getToken()
    this.cadastroService.buscarCadastro().subscribe(c => {
      this.perfil = c
      this.pageTitle = `Olá ${this.perfil.nome}`
      this.carregarFormulario()
    })
  }

  carregarFormulario() {
    this.form = this.formularioService.getFormGroup()
    this.form?.patchValue({
      nome: this.perfil.nome,
      nascimento: this.perfil.nascimento,
      cpf: this.perfil.cpf,
      telefone: this.perfil.telefone,
      confirmarEmail: this.perfil.email,
      email: this.perfil.email,
      cidade: this.perfil.cidade,
      estado: this.perfil.estado
    })
  }

  atualizar() {
    const dadosAtualizados = this.formularioService.getFormUser()

    this.cadastroService.editarCadastro(dadosAtualizados).subscribe({
      next: () => {
        alert('Cadastro editado com sucesso')
        this.router.navigate(['/'])
      },
      error: err => {
        console.error('Erro ao atualizar!', err)
      }
    })
  }

  deslogar() {
    this.userService.logout()
    this.router.navigate(['/login'])
  }
}
