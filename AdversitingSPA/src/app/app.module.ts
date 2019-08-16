import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { UserService } from './shared/user.service';
import { LoginComponent } from './user/login/login.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { AuthIntercepter } from './auth/auth.interceptor';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { AdvertisingComponent } from './advertising-panel/advertising/advertising.component';
import { AdvertisingCategoryComponent } from './advertising-panel/advertising-category/advertising-category.component';
import { UserProfileComponent } from './user/user-profile/user-profile.component';
import { AdvertisingListComponent } from './advertising-panel/advertising-list/advertising-list.component';
import { AdvertisingService } from './shared/advertising.service';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    RegistrationComponent,
    LoginComponent,
    NavbarComponent,
    HomeComponent,
    AdminPanelComponent,
    AdvertisingComponent,
    AdvertisingCategoryComponent,
    UserProfileComponent,
    AdvertisingListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [UserService, {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthIntercepter,
    multi: true
  }, AdvertisingService],
  bootstrap: [AppComponent]
})
export class AppModule { }
