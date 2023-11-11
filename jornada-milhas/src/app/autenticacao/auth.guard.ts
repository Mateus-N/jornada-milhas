import { inject } from "@angular/core";
import { Router } from "@angular/router";
import { UserService } from "src/app/autenticacao/services/user.service";

export const authGuard = () => {
  const userService = inject(UserService);
  const router = inject(Router);

  if (userService.estaLogado()) {
    return true;
  }
  router.navigate(['/login']);
  return false;
};