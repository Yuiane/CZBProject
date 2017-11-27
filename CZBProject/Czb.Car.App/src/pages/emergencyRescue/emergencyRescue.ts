import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';

/*
  Generated class for the emergencyRescue page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-emergencyRescue',
    templateUrl: 'emergencyRescue.html'
})
export class emergencyRescuePage {

    constructor(public navCtrl: NavController, public navParams: NavParams) { }

    ionViewDidLoad() {
        // console.log('ionViewDidLoad emergencyRescuePage');
    }

    call(phone) {
        window.open('tel:' + phone);
    }
}
