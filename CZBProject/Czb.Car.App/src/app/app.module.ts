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


import { HttpService } from '../providers/HttpService';
import { StorageService } from '../providers/StorageService';
import { CommonService } from '../providers/CommonService';

import { Geolocation } from '@ionic-native/geolocation';

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
        emergencyRescuePage
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
        emergencyRescuePage
    ],
    providers: [{ provide: ErrorHandler, useClass: IonicErrorHandler }, Geolocation, HttpService, StorageService, CommonService]
})
export class AppModule { }
