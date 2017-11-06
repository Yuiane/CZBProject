import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { httpService } from "./httpService";

/*
  Generated class for the policyService provider.

  See https://angular.io/docs/ts/latest/guide/dependency-injection.html
  for more info on providers and Angular 2 DI.
*/
@Injectable()
export class policyService {

    public API_HTTP = "http://api.51czb.com/";
    private API_URL = this.API_HTTP + "api/account";
    constructor(
        private http: Http,
        private httpService: httpService) { }

    //获取保单
    policyListByState(agentId: string, state: number) {
        var postJson = { agentId: agentId, state: state };
        var url = this.API_URL + "/PolicyListByState";
        return this.httpService.httpPostNoAuth(url, postJson);
    }
    ///获取保单详情
    policyDetailByPolicyId(policyId: string) {
        var postJson = { policyId: policyId };
        var url = this.API_URL + "/PolicyDetailByPolicyId";
        return this.httpService.httpPostNoAuth(url, postJson);
    }

    uploadImage(imgData: string) {
        var postJson = { base64Str: imgData };
        var url = this.API_URL + "/UploadImage";
        return this.httpService.httpPostNoAuth(url, postJson);
    }

    addPolicy(addPolicyData: any) {
        var postJson = addPolicyData;
        var url = this.API_URL + "/AddPolicy";
        return this.httpService.httpPostNoAuth(url, postJson);
    }

}
