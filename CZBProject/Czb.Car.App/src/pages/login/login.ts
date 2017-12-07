import { Component } from '@angular/core';
import { NavController, NavParams, App } from 'ionic-angular';
import { StorageService } from './../../providers/StorageService';

import { tabsPage } from '../tabs/tabs';

/*
  Generated class for the login page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-login',
    templateUrl: 'login.html'
})
export class loginPage {

    constructor(public navCtrl: NavController,
        private navParams: NavParams,
        private storageService: StorageService,
        private appCtrl: App) { }

    ionViewDidLoad() {

    }

    goback() {
        this.navCtrl.pop();
    }

    login() {
        var userInfo = this.storageService.write('userInfo', "aa");
        this.appCtrl.getRootNav().setRoot(tabsPage);
    }

}
