import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { MensagemService } from '../services/mensagem.service';

@Injectable()
export class ErrosInterceptor implements HttpInterceptor {

  constructor(
    private readonly mensagemService: MensagemService
  ) {}

  intercept(request: HttpRequest<HttpErrorResponse>, next: HttpHandler): Observable<HttpEvent<HttpErrorResponse>> {
    return next.handle(request).pipe(
      catchError((erro: HttpErrorResponse) => {
        if (erro.error instanceof ErrorEvent){
          this.mensagemService.openSnackBar(`Erro do cliente: ${erro.error.message}`);
          return throwError(() => new Error('Ocorreu um erro'));
        }
        if (erro.status === 404) {
          this.mensagemService.openSnackBar(`Recurso não encontrado`);
          return throwError(() => new Error('Ocorreu um erro'));
        }
        if (erro.status === 500) {
          this.mensagemService.openSnackBar(`Erro interno do servidor`);
          return throwError(() => new Error('Ocorreu um erro'));
        }
        if (erro.status === 401) {
          this.mensagemService.openSnackBar(`Você não tem autorização para acessar esse recurso`);
          return throwError(() => new Error('Ocorreu um erro'));
        }
        this.mensagemService.openSnackBar('Ocorreu um erro desconhecido');
        return throwError(() => new Error('Ocorreu um erro'));
      })
    );
  }
}
