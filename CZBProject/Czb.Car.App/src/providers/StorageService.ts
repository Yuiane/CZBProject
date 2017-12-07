import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

/*
  Generated class for the StorageService provider.

  See https://angular.io/docs/ts/latest/guide/dependency-injection.html
  for more info on providers and Angular 2 DI.
*/
@Injectable()
export class StorageService {

    constructor(public http: Http) {

    }
    write(key: string, value: any) {
        if (value) {
            value = JSON.stringify(value);
        }
        localStorage.setItem(key, value);
    }
    read(key: string) {
        let value: string = localStorage.getItem(key);

        if (value && value != "undefined" && value != "null") {
            return value;
        }
        return null;
    }

    clear() {
        localStorage.clear();
    }

}
