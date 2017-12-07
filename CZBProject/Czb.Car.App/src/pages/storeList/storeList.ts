import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';

import { storeDetailPage } from '../storeDetail/storeDetail'
import { selectCityPage } from '../selectCity/selectCity';

import { StorageService } from './../../providers/StorageService';

/*
  Generated class for the storeList page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-storeList',
    templateUrl: 'storeList.html'
})
export class storeListPage {
    postion: '定位中...';
    constructor(public navCtrl: NavController, public navParams: NavParams, private storageService: StorageService) {
    }

    initLoad() {
        var _postion = this.storageService.read('postion');
        if (_postion != null && _postion != "") {
            var __postion = JSON.parse(_postion);
            this.postion = __postion.value;
        }
    }

    ionViewDidEnter() {
        this.initLoad();
    }

    gotoStoreDetail(storeId: any) {
        this.navCtrl.push(storeDetailPage, { storeId: storeId });
    }

    gotoSelectCity() {
        this.navCtrl.push(selectCityPage);
    }
}
