import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { environment } from 'src/environments/environment';
import { UserService } from './user.service';
import { AuthResponse } from '../types/AuthResponse';

@Injectable({
  providedIn: 'root'
})
export class AutenticacaoService {

  private apiUrl = environment.apiUrl;

  constructor(
    private http: HttpClient,
    private userService: UserService
  ) { }

  autenticar(email: string, senha: string): Observable<HttpResponse<AuthResponse>> {
    return this.http.post<AuthResponse>(`${this.apiUrl}/auth/login`,
      { email, senha },
      { observe: 'response' }).pipe(
        tap(response => {
          const authToken = response.body?.accessToken || '';
          this.userService.salvarToken(authToken);
        })
      );
  }
}
