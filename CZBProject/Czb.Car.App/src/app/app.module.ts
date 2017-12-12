import { NgModule, ErrorHandler } from '@angular/core';
import { IonicApp, IonicModule, IonicErrorHandler } from 'ionic-angular';
import { MyApp } from './app.component';
import { Page1 } from '../pages/page1/page1';
import { Page2 } from '../pages/page2/page2';
import { homePage } from '../pages/home/home';
import { tabsPage } from '../pages/tabs/tabs';
import { selectCityPage } from '../pages/selectCity/selectCity';
import { secondHandCarPage } from '../pages/secondHandCar/secondHandCar';
import { financeLeasePage } from '../pages/financeLease/financeLease';
import { deferredWarrantyPage } from '../pages/deferredWarranty/deferredWarranty';
import { emergencyRescuePage } from '../pages/emergencyRescue/emergencyRescue';
import { storeListPage } from '../pages/storeList/storeList';
import { storeDetailPage } from '../pages/storeDetail/storeDetail';
import { personalCenterPage } from '../pages/personalCenter/personalCenter';
import { loginPage } from '../pages/login/login';
import { signPage } from '../pages/sign/sign';
import { settingPage } from '../pages/setting/setting';
import { couponPage } from '../pages/coupon/coupon';
import { MyGaragePage } from '../pages/MyGarage/MyGarage';

import { HttpService } from '../providers/HttpService';
import { StorageService } from '../providers/StorageService';
import { CommonService } from '../providers/CommonService';

import { Geolocation } from '@ionic-native/geolocation';
import { JPushService } from 'ionic2-jpush/dist';






@NgModule({
    declarations: [
        MyApp,
        Page1,
        Page2,
        homePage,
        tabsPage,
        selectCityPage,
        secondHandCarPage,
        financeLeasePage,
        deferredWarrantyPage,
        emergencyRescuePage,
        storeListPage,
        storeDetailPage,
        personalCenterPage,
        loginPage,
        signPage,
        settingPage,
        couponPage,
        MyGaragePage,
    ],
    imports: [
        IonicModule.forRoot(MyApp, {
            backButtonText:'返回',
        })
    ],
    bootstrap: [IonicApp],
    entryComponents: [
        MyApp,
        Page1,
        Page2,
        homePage,
        tabsPage,
        selectCityPage,
        secondHandCarPage,
        financeLeasePage,
        deferredWarrantyPage,
        emergencyRescuePage,
        storeListPage,
        storeDetailPage,
        personalCenterPage,
        loginPage,
        signPage,
        settingPage,
        couponPage,
        MyGaragePage,
    ],
    providers: [{ provide: ErrorHandler, useClass: IonicErrorHandler }, Geolocation, JPushService, HttpService, StorageService, CommonService]
})
export class AppModule { }
