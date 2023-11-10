import { TokenService } from './../services/token.service';
import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AutenticationInterceptor implements HttpInterceptor {

  constructor(
    private readonly tokenService: TokenService
  ) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    if (request.url.includes('/perfil') && this.tokenService.possuiToken()) {
      const token = this.tokenService.getToken()
      request = request.clone({
        setHeaders: {
          'Authorization': `Bearer ${token}`
        }
      })
    }

    return next.handle(request);
  }
}