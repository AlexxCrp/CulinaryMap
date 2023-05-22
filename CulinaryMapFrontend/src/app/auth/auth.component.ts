import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.scss']
})
export class AuthComponent {
  isLoginMode = true;

  constructor(private authService: AuthService, private router: Router ){}

  onSwitchMode(){
    this.isLoginMode = !this.isLoginMode;
  }

  onSubmit(form: NgForm){
    if(!form.valid){
      return;
    }
    const email = form.value.email;
    const password = form.value.password;


    if(this.isLoginMode){
      this.authService.login(email, password).subscribe(
        resData =>{
        console.log(resData.token);
        this.router.navigate(['/home'])
        }
      );
    }
    else{
      this.authService.register(email, password).subscribe(
        resData =>{
        console.log(resData.token);
        this.router.navigate(['/home'])
        }
      );
    }


    form.reset();
  }
}
