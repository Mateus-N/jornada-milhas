import { Router } from '@angular/router';
import { Component } from '@angular/core';
import { FormularioService } from 'src/app/core/services/formulario.service';
import { CadastroService } from '../services/cadastro.service';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent {

  pageTitle = 'Crie sua conta';
  textButton = 'CADASTRAR';

  constructor(
    private readonly formularioService: FormularioService,
    private readonly cadastroService: CadastroService,
    private readonly router: Router
  ) {}

  cadastrar() {
    const formCadastro = this.formularioService.getFormUser();

    if (this.formularioService.isValid()) {
      this.cadastroService.cadastrar(formCadastro).subscribe({
        next: () => {
          this.router.navigateByUrl('/login');
        },
        error: err => console.error('erro no cadastro', err)
      });
    }
  }
}
