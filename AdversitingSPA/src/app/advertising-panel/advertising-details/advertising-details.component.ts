import { Component, OnInit } from '@angular/core';
import { AdvertisingService } from 'src/app/shared/advertising.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-advertising-details',
  templateUrl: './advertising-details.component.html',
  styles: []
})
export class AdvertisingDetailsComponent implements OnInit {

  adDetails;
  id: number;
  private sub: any;

  constructor(private service: AdvertisingService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id']
    });
    this.service.getAdDetails(this.id).subscribe(
      res => {
        this.adDetails = res;
      },
      err => {
        console.log(err);
      }
    )
  }

}
