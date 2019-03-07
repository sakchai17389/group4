import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { CallApiProvider } from '../../providers/call-api/call-api';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  product: any;
  constructor(public navCtrl: NavController, public callapi: CallApiProvider) {

  }
  ionViewDidEnter() {
    this.get();
}
get() {
  this.callapi.Getallproduct().subscribe(data => {
    this.product = data;
    console.log(this.product);
  });
}
/*goinfoPage(id: string) {
  this.navCtrl.push('InfoPage', { id: id });
}*/
}