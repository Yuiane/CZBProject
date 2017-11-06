import { Component, ChangeDetectorRef } from '@angular/core';
import { NavController, NavParams, AlertController, Platform, App } from 'ionic-angular';
import { policyService } from './../../providers/policyService';
import { storageService } from './../../providers/storageService';

import { policyDetailPage } from '../policyDetail/policyDetail';


/*
  Generated class for the policyList page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-policyList',
    templateUrl: 'policyList.html'
})
export class policyListPage {
    order: string = 'awaitOffer';
    orderList1: any;
    orderList2: any;
    orderList3: any;
    orderList4: any;
    orderList5: any;
    constructor(public navCtrl: NavController,
        public navParams: NavParams,
        public alertCtrl: AlertController,
        public platform: Platform,
        public policyService: policyService,
        private storageService: storageService,
        private ref: ChangeDetectorRef,
        private appCtrl: App) { }

    initLoad() {
        var agentId = "0";
        var _userInfo = this.storageService.read('userInfo');
        if (_userInfo != null && _userInfo != "") {
            var user = JSON.parse(_userInfo);
            agentId = user.userInfo.id;
        }
        var _stateName = this.storageService.read("order-state-name");
        if (_stateName != null && _stateName != undefined) {
            switch (_stateName) {
                case '"待报价"':
                    this.order = 'awaitOffer';
                    break;
                case '"待支付"':
                    this.order = 'awaitPay';
                    break;
                case '"已生效"':
                    this.order = "alreadyInForce";
                    break;
                case '"已过期"':
                    this.order = "expired";
                    break;
                case '"已拒绝"':
                    this.order = "rejected";
                    break;
                default:
                    this.order = 'awaitOffer';
                    break;
            }
        }
        //agentId = "22";
        this.policyService.policyListByState(agentId, 1).then(data => {
            if (data.code == 100) {
                this.orderList1 = data.data.policyListList;
            }
        });
        this.policyService.policyListByState(agentId, 2).then(data => {
            if (data.code == 100) {
                this.orderList2 = data.data.policyListList;
            }
        });
        this.policyService.policyListByState(agentId, 3).then(data => {
            if (data.code == 100) {
                this.orderList3 = data.data.policyListList;
            }
        });
        this.policyService.policyListByState(agentId, 4).then(data => {
            if (data.code == 100) {
                this.orderList4 = data.data.policyListList;
            }
        });
        this.policyService.policyListByState(agentId, -1).then(data => {
            if (data.code == 100) {
                this.orderList5 = data.data.policyListList;
            }
        });
    }
    ionViewDidLoad() {
        this.initLoad();
    }
    gotoDetail(policyId) {
        this.appCtrl.getRootNav().push(policyDetailPage, { policyId: policyId });
    }
}
