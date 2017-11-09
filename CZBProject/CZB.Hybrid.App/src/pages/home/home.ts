import { Component } from '@angular/core';
import { NavController, App } from 'ionic-angular';

import { storageService } from './../../providers/storageService';
import { userInfoService } from './../../providers/userInfoService';

import { myTeamPage } from '../myTeam/myTeam';
import { profitPage } from '../profit/profit';
import { policyListPage } from '../policyList/policyList';
import { addPolicyPage } from '../addPolicy/addPolicy';
import { TabsPage } from '../tabs/tabs';

declare var Wechat: any;

@Component({
    selector: 'page-home',
    templateUrl: 'home.html'
})
export class HomePage {
    userInfo: any;
    showMenuList: any;
    orderList: any;
    constructor(public navCtrl: NavController, public storageService: storageService, public userInfoService: userInfoService,
        private appCtrl: App) {
        this.initInfo();
    }
    initInfo() {
        var _userInfo = this.storageService.read('userInfo');
        if (_userInfo != null && _userInfo != "") {
            var user = JSON.parse(_userInfo);
            this.userInfo = user.userInfo;
            this.showMenuList = user.showMenuList;
            this.orderList = user.orderList;
        }
    }
    doRefresh(refresher) {
        setTimeout(() => {
            this.userInfoService
                .RefreshUserInfo({ phone: this.userInfo.phone })
                .then(data => {
                    if (data.code == 100) {
                        //更新用户信息
                        this.storageService.write('userInfo', data.data);
                        this.initInfo();
                    }
                });
            refresher.complete();
        }, 1000);
    }

    goShare() {
        Wechat.share({
            text: "This is just a plain string",
            scene: Wechat.Scene.TIMELINE   // share to Timeline
        }, function () {
            alert("Success");
        }, function (reason) {
            alert("Failed: " + reason);
        });
    }

    gotoMyTeamPage() {
        this.appCtrl.getRootNav().push(myTeamPage);
    }

    gotoProfit() {
        this.appCtrl.getRootNav().push(profitPage);
    }

    onGotoPolicy(name: string) {
        this.storageService.write("order-state-name", name);
        this.appCtrl.getRootNav().setRoot(TabsPage, { tab_index: 1 });
    }

    gotoAddPolicy() {
        this.appCtrl.getRootNav().push(addPolicyPage);
    }
}
