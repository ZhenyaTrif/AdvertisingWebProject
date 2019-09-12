import { Component, OnInit } from '@angular/core';
import { AdvertisingService } from 'src/app/shared/advertising.service';
import { Advertising } from 'src/app/advertising-panel/models/advertising';

@Component({
  selector: 'app-user-ads',
  templateUrl: './user-ads.component.html',
  styleUrls: ['./user-ads.component.css']
})
export class UserAdsComponent implements OnInit {

  constructor(public service: AdvertisingService) { }

  ngOnInit() {
    this.service.getUsersAds();
  }

  deleteAdvertising(ad: Advertising) {
    this.service.deleteAd(ad.id).subscribe(data => {
      this.service.getUsersAds();
    });
  }
}
