import {inject} from '@angular/core';
import {Router} from '@angular/router';
import {map, tap} from 'rxjs';
import { AuthService } from './auth.service';

export const adminGuard = () => {
    const service = inject(AuthService)
    const router = inject(Router);
    return service.user.pipe(
      map((user) => {
        if(user?.role === 'Admin'){
          console.log("da");
          return true;
        }
        else{
          router.navigateByUrl('/home');
          return false;
        }
      })
    );
}

export const authGuard = () => {
  const service = inject(AuthService)
  const router = inject(Router);
  return service.user.pipe(
    map((user) => {
       if(!!user){
        return true;
       }
       else{
        router.navigateByUrl('/auth');
        return false;
      }
    })
  );
}
