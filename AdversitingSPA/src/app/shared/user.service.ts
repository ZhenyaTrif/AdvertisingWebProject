import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient, HttpHeaders } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class UserService {

  readonly BaseURL = 'http://localhost:53285/api'

  constructor(private fb:FormBuilder, private httpClient: HttpClient) { }

  formModel=this.fb.group({
    UserName:['', Validators.required],
    Email:['', Validators.email],
    FullName:[''],
    Passwords: this.fb.group({
      Password:['', [Validators.required, Validators.minLength(6)]],
      ConfirmPassword:['', Validators.required]
    },{ validator: this.comparePasswords})
  })

  comparePasswords(fb: FormGroup){
    let confirmPasswordCtrl = fb.get('ConfirmPassword');
    if(confirmPasswordCtrl.errors == null || 'passwordMismatch' in confirmPasswordCtrl.errors){
      if(fb.get('Password').value != confirmPasswordCtrl.value){
        confirmPasswordCtrl.setErrors({passwordMismatch: true});
      }
      else{
        confirmPasswordCtrl.setErrors(null);
      }
    }
  }

  register(){
    let body ={
      UserName: this.formModel.value.UserName,
      Email: this.formModel.value.Email,
      FullName: this.formModel.value.FullName,
      Password: this.formModel.value.Passwords.Password
    }
    return this.httpClient.post(this.BaseURL+'/ApplicationUser/Register', body);
  }

  login(formData){
    return this.httpClient.post(this.BaseURL+'/ApplicationUser/Login', formData);
  }

  getUserProfile(){
    return this.httpClient.get(this.BaseURL + '/UserProfile');
  }

  roleMatch(allowedRoles): boolean {
    var isMatch = false;
    var payLoad =JSON.parse(window.atob(localStorage.getItem('token').split('.')[1]));
    var userRole = payLoad.role;
    allowedRoles.forEach(element => {
      if(userRole == element){
        isMatch = true;
        return false;
      }
    });
    return isMatch;
  }
}
