import { Component } from '@angular/core';
import { NavController, NavParams, Slides, App } from 'ionic-angular';
import { EditCarInfoPage } from '../EditCarInfo/EditCarInfo';

/*
  Generated class for the MyGarage page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-MyGarage',
    templateUrl: 'MyGarage.html'
})
export class MyGaragePage {

    public mycarNumber: number = 1;
    constructor(public navCtrl: NavController, public navParams: NavParams, private appCtrl: App) { }


    ionViewDidLoad() {
        console.log('ionViewDidLoad MyGaragePage');
    }

    gotoUpdate() {
        this.appCtrl.getRootNav().push(EditCarInfoPage);
    }
}
