import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';

/*
  Generated class for the storeDetail page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-storeDetail',
    templateUrl: 'storeDetail.html'
})
export class storeDetailPage {
    store = {
        id: 0,
        name: ''
    };
    constructor(public navCtrl: NavController, public navParams: NavParams) { }

    ionViewDidLoad() {
        var storeId = this.navParams.get("storeId");
        if (storeId != null && storeId != undefined) {
            this.store.id = storeId;
        }
    }

}
