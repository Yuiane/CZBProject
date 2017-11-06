import { Component, ViewChild } from '@angular/core';
import { NavController, NavParams, App, AlertController } from 'ionic-angular';
import { loginPage } from '../login/login';
import { BarcodeScanner } from '@ionic-native/barcode-scanner';
import { userInfoService } from './../../providers/userInfoService';

/*
  Generated class for the register page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-register',
    templateUrl: 'register.html'
})
export class registerPage {
    @ViewChild('focusInputFirst') inputFirst;
    @ViewChild('focusInputSecond') inputSecond;
    @ViewChild('focusInputThird') inputThird;
    @ViewChild('focusInputFourth') inputFourth;

    public first = "";
    public sendTitle: string;
    public canSend: boolean;
    public phone: string;
    public code: string;
    public name: string;
    public number: string;
    public second = "";
    public third = "";
    public fourth = "";

    constructor(public navCtrl: NavController, public navParams: NavParams, public alertCtrl: AlertController, public userInfoService: userInfoService,
        public appCtrl: App, private barcodeScanner: BarcodeScanner) { }

    gologinPage() {
        this.appCtrl.getRootNav().setRoot(loginPage);
    }

    changeInput(_event: any) {
        _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
        if (_event.target.value != "") {
            this.inputSecond.setFocus();
        }
    }

    changeInput2(_event: any) {
        _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
        if (_event.target.value != "") {
            this.inputThird.setFocus();
        }
    }

    changeInput3(_event: any) {
        _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
        if (_event.target.value != "") {
            this.inputFourth.setFocus();
        }
    }

    onlogin() {

        if (this.first == "" || this.second == "" || this.third == "" || this.fourth == "") {
            let alert = this.alertCtrl.create({
                subTitle: "请输入推荐码或使用扫一扫重新扫码",
                buttons: ['我知道了']
            });
            alert.present();
            return;
        }


        if (this.name == "" || this.name == undefined) {
            let alert = this.alertCtrl.create({
                subTitle: "请输入真实姓名",
                buttons: ['我知道了']
            });
            alert.present();
            return;
        }

        if (this.number == "" || this.number == undefined) {
            let alert = this.alertCtrl.create({
                subTitle: "请输入身份证号",
                buttons: ['我知道了']
            });
            alert.present();
            return;
        }

        if (this.phone == "" || this.phone == undefined) {
            let alert = this.alertCtrl.create({
                subTitle: "请输入手机号码",
                buttons: ['我知道了']
            });
            alert.present();
            return;
        }

        if (this.code == "" || this.code == undefined) {
            let alert = this.alertCtrl.create({
                subTitle: "请输入验证码",
                buttons: ['我知道了']
            });
            alert.present();
            return;
        }
        var _zcode = this.first + this.second + this.third + this.fourth;
        this.userInfoService.registerAgent({ name: this.name, number: this.number, phone: this.phone, code: this.code, zcode: _zcode })
            .then(val => {
                if (val.code == 100) {
                    var alertResult = this.alertCtrl.create({
                        subTitle: "注册成功",
                        buttons: ['我知道了']
                    });
                    alertResult.present();
                } else {
                    var alertResult = this.alertCtrl.create({
                        subTitle: val.desc,
                        buttons: ['我知道了']
                    });
                    alertResult.present();
                }
            });
    }

    onScan() {
        var options = {
            showTorchButton: false,
            prompt: '将代理商二维码放在扫描区域内',
            resultDisplayDuration: 0,
            disableAnimations: false
        };

        this.barcodeScanner.scan(options).then((barcodeData) => {
            if (barcodeData.cancelled == false) {
                var _v = barcodeData.text;
                if (_v.length == 4) {
                    this.first = _v.substr(0, 1);
                    this.second = _v.substr(1, 1);
                    this.third = _v.substr(2, 1);
                    this.fourth = _v.substr(3, 1);
                }
            }
        }, (err) => {
            // An error occurred
            //alert("error:" + err);
        });
    }


    sendCode(_event) {

        if (this.canSend) {
            console.log(this.phone);
            this.canSend = false;
            _event.preventDefault();//该方法将通知 Web 浏览器不要执行与事件关联的默认动作
            if (this.phone == "" || this.phone == undefined) {
                let alert = this.alertCtrl.create({
                    subTitle: "请输入手机号码",
                    buttons: ['我知道了']
                });
                alert.present();
                this.canSend = true;
                return;
            }

            this.userInfoService
                .sendMessage({ phone: this.phone })
                .then(data => {
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
}
