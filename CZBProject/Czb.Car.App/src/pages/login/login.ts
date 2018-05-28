import { Component } from '@angular/core';
import { NavController, NavParams, App, AlertController, LoadingController } from 'ionic-angular';
import { Validators, FormBuilder } from '@angular/forms';
import { StorageService } from './../../providers/StorageService';
import { CommonService } from './../../providers/CommonService';
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
        private commonService: CommonService,
        private appCtrl: App,
        private formBuilder: FormBuilder,
        private alertCtrl: AlertController,
        private loadingCtrl: LoadingController) { }
    canSend = true;
    sendTitle = "获取验证码";
    todo = this.formBuilder.group({
        'phone': [''],
        'code': [''],
    });

    goback() {
        this.navCtrl.pop();
    }

    sendCode(_event) {
        _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
        if (this.canSend) {
            this.canSend = false;
            if (this.todo.value.phone == "" || this.todo.value.phone == undefined) {
                this.alertCtrl.create({
                    subTitle: "请输入手机号码",
                    buttons: ['我知道了']
                }).present();
                this.canSend = true;
                return;
            }

            const loading = this.loadingCtrl.create({
                spinner: 'crescent',
                content: '短信发送中...'
            });
            loading.present();

            this.commonService
                .sendMessage({ phone: this.todo.value.phone })
                .then(data => {
                    loading.dismiss();
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
                        this.alertCtrl.create({
                            subTitle: data.desc,
                            buttons: ['我知道了']
                        }).present();
                        this.canSend = true;
                    }
                });
        }
    }

    login(_event) {
        _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
        if (this.todo.value.phone == "" || this.todo.value.phone == undefined) {
            let alert = this.alertCtrl.create({
                subTitle: "请输入手机号码",
                buttons: ['我知道了']
            });
            alert.present();
            return;
        }

        if (this.todo.value.code == "" || this.todo.value.code == undefined) {
            let alert = this.alertCtrl.create({
                subTitle: "请输入验证码",
                buttons: ['我知道了']
            });
            alert.present();
            return;
        }





        var userInfo = this.storageService.write('userInfo', "aa");
        this.appCtrl.getRootNav().setRoot(tabsPage);
    }

}
