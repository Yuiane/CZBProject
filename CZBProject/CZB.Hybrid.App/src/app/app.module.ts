import { NgModule, ErrorHandler } from '@angular/core';
import { IonicApp, IonicModule, IonicErrorHandler } from 'ionic-angular';
import { MyApp } from './app.component';
import { AboutPage } from '../pages/about/about';
import { ContactPage } from '../pages/contact/contact';
import { HomePage } from '../pages/home/home';
import { TabsPage } from '../pages/tabs/tabs';
import { loginPage } from '../pages/login/login';
import { policyListPage } from '../pages/policyList/policyList';
import { myTeamPage } from '../pages/myTeam/myTeam';
import { profitPage } from '../pages/profit/profit';
import { policyDetailPage } from '../pages/policyDetail/policyDetail';
import { addPolicyPage } from '../pages/addPolicy/addPolicy';
import { registerPage } from '../pages/register/register';
import { personPage } from '../pages/person/person';
import { salesRulesPage } from '../pages/salesRules/salesRules';



import { userInfoService } from '../providers/userInfoService';
import { httpService } from '../providers/httpService';
import { storageService } from '../providers/storageService';
import { insureService } from '../providers/insureService';
import { policyService } from '../providers/policyService';

import { DatePicker } from '@ionic-native/date-picker';
import { DatePipe } from '@angular/common';

@NgModule({
    declarations: [
        MyApp,
        AboutPage,
        ContactPage,
        HomePage,
        TabsPage,
        loginPage,
        policyListPage,
        myTeamPage,
        profitPage,
        policyDetailPage,
        addPolicyPage,
        personPage,
        salesRulesPage
    ],
    imports: [
        IonicModule.forRoot(MyApp)
    ],
    bootstrap: [IonicApp],
    entryComponents: [
        MyApp,
        AboutPage,
        ContactPage,
        HomePage,
        TabsPage,
        loginPage,
        policyListPage,
        myTeamPage,
        profitPage,
        policyDetailPage,
        addPolicyPage,
        personPage,
        salesRulesPage
    ],
    providers: [{ provide: ErrorHandler, useClass: IonicErrorHandler }, userInfoService, httpService, storageService, insureService, policyService, DatePicker, DatePipe]
})
export class AppModule { }
