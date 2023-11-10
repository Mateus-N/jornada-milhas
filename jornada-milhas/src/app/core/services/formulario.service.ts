import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { UsuarioDto } from '../types/UsuarioDto';
import { FormCadastroValue } from '../types/FormCadastroValue';

@Injectable({
  providedIn: 'root'
})
export class FormularioService {
  
  private cadastroForm: FormGroup | null = null

  constructor() { }

  getFormUser(): UsuarioDto {
    const nascimento = new Date(this.cadastroForm?.get('nascimento')?.value)
    const formValue = this.cadastroForm?.getRawValue() as FormCadastroValue
    return new UsuarioDto(formValue, nascimento)
  }

  getFormGroup(): FormGroup | null {
    return this.cadastroForm
  }

  isValid(): boolean | undefined {
    return this.cadastroForm?.valid
  }

  setCadastro(form: FormGroup): void {
    this.cadastroForm = form
  }
}
