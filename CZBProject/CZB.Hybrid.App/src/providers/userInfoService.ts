import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { httpService } from './httpService';

/*
  Generated class for the userInfoService provider.

  See https://angular.io/docs/ts/latest/guide/dependency-injection.html
  for more info on providers and Angular 2 DI.
*/
@Injectable()
export class userInfoService {
    API_URL = 'http://api.51czb.com/api/account';
    //constructor(public http: Http) {
    //    console.log('Hello UserInfoService Provider');
    //}
    constructor(
        public http: Http,
        public httpService: httpService) { }

    login(user) {
        var url = this.API_URL + '/UserLogin';
        return this.httpService.httpPostNoAuth(url, user);
    }

    RefreshUserInfo(user) {
        var url = this.API_URL + '/RefreshUserInfo';
        return this.httpService.httpPostNoAuth(url, user);
    }

    sendMessage(user) {
        var url = this.API_URL + '/SendPhoneMessage';
        return this.httpService.httpPostNoAuth(url, user);
    }

    myTeam(_a) {
        var post = { 'agentId': _a };
        var url = this.API_URL + '/MyTeam';
        return this.httpService.httpPostNoAuth(url, post);
    }

    recordList(_a: string, _b: string, _c: string) {
        var post = { 'agentId': _a, 'startTime': _b, 'endTime': _c };
        var url = this.API_URL + '/RecordList';
        return this.httpService.httpPostNoAuth(url, post);
    }

    registerAgent(val) {
        var url = this.API_URL + "/Register";
        return this.httpService.httpPostNoAuth(url, val);
    }

}
