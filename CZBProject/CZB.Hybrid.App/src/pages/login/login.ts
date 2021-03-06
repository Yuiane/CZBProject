﻿import { Component } from '@angular/core';
import { NavController, AlertController, App, Platform, LoadingController } from 'ionic-angular';
import { Http, Response } from '@angular/http';
import { FormBuilder, Validators } from '@angular/forms';
import { StatusBar, Splashscreen } from 'ionic-native';


import { userInfoService } from './../../providers/userInfoService';
import { storageService } from './../../providers/storageService';

import { TabsPage } from '../tabs/tabs';
import { registerPage } from '../register/register';

declare var Wechat: any;

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
    sendTitle = "获取验证码";
    canSend = true;
    constructor(public navCtrl: NavController, public alertCtrl: AlertController, public userInfoService: userInfoService,
        public formBuilder: FormBuilder, public loadingCtrl: LoadingController,
        public storageService: storageService, public appCtrl: App) {

        StatusBar.backgroundColorByHexString('#0058b6');
    }

    loginForm = this.formBuilder.group({
        'phone': [""],// 第一个参数是默认值
        'code': [""]
    });

    onLogin(user, _event) {
        _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
        if (user.phone == "" || user.phone == undefined) {
            let alert = this.alertCtrl.create({
                subTitle: "请输入手机号码",
                buttons: ['我知道了']
            });
            alert.present();
            return;
        }

        if (user.code == "" || user.code == undefined) {
            let alert = this.alertCtrl.create({
                subTitle: "请输入验证码",
                buttons: ['我知道了']
            });
            alert.present();
            return;
        }
        const login_loading = this.loadingCtrl.create({
            spinner: 'crescent',
            content: '登录中...'
        });
        login_loading.present();

        this.userInfoService
            .login(user)
            .then(data => {
                login_loading.dismiss();
                //console.log(data);
                if (data.code == 100) {
                    //登录成功
                    this.storageService.write('userInfo', data.data);
                    this.appCtrl.getRootNav().setRoot(TabsPage);
                } else {
                    let alert = this.alertCtrl.create({
                        subTitle: data.desc,
                        buttons: ['我知道了']
                    });
                    alert.present();
                }
            });
    }

    sendCode(user, _event) {
        if (this.canSend) {

            this.canSend = false;
            _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
            if (user.phone == "" || user.phone == undefined) {
                let alert = this.alertCtrl.create({
                    subTitle: "请输入手机号码",
                    buttons: ['我知道了']
                });
                alert.present();
                this.canSend = true;
                return;
            }
            const loading = this.loadingCtrl.create({
                spinner: 'crescent',
                content: '短信发送中...'
            });
            loading.present();

            this.userInfoService
                .sendMessage(user)
                .then(data => {
                    loading.dismiss();
                    //console.log(data);
                    if (data.code == 100) {
                        let timeCount = 60;
                        var interval = setInterval(() => {
                            timeCount -= 1;
                            this.sendTitle = timeCount + "秒可重发";
                            if (timeCount == 1) {
                                this.sendTitle = "重发验证码";
                                this.canSend = true;
                                clearInterval(interval);
                            }
                        }, 1000);
                        //验证码发送成功
                    } else {
                        let alert = this.alertCtrl.create({
                            subTitle: data.desc,
                            buttons: ['我知道了']
                        });
                        alert.present();
                    }
                });
        }
    }

    wechatLogin(_event) {
        _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
        var _that = this.userInfoService;
        var __that = this;
        Wechat.isInstalled(function (installed) {
            if (installed) {
                let _loading = __that.loadingCtrl.create({
                    spinner: 'crescent',
                    content: '微信登录中...',
                    dismissOnPageChange: true
                });
                _loading.present();
                var scope = "snsapi_userinfo", state = "wechat";
                Wechat.auth(scope, state, function (val) {
                    if (val != null && val != "" && val.state == "wechat") {
                        _that.loginOAuth(val.code).then(valU => {
                            _loading.dismiss();
                            if (valU.code == 100) {
                                //登录成功
                                __that.storageService.write('userInfo', valU.data);
                                __that.appCtrl.getRootNav().setRoot(TabsPage);
                            } else {
                                __that.alertCtrl.create({
                                    subTitle: valU.desc,
                                    buttons: ['我知道了']
                                }).present();
                            }
                        });
                    }
                }, function (reason) {
                    alert("Failed: " + reason);
                });
            } else {
                __that.alertCtrl.create({
                    subTitle: "请先安装微信客户端",
                    buttons: ['我知道了']
                }).present();
            }
        }, function (reason) {
            alert("异常" + (reason));
        });
    }


    onRegister() {
        this.navCtrl.push(registerPage);
    }

}
