import { Injectable } from '@angular/core';
import { TokenService } from './token.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  constructor(
    private readonly tokenService: TokenService
  ) { }

  salvarToken(token: string): void {
    this.tokenService.salvarToken(token)
  }

  logout(): void {
    this.tokenService.excluirToken()
  }

  estaLogado(): boolean {
    return this.tokenService.possuiToken()
  }
}
