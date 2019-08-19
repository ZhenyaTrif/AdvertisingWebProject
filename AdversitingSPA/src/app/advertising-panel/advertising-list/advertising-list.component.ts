import { Component, OnInit } from '@angular/core';
import { AdvertisingService } from 'src/app/shared/advertising.service';
import { Advertising } from '../models/advertising';
import { Router } from '@angular/router';

@Component({
  selector: 'app-advertising-list',
  templateUrl: './advertising-list.component.html',
  styleUrls: ['./advertising-list.component.css']
})
export class AdvertisingListComponent implements OnInit {

  constructor(private service: AdvertisingService, private router: Router) { }

  ngOnInit() {
    this.service.updateList();
  }

}
