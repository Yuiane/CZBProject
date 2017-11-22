import { Component } from '@angular/core';
import { NavController, NavParams, AlertController, App, LoadingController } from 'ionic-angular';

import { storageService } from './../../providers/storageService';
import { userInfoService } from './../../providers/userInfoService';

import { loginPage } from '../login/login';
import { salesRulesPage } from '../salesRules/salesRules';

declare var Wechat: any;
/*
  Generated class for the person page.agentNameagentName

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-person',
    templateUrl: 'person.html'
})
export class personPage {
    public event = {
        agentId: '',
        agentName: '',
        levelName: '',
        thirdOpenIdState: ''
    };
    constructor(public navCtrl: NavController, public navParams: NavParams, private alertCtrl: AlertController,
        private storageService: storageService, private appCtrl: App, public userInfoService: userInfoService,
        private loadingCtrl: LoadingController) {
        var _userInfo = this.storageService.read('userInfo');
        if (_userInfo != null && _userInfo != "") {
            var __userInfo = JSON.parse(_userInfo).userInfo;
            this.event.agentId = __userInfo.id;
            this.event.agentName = __userInfo.name;
            this.event.levelName = __userInfo.levelName;
            if (__userInfo.thirdOpenId == null || __userInfo.thirdOpenId == "") {
                this.event.thirdOpenIdState = "点击绑定";
            } else {
                this.event.thirdOpenIdState = "已绑定";
            }
        }
    }


    onExit() {
        let confirm = this.alertCtrl.create({
            title: ' 退出提示 ',
            message: '确定要退出当前代理商,重新登录吗?',
            buttons: [
                {
                    text: '确定',
                    handler: () => {
                        this.storageService.clear();
                        this.navCtrl.pop();
                        this.appCtrl.getRootNav().push(loginPage);
                    }
                },
                {
                    text: '取消',
                    handler: () => {
                    }
                }
            ]
        });
        confirm.present();
    }

    wechatLogin(_event) {
        _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
        if (this.event.thirdOpenIdState != "点击绑定") {
            return;
        }
        let loading = this.loadingCtrl.create({
            spinner: 'crescent',
            content: '微信绑定中...',
            dismissOnPageChange: true,
            duration: 5
        });

        loading.present();

        var _that = this;
        Wechat.isInstalled(function (installed) {
            if (installed) {
                var scope = "snsapi_userinfo", state = "wechat";
                Wechat.auth(scope, state, function (val) {
                    if (val != null && val != "" && val.state == "wechat") {
                        _that.userInfoService.bandWechatLogin(val.code, _that.event.agentId).then(valU => {
                            loading.dismiss();
                            if (valU.code == 100) {
                                _that.event.thirdOpenIdState = "已绑定";
                            } else {
                                alert(valU.desc);
                            }
                        });
                    }
                }, function (reason) {
                    alert("Failed: " + reason);
                });
            } else {
                alert("请先安装微信客户端");
            }
        }, function (reason) {
            alert(JSON.stringify(reason));
        });
    }

    gotoRule() {
        this.appCtrl.getRootNav().push(salesRulesPage);
    }
}
