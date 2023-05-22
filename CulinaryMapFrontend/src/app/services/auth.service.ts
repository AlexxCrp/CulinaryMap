import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BehaviorSubject, Subject, tap } from "rxjs";
import { User } from "../models/user.model";

interface AuthResponseData{
  token: string;
}

@Injectable({providedIn:'root'})

export class AuthService{
  user = new BehaviorSubject<User>(null);

  constructor(private http: HttpClient) {}
  role: string = 'User';

  register(email: string, password: string){
    return this.http.post<AuthResponseData>('https://localhost:44376/api/Identity/Register',
      {
        email: email,
        password: password,
        role: this.role
      }
    ).pipe(tap(resData => {
      const user = new User(resData.token);
      this.user.next(user);
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
      const user = new User(resData.token);
      this.user.next(user);
      })
    );

  }
}
