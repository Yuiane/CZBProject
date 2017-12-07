import { Component } from '@angular/core';
import { NavController, NavParams, App } from 'ionic-angular';
import { loginPage } from '../login/login';
import { signPage } from '../sign/sign';
import { settingPage } from '../setting/setting';
import { couponPage } from '../coupon/coupon';
import { StorageService } from './../../providers/StorageService';

/*
  Generated class for the personalCenter page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-personalCenter',
    templateUrl: 'personalCenter.html'
})
export class personalCenterPage {

    constructor(public navCtrl: NavController,
        private navParams: NavParams,
        private storageService: StorageService,
        private appCtrl: App) {
    }

    ionViewDidEnter() {
    }

    gotoSign() {
        //签到页面
        this.appCtrl.getRootNav().push(signPage);
    }

    gotoSetting() {
        //设置页面
        this.appCtrl.getRootNav().push(settingPage);
    }

    gotoCoupon() {
        //卡券页面
        this.appCtrl.getRootNav().push(couponPage);
    }

}
