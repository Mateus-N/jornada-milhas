import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DepoimentoService } from './services/depoimento.service';
import { PromocaoService } from './services/promocao.service';
import { Promocao } from './services/Promocao';
import { Depoimento } from './types/Depoimento';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  promocoes!: Promocao[];
  depoimentos!: Depoimento[];

  constructor(
    private servicoPromocao: PromocaoService,
    private servicoDepoimento: DepoimentoService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.servicoPromocao.listar()
      .subscribe(
        resposta => this.promocoes = resposta
      );
    
    this.servicoDepoimento.listar()
      .subscribe(
        resposta => this.depoimentos = resposta
      );
  }

  navegarParaBusca() {
    this.router.navigate(['busca']);
  }
}
