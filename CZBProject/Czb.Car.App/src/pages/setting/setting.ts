import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { StorageService } from './../../providers/StorageService';

import { tabsPage } from '../tabs/tabs';

/*
  Generated class for the setting page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-setting',
    templateUrl: 'setting.html'
})
export class settingPage {

    constructor(public navCtrl: NavController,
        public navParams: NavParams,
        private storageService: StorageService) { }

    ionViewDidLoad() {
        console.log('ionViewDidLoad settingPage');
    }

    onExit() {
        this.storageService.clear();
        this.navCtrl.push(tabsPage);
    }

}
