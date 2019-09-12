import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../shared/user.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styles: []
})
export class NavbarComponent implements OnInit {

  visibility: boolean;
  adminVis: boolean;

  constructor(private router: Router, private service: UserService) { }

  ngOnInit() {
    if (localStorage.getItem('token') != null) {
      this.visibility = true;
      this.adminVis = this.checkOnAdminRole();
    } else {
      this.visibility = false;
      this.adminVis = false;
    }
  }

  checkOnAdminRole(): boolean {
    let isMatch = false;
    let payLoad = JSON.parse(window.atob(localStorage.getItem('token').split('.')[1]));
    let userRole = payLoad.role;
    if (userRole === 'Admin') {
      isMatch = true;
      return isMatch;
    }
    return isMatch;
  }

  onLogout() {
    localStorage.removeItem('token');
    window.location.href = 'user/login';
  }

  createAd() {
    this.router.navigate(['/ad-create']);
  }
}
