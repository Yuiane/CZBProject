import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
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
    canSend: boolean;
    constructor(public navCtrl: NavController, public navParams: NavParams, public formBuilder: FormBuilder) { }

    loginForm = this.formBuilder.group({
        'phone': [""],// 第一个参数是默认值
        'code': [""]
    });


    wechatLogin(_event) {
        _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
        Wechat.isInstalled(function (installed) {
            if (!installed) {
                alert("请先安装微信");
            } else {
                var scope = "snsapi_userinfo", state = "wechat";
                Wechat.auth(scope, state, function (val) {
                    alert(JSON.stringify(val));
                }, function (reason) {
                    alert("Failed: " + reason);
                });
            }
        }, function (reason) {
            alert(JSON.stringify(reason));
        });
    }

}
