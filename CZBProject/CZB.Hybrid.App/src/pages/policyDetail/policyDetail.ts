import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { policyService } from './../../providers/policyService';
import { storageService } from './../../providers/storageService';

/*
  Generated class for the policyDetail page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-policyDetail',
    templateUrl: 'policyDetail.html'
})
export class policyDetailPage {
    public customerName: string;
    public PayUrl: string;
    public carNo: string;
    public carVin: string;
    public endTime: string;
    public insureName: string;
    public policyAmount: string;
    public policyBusiness: string;
    public policyCompulsory: string;
    public startTime: string;
    public userInfo: any;
    public policyTitle: string = "保单详情";
    public insureType: any;
    constructor(private navCtrl: NavController,
        private navParams: NavParams,
        private policyService: policyService,
        private storageService: storageService) {
        var _userInfo = this.storageService.read('userInfo');
        if (_userInfo != null && _userInfo != "") {
            var user = JSON.parse(_userInfo);
            this.userInfo = user.userInfo;
        }
        var policyId = this.navParams.get("policyId");
        if (policyId != null && policyId != undefined) {
            this.policyService
                .policyDetailByPolicyId(policyId)
                .then((data) => {
                    this.customerName = data.data.policyDetailInfo.customerName;
                    this.PayUrl = data.data.policyDetailInfo.PayUrl;
                    this.carNo = data.data.policyDetailInfo.carNo;
                    this.carVin = data.data.policyDetailInfo.carVin;
                    this.endTime = data.data.policyDetailInfo.endTime;
                    this.insureName = data.data.policyDetailInfo.insureName;
                    this.policyAmount = data.data.policyDetailInfo.policyAmount;
                    this.policyBusiness = data.data.policyDetailInfo.policyBusiness;
                    this.policyCompulsory = data.data.policyDetailInfo.policyCompulsory;
                    this.startTime = data.data.policyDetailInfo.startTime;
                    this.policyTitle += " - " + this.customerName;
                    this.insureType = data.data.InsureTypeList;
                });
        };
    }
}
