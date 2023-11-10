import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Companhia } from '../types/Companhia';

@Injectable({
  providedIn: 'root'
})
export class CompanhiasService {
  private apiUrl: string = environment.apiUrl

  constructor(
    private readonly http: HttpClient
  ) { }

    listar(): Observable<Companhia[]> {
      return this.http.get<Companhia[]>(`${this.apiUrl}/companhias`)
    }
}
