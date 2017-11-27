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

import { HttpService } from '../providers/HttpService';
import { StorageService } from '../providers/StorageService';
import { CommonService } from '../providers/CommonService';

import { Geolocation } from '@ionic-native/geolocation';
import { JPushService } from 'ionic2-jpush/dist';
import { WebIntent } from '@ionic-native/web-intent';


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
        storeDetailPage
    ],
    imports: [
        IonicModule.forRoot(MyApp)
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
        storeDetailPage
    ],
    providers: [{ provide: ErrorHandler, useClass: IonicErrorHandler }, Geolocation, JPushService, HttpService, StorageService, CommonService, WebIntent]
})
export class AppModule { }
