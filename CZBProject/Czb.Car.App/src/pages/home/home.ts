import 'rxjs';
import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { selectCityPage } from '../selectCity/selectCity';
import { secondHandCarPage } from '../secondHandCar/secondHandCar';
import { financeLeasePage } from '../financeLease/financeLease';
import { deferredWarrantyPage } from '../deferredWarranty/deferredWarranty';
import { emergencyRescuePage } from '../emergencyRescue/emergencyRescue';

import { CommonService } from './../../providers/CommonService';
import { StorageService } from './../../providers/StorageService';

import { Geolocation } from '@ionic-native/geolocation';

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
    public postion = '定位中...';
    constructor(private navCtrl: NavController,
        private navParams: NavParams,
        private geolocation: Geolocation,
        private commonService: CommonService,
        private storageService: StorageService) { }

    //进入页面是触发事件
    ionViewDidEnter() {
        this.initLoadPostion();
    }
    //定位当前位置信息
    initLoadPostion() {
        var _postion = this.storageService.read('postion');
        if (_postion != null && _postion != "") {
            var __postion = JSON.parse(_postion);
            this.postion = __postion.value;
        } else {
            this.geolocation.getCurrentPosition().then((resp) => {
                this.commonService.SendRegeo(resp.coords.longitude, resp.coords.latitude).then(val => {
                    if (val.data.infocode == "10000") {
                        this.postion = val.data.regeocode.addressComponent.city + "•";
                        this.postion += val.data.regeocode.addressComponent.district;
                    } else {
                        this.postion = "...";
                    }
                });
            }).catch((error) => {
                this.postion = "..";
            });
        }


    }

    //二手车页面
    gotoSecondHandCar() {
        this.navCtrl.push(secondHandCarPage);
    }
    //融资租赁
    gotoFinanceLease() {
        this.navCtrl.push(financeLeasePage);
    }
    //延保服务
    gotoDeferredWarranty() {
        this.navCtrl.push(deferredWarrantyPage);
    }
    //应急救援
    gotoEmergencyRescue() {
        this.navCtrl.push(emergencyRescuePage);
    }
    //选择定位城市信息
    gotoSelectCity() {
        this.navCtrl.push(selectCityPage);
    }

}
