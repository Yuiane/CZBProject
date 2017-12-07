import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { HttpService } from "./HttpService";

/*
  Generated class for the CommonService provider.

  See https://angular.io/docs/ts/latest/guide/dependency-injection.html
  for more info on providers and Angular 2 DI.
*/
@Injectable()
export class CommonService {
    private API_HTTP = "http://api.51czb.com/";
    private API_URL = this.API_HTTP + "api/account";
    constructor(private http: Http, private httpService: HttpService) {

    }
    //获取定位信息
    SendRegeo(longitude: number, latitude: number) {
        var postJson = { longitude: longitude, latitude: latitude };
        var url = this.API_URL + "/SendRegeo";
        return this.httpService.httpPostNoAuth(url, postJson);
    }
    //发送验证码
    sendMessage(user) {
        var url = this.API_URL + '/SendPhoneMessage';
        return this.httpService.httpPostNoAuth(url, user);
    }

}
