import { FormularioService } from './../../core/services/formulario.service';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { UnidadeFederativa } from 'src/app/core/types/UnidadeFederativa';
import { FormValidations } from '../form-validations';

@Component({
  selector: 'app-form-base',
  templateUrl: './form-base.component.html',
  styleUrls: ['./form-base.component.scss']
})
export class FormBaseComponent implements OnInit {
  @Input()
  perfilComponent: boolean = false;
  @Input()
  pageTitle: string = ''
  @Input()
  textButton: string = ''
  @Output()
  acaoClique: EventEmitter<any> = new EventEmitter<any>()
  @Output()
  logout: EventEmitter<any> = new EventEmitter<any>()
  cadastroForm!: FormGroup
  estadoControl = new FormControl<UnidadeFederativa | null>(null, Validators.required)

  constructor(
    private formBuilder: FormBuilder,
    private formularioService: FormularioService
  ) {}

  ngOnInit(): void {
    this.cadastroForm = this.formBuilder.group({
      nome: [null, Validators.required],
      nascimento: [null, Validators.required],
      cpf: [null, Validators.required],
      cidade: [null, Validators.required],
      email: [null, [Validators.required, Validators.email]],
      senha: [null, [Validators.required, Validators.minLength(3)]],
      genero: ['outro'],
      telefone: [null, Validators.required],
      estado: this.estadoControl,
      confirmarEmail: [null, [Validators.required, Validators.email, FormValidations.equalTo('email')]],
      confirmarSenha: [null, [Validators.required, Validators.minLength(3), FormValidations.equalTo('senha')]],
      aceitarTermos: [null, [Validators.requiredTrue]]
    })

    if (this.perfilComponent) {
      this.cadastroForm.get('aceitarTermos')?.setValidators(null)
    } else {
      this.cadastroForm.get('aceitarTermos')?.setValidators([Validators.requiredTrue])
    }

    this.cadastroForm.get('aceitarTermos')?.updateValueAndValidity()

    this.formularioService.setCadastro(this.cadastroForm)
  }

  executarAcao() {
    this.acaoClique.emit()
  }

  deslogar() {
    this.logout.emit()
  }
}
