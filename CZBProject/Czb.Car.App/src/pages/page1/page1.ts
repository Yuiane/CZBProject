import { Component } from '@angular/core';

import { NavController, Platform } from 'ionic-angular';



@Component({
    selector: 'page-page1',
    templateUrl: 'page1.html'
})
export class Page1 {

    constructor(private navCtrl: NavController,
        private platform: Platform) {
    }

    onLink(url: string) {
        if (this.platform.is('ios')) {
            window.open('iosamap://');
        } else if (this.platform.is('android')) {
            //window.open('market://details?id=' + data);  

            //this.webIntent.startActivity({
            //    action: 'android.intent.action.VIEW',
            //    url: 'androidamap://navi?sourceApplication=czbcar&amp;poiname=yuiane&amp;lat=36.547901&amp;lon=104.258354&amp;dev=0&amp;style=2',
            //}).then(() => { }, (err) => {

            //});
        } else {

        }
    }
}
