import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BehaviorSubject, Subject, tap } from "rxjs";
import { User } from "../models/user.model";

interface AuthResponseData{
  token: string;
  role: string;
}

@Injectable({providedIn:'root'})

export class AuthService{
  user = new BehaviorSubject<User>(null);

  constructor(private http: HttpClient) {}

  private handleAuth(token: any, role: any){
    const user = new User(token, role);
    this.user.next(user);
    localStorage.setItem('userData', JSON.stringify(user))
  }

  autoLogin(){
    const userData: {
      _token: string;
      _role: string;
    } = JSON.parse(localStorage.getItem('userData'));
    if(!userData){
      return;
    }
    const loadedUser = new User(userData._token, userData._role);

    if(loadedUser.token){
      this.user.next(loadedUser);
    }
  }

  role: string = 'User';

  register(email: string, password: string){
    return this.http.post<AuthResponseData>('https://localhost:44376/api/Identity/Register',
      {
        email: email,
        password: password,
        role: this.role
      }
    ).pipe(tap(resData => {
      this.handleAuth(resData.token, resData.role);
      })
    );
  }

  login(email: string, password: string){
    return this.http.post<AuthResponseData>('https://localhost:44376/api/Identity/Login',
      {
        email: email,
        password: password
      }
    ).pipe(tap(resData => {
      this.handleAuth(resData.token, resData.role);
      })
    );

  }
}
