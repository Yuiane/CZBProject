import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { homePage } from '../home/home';
import { selectCityPage } from '../selectCity/selectCity';
/*
  Generated class for the tabs page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
    selector: 'page-tabs',
    templateUrl: 'tabs.html'
})
export class tabsPage {
    tab1Root: any = homePage;
    tab2Root: any = selectCityPage;
    tab3Root: any = homePage;
    constructor(public navCtrl: NavController, public navParams: NavParams) { }
}
