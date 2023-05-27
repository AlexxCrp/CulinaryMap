export class User{
  constructor(private _token: string, private _role: string /*private _tokenExpDate: Date*/) {}

  get token(){
    return this._token;
  }
  get role(){
    return this._role;
  }

}
