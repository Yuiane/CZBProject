import { Component, ViewChild } from '@angular/core';
import { Nav, Platform } from 'ionic-angular';
import { StatusBar, Splashscreen } from 'ionic-native';

import { tabsPage } from '../pages/tabs/tabs';
import { JPushService } from 'ionic2-jpush/dist'

@Component({
    templateUrl: 'app.html'
})
export class MyApp {
    @ViewChild(Nav) nav: Nav;
    rootPage: any = tabsPage;
    constructor(private platform: Platform,
        private jPushPlugin: JPushService) {
        this.initializeApp();
        this.initJPush();
    }

    initializeApp() {
        this.platform.ready().then(() => {
            // Okay, so the platform is ready and our plugins are available.
            // Here you can do any higher level native things you might need.
            StatusBar.styleLightContent();
            setTimeout(Splashscreen.hide(), 100);
        });
    }

    initJPush() {
        //注册极光设备
        this.jPushPlugin.init();
        document.addEventListener("jpush.openNotification", (event?: any) => {
            console.log("===============打开推送内容===============")
            alert(event.alert)
        }, false);
    } catch(Error) {
        console.log(Error.message);

    }



}
