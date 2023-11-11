import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TokenService {
  private key = 'token';

  salvarToken(token: string) {
    return localStorage.setItem(this.key, token);
  }

  excluirToken() {
    localStorage.removeItem(this.key);
  }

  getToken(): string {
    return localStorage.getItem(this.key) ?? '';
  }

  possuiToken(): boolean {
    return !!this.getToken();
  }
}
