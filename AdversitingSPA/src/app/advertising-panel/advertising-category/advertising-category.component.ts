import { Component, OnInit } from '@angular/core';
import { AdvertisingService } from 'src/app/shared/advertising.service';

@Component({
  selector: 'app-advertising-category',
  templateUrl: './advertising-category.component.html',
  styleUrls: ['./advertising-category.component.css']
})
export class AdvertisingCategoryComponent implements OnInit {

  constructor(private service: AdvertisingService) { }

  ngOnInit() {
  }

}
