import { Component, ViewChild } from '@angular/core';
import { NavController, NavParams, App, Tabs } from 'ionic-angular';
import { homePage } from '../home/home';
import { personalCenterPage } from '../personalCenter/personalCenter';
import { loginPage } from '../login/login';
import { storeListPage } from '../storeList/storeList';

import { StorageService } from './../../providers/StorageService';

/*
  Generated class for the tabs page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-tabs',
    templateUrl: 'tabs.html'
})
export class tabsPage {
    tab1Root: any = homePage;
    tab2Root: any = storeListPage;
    tab3Root: any;
    userInfo: any;
    @ViewChild('myTabs') tabRef: Tabs;
    constructor(private navCtrl: NavController,
        private navParams: NavParams,
        private storageService: StorageService,
        private app: App) {
        //this.app.getRootNav().push(loginPage);
    }

    ionViewDidEnter() {

        //进入页面触发的事件
        this.userInfo = this.storageService.read('userInfo');
        if (this.userInfo != null && this.userInfo != "") {
            this.tab3Root = personalCenterPage;
        } else {
            this.tab3Root = "";
        }
    }

    person() {
        if (this.userInfo == null || this.userInfo == "") {
            this.app.getRootNav().push(loginPage);
        }
    }
}
