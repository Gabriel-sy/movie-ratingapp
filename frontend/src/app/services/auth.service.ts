import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtResponse } from '../domain/JwtResponse';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private readonly API = "https://localhost:44301/"

  constructor(private http: HttpClient) { }

  registerUser(name: string, email: string, password: string){
    var objectToSend = {
      name: name,
      email: email,
      password: password
    }
    
    return this.http.post(this.API + "api/user/register", objectToSend);
  }

  login(email: string, password: string){
    var objectToSend = {
      email: email,
      password: password
    }
    
    return this.http.post<JwtResponse>(this.API + "api/user/login", objectToSend);
  }
}
