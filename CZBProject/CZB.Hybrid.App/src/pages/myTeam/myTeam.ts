import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { userInfoService } from './../../providers/userInfoService';
import { storageService } from './../../providers/storageService';

/*
  Generated class for the myTeam page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-myTeam',
    templateUrl: 'myTeam.html'
})
export class myTeamPage {
    public agentInfo = {
        id: '',
        picUrl: '',
        name: '',
        mobile: '',
        policyAmout: 0
    };
    public childAgentList = [{
        id: 0,
        picUrl: '',
        name: '',
        mobile: '',
        policyAmout: 0
    }];
    public myParent = {
        id: 0,
        picUrl: '',
        name: '',
        mobile: '',
        policyAmout: 0
    };
    public agentLevel = 1;
    public agentLevelName = "";
    public agentId: string;
    constructor(public navCtrl: NavController, public navParams: NavParams, public userInfoService: userInfoService,
        public storageService: storageService) {
        var _userInfo = this.storageService.read('userInfo');
        if (_userInfo != null && _userInfo != "") {
            var __userInfo = JSON.parse(_userInfo).userInfo;
            this.agentId = __userInfo.id;
        }
    }

    ionViewDidLoad() {
        var _myTeam = this.storageService.read('myTeam');
        if (_myTeam != null && _myTeam != "") {
            var val = JSON.parse(_myTeam);
            this.agentInfo = val.data.agentInfo;
            this.myParent = val.data.parentAgentInfo;
            this.childAgentList = val.data.childAgentList;
            this.agentLevel = val.data.agentLevel;
            if (this.agentLevel == 1) {
                this.agentLevelName = "一级代理商";
            } else if (this.agentLevel == 2) {
                this.agentLevelName = "二级代理商";
            } else if (this.agentLevel == 3) {
                this.agentLevelName = "三级代理商";
            }
        }
        this.initLoadInfo();
    }

    initLoadInfo() {
        this.userInfoService.myTeam(this.agentId).then((val) => {
            this.storageService.write('myTeam', val);
            this.agentInfo = val.data.agentInfo;
            this.myParent = val.data.parentAgentInfo;
            this.childAgentList = val.data.childAgentList;
            this.agentLevel = val.data.agentLevel;
            if (this.agentLevel == 1) {
                this.agentLevelName = "一级代理商";
            } else if (this.agentLevel == 2) {
                this.agentLevelName = "二级代理商";
            } else if (this.agentLevel == 3) {
                this.agentLevelName = "三级代理商";
            }
        });
    }

}
