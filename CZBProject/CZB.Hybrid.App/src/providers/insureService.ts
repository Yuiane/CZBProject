import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { httpService } from "./httpService";


/*
  Generated class for the insureService provider.

  See https://angular.io/docs/ts/latest/guide/dependency-injection.html
  for more info on providers and Angular 2 DI.
*/
@Injectable()
export class insureService {

    private API_URL = "http://api.51czb.com/api/account";
    constructor(public http: Http,
        private httpService: httpService) {
    }

    InsureList() {
        var url = this.API_URL + "/InsureList";
        return this.httpService.httpPostNoAuth(url, "");
    }

}
