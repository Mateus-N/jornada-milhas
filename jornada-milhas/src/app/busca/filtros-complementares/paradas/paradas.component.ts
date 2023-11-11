import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { OpcaoDeParada } from 'src/app/core/types/OpcaoDeParada';
import { FormBuscaService } from 'src/app/form-busca/services/form-busca.service';

@Component({
  selector: 'app-paradas',
  templateUrl: './paradas.component.html',
  styleUrls: ['./paradas.component.scss']
})
export class ParadasComponent implements OnInit {
  opcaoSelecionada: OpcaoDeParada | null = null;
  conexoesControl: FormControl<number | null>;

  opcoes: OpcaoDeParada[] = [
    {
      display: "Direto",
      value: "0"
    },
    {
      display: "1 conexão",
      value: "1"
    },
    {
      display: "2 conexões",
      value: "2"
    },
    {
      display: "Mais de 2 conexões",
      value: "3"
    },
  ];

  constructor(
    private readonly formBuscaService: FormBuscaService
  ) {
    this.conexoesControl = formBuscaService.obterControle<number>('conexoes');
  }

  ngOnInit(): void {
    this.conexoesControl.valueChanges.subscribe(value => {
      if (value === null) {
        this.opcaoSelecionada = null;
      }
    });
  }

  alternarParada(opcao: OpcaoDeParada, checked: boolean) {
    if (!checked) {
      this.opcaoSelecionada = null;
      this.formBuscaService.formBusca.patchValue({
        conexoes: null
      });
      return;
    }
    this.opcaoSelecionada = opcao;
    this.formBuscaService.formBusca.patchValue({
      conexoes: Number(opcao.value)
    });
  }

  paradaSelecionada(opcao: OpcaoDeParada): boolean {
    return this.opcaoSelecionada === opcao;
  }

  incluirParada(opcao: OpcaoDeParada) {
    if (!this.opcaoSelecionada) {
      return false;
    }
    return this.opcaoSelecionada.value > opcao.value;
  }
}
