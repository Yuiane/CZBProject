import { Component } from '@angular/core';
import { Platform } from 'ionic-angular';
import { StatusBar, Splashscreen } from 'ionic-native';

import { TabsPage } from '../pages/tabs/tabs';
import { loginPage } from '../pages/login/login';


@Component({
    templateUrl: 'app.html'
})
export class MyApp {
    rootPage: any = TabsPage;

    constructor(platform: Platform) {
        if (localStorage.getItem("userInfo") == null) {
            this.rootPage = loginPage;
        } else {
            this.rootPage = TabsPage;
        }
        platform.ready().then(() => {
            // Okay, so the platform is ready and our plugins are available.
            // Here you can do any higher level native things you might need.
            StatusBar.styleBlackOpaque();
            StatusBar.overlaysWebView(false);
            StatusBar.backgroundColorByHexString('#387ef5');
            Splashscreen.hide();
        });
    }
}
