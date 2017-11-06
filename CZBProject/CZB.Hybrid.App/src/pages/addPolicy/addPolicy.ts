import { Component } from '@angular/core';
import { NavController, NavParams, AlertController, ActionSheetController, App } from 'ionic-angular';
import { Camera, Transfer, FileUploadOptions } from 'ionic-native';

import { insureService } from './../../providers/insureService';
import { policyService } from './../../providers/policyService';
import { storageService } from './../../providers/storageService';

import { HomePage } from '../home/home';
/*
  Generated class for the addPolicy page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-addPolicy',
    templateUrl: 'addPolicy.html'
})
export class addPolicyPage {
    public event = {
        agentId: '',
        cityCode: '',
        timeStarts: '2017-01-01',
        timeEnd: '2018-01-01',
        customerName: '',
        customerPhone: '',
        codeType: 'geren',
        codeTypeValue: '',
        textarea: '',
        city: '苏州',
        notifications: '',
        _1_image_path: '',
        _2_image_path: '',
        insureListSelectedString: ''
    };
    danXuan: string = "身份证";
    danXuanTitle: string = "请输入身份证";
    insureList: any;
    insuranceList: any; //险种类型
    public image = {
        _1_image_show: 'assets/images/tianj@2x.png',//行驶证
        _2_image_show: 'assets/images/tianj@2x.png',//行驶证
    };
    constructor(public navCtrl: NavController,
        public navParams: NavParams,
        public alertCtrl: AlertController,
        public actionSheetCtrl: ActionSheetController,
        public insureService: insureService,
        private app: App,
        private policyService: policyService,
        private storageService: storageService) {
        var _userInfo = this.storageService.read('userInfo');
        if (_userInfo != null && _userInfo != "") {
            var __userInfo = JSON.parse(_userInfo).userInfo;
            this.event.agentId = __userInfo.id;
            this.event.cityCode = __userInfo.cityCode;
        }
        this.event.timeStarts = this.formatDate(new Date().getTime(), 0); // 当前时间
        this.event.timeEnd = this.formatDate(Date.parse(this.event.timeStarts), 1);
        this.insureService.InsureList().then((val) => {
            this.insureList = val.data;
            this.event.notifications = this.insureList[0].InsureCode; //默认选中保险公司
            this.insuranceList = this.insureList[0].InsuranceList;
        });
    }

    gotoOk() {
        this.event.timeEnd = this.formatDate(Date.parse(this.event.timeStarts), 1); // 当前时间
    }

    formatDate(time: any, jianDay: number) {
        // 格式化日期，获取今天的日期
        const Dates = new Date(time);
        const year: number = Dates.getFullYear() + 1;
        const month: any = (Dates.getMonth() + 1) < 10 ? '0' + (Dates.getMonth() + 1) : (Dates.getMonth() + 1);
        const day: any = (Dates.getDate() > jianDay ? Dates.getDate() - jianDay : Dates.getDate()) < 10 ? '0' + (Dates.getDate() > jianDay ? Dates.getDate() - jianDay : Dates.getDate()) : (Dates.getDate() > jianDay ? Dates.getDate() - jianDay : Dates.getDate());
        return year + '-' + month + '-' + day;
    }


    notificationSelect(insureCode) {
        for (var _index in this.insureList) {
            if (this.insureList[_index].InsureCode == insureCode) {
                this.insuranceList = this.insureList[_index].InsuranceList;
            }
        }
    }

    radioSelect(val) {
        this.event.codeType = val;
        if (val == "geren") {
            this.danXuan = "身份证";
            this.danXuanTitle = "请输入身份证";
        } else {
            this.danXuan = "组织机构代码";
            this.danXuanTitle = "请输入组织机构代码";
        }
    }

    clickButton(_insuranceTypeId: string, _selected: number) {
        if (_selected != 2) {
            _selected = _selected == 0 ? 1 : 0;
            for (var _index in this.insuranceList) {
                if (this.insuranceList[_index].InsuranceTypeId == _insuranceTypeId) {
                    if (this.insuranceList[_index].InsurancrMoney == "1") {
                        let clickButton_index = _index;
                        let alert = this.alertCtrl.create();
                        alert.setTitle('选择险种保额');
                        alert.addInput({
                            type: 'radio',
                            label: '50万',
                            value: '50万',
                            checked: true
                        });
                        alert.addInput({
                            type: 'radio',
                            label: '100万',
                            value: '100万'
                        });
                        alert.addInput({
                            type: 'radio',
                            label: '150万',
                            value: '150万'
                        });
                        alert.addInput({
                            type: 'radio',
                            label: '200万',
                            value: '200万'
                        });
                        alert.addInput({
                            type: 'radio',
                            label: '300万',
                            value: '300万'
                        });
                        alert.addInput({
                            type: 'radio',
                            label: '500万',
                            value: '500万'
                        });
                        alert.addInput({
                            type: 'radio',
                            label: '600万',
                            value: '600万'
                        });
                        alert.addInput({
                            type: 'radio',
                            label: '800万',
                            value: '800万'
                        });
                        alert.addInput({
                            type: 'radio',
                            label: '1000万',
                            value: '1000万'
                        });
                        alert.addButton({
                            text: '取消',
                            handler: data => {
                                var _value = this.insuranceList[clickButton_index].InsuranceName;
                                if (_value.indexOf(':') >= 0) {
                                    this.insuranceList[clickButton_index].InsuranceName = (_value.substring(0, _value.indexOf(':')));
                                }
                                this.insuranceList[clickButton_index].Selected = 0;
                            }
                        });

                        alert.addButton({
                            text: '确定',
                            handler: data => {
                                var _value = this.insuranceList[clickButton_index].InsuranceName;
                                if (_value.indexOf(':') <= 0) {
                                    this.insuranceList[clickButton_index].InsuranceName = _value + ":" + data;
                                } else {
                                    this.insuranceList[clickButton_index].InsuranceName = (_value.substring(0, _value.indexOf(':'))) + ":" + data;
                                }
                                this.insuranceList[clickButton_index].Selected = 1;
                            }
                        });
                        alert.present();
                    } else {
                        this.insuranceList[_index].Selected = _selected;
                    }
                }
            }
        }
    }

    gotoTakeOrSelectPhone(num: number) {
        var options = {
            quality: 50,
            destinationType: Camera.DestinationType.DATA_URL,
            encodingType: Camera.EncodingType.JPEG,
            mediaType: Camera.MediaType.PICTURE,
            sourceType: Camera.PictureSourceType.PHOTOLIBRARY,//拍照时，此参数必须有，否则拍照之后报错，照片不能保存
            correctOrientation: true
        }
        /**
         * imageData就是照片的路径，关于这个imageData还有一些细微的用法，可以参考官方的文档。
         */
        Camera.getPicture(options).then((imageData) => {
            if (imageData != null && imageData != "") {
                if (num == 1) {
                    this.image._1_image_show = "data:image/jpeg;base64," + imageData;
                    this.policyService.uploadImage(imageData).then((val) => {
                        this.event._1_image_path = this.policyService.API_HTTP + val.desc;
                    });
                } else {
                    this.image._2_image_show = "data:image/jpeg;base64," + imageData;
                    this.policyService.uploadImage(imageData).then((val) => {
                        this.event._2_image_path = this.policyService.API_HTTP + val.desc;
                    });
                }
            }
            /*  this.zone.run(() => this.image = base64Image);*/
        }, (err) => {
            // Handle error，出错后，在此打印出错的信息。
            //alert(err.toString());
        });
    }

    submitForm() {
        this.event.insureListSelectedString = ',';
        for (var _index in this.insuranceList) {
            if (this.insuranceList[_index].Selected != "0") {
                this.event.insureListSelectedString += this.insuranceList[_index].InsuranceName + ',';
            }
        }
        this.policyService.addPolicy(this.event).then((val) => {
            if (val.code == "100") {
                let alert = this.alertCtrl.create({
                    message: '新增成功，请等待报价!',
                    buttons: [
                        {
                            text: '我知道了',
                            handler: () => {
                                this.navCtrl.push(HomePage);
                            }
                        }
                    ]
                });
                alert.present();
            } else {
                let alert = this.alertCtrl.create({
                    message: '报价失败!' + val.desc,
                    buttons: [
                        {
                            text: '我知道了',
                            handler: () => {
                            }
                        }
                    ]
                });
                alert.present();
            }
        });
        console.log(this.event);
    }

}
