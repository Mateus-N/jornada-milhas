import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { CompanhiasService } from 'src/app/core/services/companhias.service';
import { FormBuscaService } from 'src/app/core/services/form-busca.service';
import { Companhia } from 'src/app/core/types/Companhia';

@Component({
  selector: 'app-companhias',
  templateUrl: './companhias.component.html',
  styleUrls: ['./companhias.component.scss']
})
export class CompanhiasComponent implements OnInit {
  companhias: Companhia[] = []
  selecionadas: Companhia[] = []

  companhiasControl: FormControl

  constructor(
    private readonly companhiasService: CompanhiasService,
    private readonly formBuscaService: FormBuscaService
  ) {
    this.companhiasControl = this.formBuscaService.obterControle<number[] | null>('companhias')
  }

  ngOnInit(): void {
    this.companhiasService.listar().subscribe(
      res => {
        this.companhias = res;
      }
    )
    this.companhiasControl.valueChanges.subscribe(value => {
      if (!value) {
        this.selecionadas = []
      }
    })
  }

  alternarCompanhia(companhia: Companhia, checked: boolean): void {
    if (!checked) {
      this.selecionadas = this.selecionadas.filter(comp => comp != companhia)
    } else {
      this.selecionadas.push(companhia)
    }
    this.formBuscaService.formBusca.patchValue({
      companhias: this.selecionadas.map(comp => comp.id)
    })
  }

  companhiaSelecionada(companhia: Companhia): boolean {
    return this.selecionadas.includes(companhia)
  }
}
