import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styles: []
})
export class NavbarComponent implements OnInit {

  isLogined;

  constructor(private router: Router) { }

  ngOnInit() {
    if(localStorage.getItem('token') != null){
      this.isLogined = false;
    }
    else{
      this.isLogined = true;
    }
  }

  onLogout(){
    localStorage.removeItem('token');
    this.router.navigate(['/user/login']);
  }
}
