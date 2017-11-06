import { Component, ViewChild } from '@angular/core';
import { NavController, NavParams, AlertController, Tabs } from 'ionic-angular';
import { HomePage } from '../home/home';
import { AboutPage } from '../about/about';
import { ContactPage } from '../contact/contact';
import { loginPage } from '../login/login';
import { policyListPage } from '../policyList/policyList';

@Component({
    templateUrl: 'tabs.html'
})
export class TabsPage {
    // this tells the tabs component which Pages
    // should be each tab's root Page
    tab1Root: any = HomePage;
    tab2Root: any = policyListPage;
    tab3Root: any = ContactPage;
    @ViewChild('myTabs') tabRef: Tabs;
    indexTab: number = 0; //默认左边第一个菜单
    constructor(public navCtrl: NavController,
        public navParams: NavParams) {
        var _index = this.navParams.get("tab_index");
        if (_index != null && _index != undefined) {
            this.indexTab = _index;
        }
    }
    ionViewDidLoad() {
        //设置选项卡的索引值为2，即最后一个
        this.tabRef.select(this.indexTab);
    }
}
