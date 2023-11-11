import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Usuario } from '../types/Usuario';
import { UsuarioDto } from '../types/UsuarioDto';

@Injectable({
  providedIn: 'root'
})
export class CadastroService {

  private apiUrl = environment.apiUrl;

  constructor(
    private readonly http: HttpClient
  ) { }

  cadastrar(dto: UsuarioDto): Observable<Usuario> {
    return this.http.post<Usuario>(`${this.apiUrl}/auth/cadastro`, dto);
  }

  buscarCadastro(): Observable<Usuario> {
    return this.http.get<Usuario>(`${this.apiUrl}/auth/perfil`);
  }

  editarCadastro(dto: UsuarioDto): Observable<Usuario> {
    return this.http.put<Usuario>(`${this.apiUrl}/auth/perfil`, dto);
  }
}
