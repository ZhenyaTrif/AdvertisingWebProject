import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegistrationComponent } from './user/registration/registration.component';
import { UserComponent } from './user/user.component';
import { LoginComponent } from './user/login/login.component';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './auth/auth.guard';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { UserProfileComponent } from './user/user-profile/user-profile.component';
import { Advertising } from './advertising-panel/models/advertising';
import { AdvertisingComponent } from './advertising-panel/advertising/advertising.component';

const routes: Routes = [
  {path:'', redirectTo:'home', pathMatch:'full'},
  {path:'user', component: UserComponent, children:[
    {path:'registration', component: RegistrationComponent},
    {path:'login', component: LoginComponent},
    {path:'profile', component: UserProfileComponent, canActivate: [AuthGuard]}
  ]},
  {path:'home', component: HomeComponent},
  {path:'ad-create', component: AdvertisingComponent},
  {path:'admin-panel', component: AdminPanelComponent, canActivate: [AuthGuard], data: {permittedRoles:['Admin','Moder']}}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
