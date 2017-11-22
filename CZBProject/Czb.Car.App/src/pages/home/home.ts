import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { selectCityPage } from '../selectCity/selectCity';
import { secondHandCarPage } from '../secondHandCar/secondHandCar';
import { financeLeasePage } from '../financeLease/financeLease';
import { deferredWarrantyPage } from '../deferredWarranty/deferredWarranty';
import { emergencyRescuePage } from '../emergencyRescue/emergencyRescue';

/*
  Generated class for the home page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-home',
    templateUrl: 'home.html'
})
export class homePage {
    chatRoot = selectCityPage;
    constructor(public navCtrl: NavController, public navParams: NavParams) { }

    gotoSecondHandCar() {
        //二手车页面
        this.navCtrl.push(secondHandCarPage);
    }

    gotoFinanceLease() {
        //融资租赁
        this.navCtrl.push(financeLeasePage);
    }

    gotoDeferredWarranty() {
        //延保服务
        this.navCtrl.push(deferredWarrantyPage);
    }

    gotoEmergencyRescue() {
        //应急救援
        this.navCtrl.push(emergencyRescuePage);
    }

}
