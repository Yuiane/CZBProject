import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { homePage } from '../home/home';

import { CommonService } from './../../providers/CommonService';
import { StorageService } from './../../providers/StorageService';

import { Geolocation } from '@ionic-native/geolocation';


/*
  Generated class for the selectCity page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-selectCity',
    templateUrl: 'selectCity.html'
})
export class selectCityPage {
    public postion = {
        postionValue: '定位中...'
    };
    constructor(private navCtrl: NavController,
        private navParams: NavParams,
        private geolocation: Geolocation,
        private commonService: CommonService,
        private storageService: StorageService) {
        this.geolocation.getCurrentPosition().then((resp) => {
            this.commonService.SendRegeo(resp.coords.longitude, resp.coords.latitude).then(val => {
                if (val.data.infocode == "10000") {
                    this.postion.postionValue = val.data.regeocode.addressComponent.city + "(";
                    this.postion.postionValue += val.data.regeocode.addressComponent.district + ")";
                } else {
                    this.postion.postionValue = "定位失败,请手动选择";
                }
            });
        }).catch((error) => {
            this.postion.postionValue = "定位失败,请手动选择";
        });
    }

    goSelectCity(index, value) {
        var _select = { code: index, value: value };
        if (_select.code == "00" && (this.postion.postionValue == "定位中..." || this.postion.postionValue == "定位失败,请手动选择")) {

        } else {
            this.storageService.write('postion', _select);
            this.navCtrl.popToRoot(homePage);
        }


    }
}
