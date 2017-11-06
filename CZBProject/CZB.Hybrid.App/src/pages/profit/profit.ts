import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { userInfoService } from './../../providers/userInfoService';
import { storageService } from './../../providers/storageService';
import { DatePicker } from '@ionic-native/date-picker';
import { DatePipe } from '@angular/common';

/*
  Generated class for the profit page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-profit',
    templateUrl: 'profit.html'
})
export class profitPage {
    public startTime = '2017-01-01';
    public endTime = '';
    public agentId: string;
    public list = [];
    public outMoney = '0';
    public inMoney = '0';

    constructor(public navCtrl: NavController, public navParams: NavParams, public userInfoService: userInfoService,
        public storageService: storageService, public datePicker: DatePicker, public datePipe: DatePipe) {
        var _userInfo = this.storageService.read('userInfo');
        if (_userInfo != null && _userInfo != "") {
            var __userInfo = JSON.parse(_userInfo).userInfo;
            this.agentId = __userInfo.id;
        }
        this.endTime = this.datePipe.transform(new Date(), 'yyyy-MM-dd');
    }
    ionViewDidLoad() {
        var _profit = this.storageService.read('profit');
        if (_profit != null && _profit != '') {
            var val = JSON.parse(_profit);
            this.list = val.data.list;
            this.outMoney = val.data.outMoney;
            this.inMoney = val.data.inMoney;
        }
        this.initLoadInfo();
    }

    initLoadInfo() {
        this.userInfoService.recordList(this.agentId, this.startTime, this.endTime).then((val) => {
            this.list = val.data.list;
            this.outMoney = val.data.outMoney;
            this.inMoney = val.data.inMoney;
            this.storageService.write('profit', val);
        })
    }

    gotoSelectTime(_index: number) {
        this.datePicker.show({
            date: new Date(),
            mode: 'date',
            androidTheme: this.datePicker.ANDROID_THEMES.THEME_DEVICE_DEFAULT_LIGHT,
            okText: '确定',
            cancelText: '取消'
        }).then
            (
            date => {
                if (_index == 1) {
                    this.startTime = this.datePipe.transform(date, 'yyyy-MM-dd');
                } else {
                    this.endTime = this.datePipe.transform(date, 'yyyy-MM-dd');
                }
                this.initLoadInfo();
            },
            err => { console.log('Error occurred while getting date: ', err) }
            );
    }

}
