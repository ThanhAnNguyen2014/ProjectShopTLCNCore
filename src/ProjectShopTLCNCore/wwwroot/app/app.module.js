"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var platform_browser_1 = require('@angular/platform-browser');
var router_1 = require('@angular/router');
var app_component_1 = require('./app.component');
var header_component_1 = require('./Header/header.component');
var footer_component_1 = require('./Footer/footer.component');
var contact_component_1 = require('./contact/contact.component');
//import { SlideComponent } from './Slide/slide.component';
var service_component_1 = require('./service/service.component');
var product_component_1 = require('./product/product.component');
var about_component_1 = require('./about/about.component');
var gallery_component_1 = require('./gallery/gallery.component');
var cart_component_1 = require('./Cart/cart.component');
var categories_component_1 = require('./categories/categories.component');
//import { PreviewComponent } from './Preview/preview.component';
var appRoutes = [
    //{ path: 'product', component: ProductComponent },
    { path: 'contact', component: contact_component_1.ContactComponent },
    { path: 'service', component: service_component_1.ServiceComponent },
    { path: 'about', component: about_component_1.AboutComponent },
    { path: 'gallery', component: gallery_component_1.GalleryComponent },
    { path: 'product', component: product_component_1.ProductComponent },
    { path: 'categories', component: categories_component_1.CategoriesComponent },
];
var AppModule = (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            imports: [
                platform_browser_1.BrowserModule,
                router_1.RouterModule.forRoot(appRoutes)
            ],
            declarations: [
                app_component_1.AppComponent,
                header_component_1.HeaderComponent,
                //SlideComponent,
                product_component_1.ProductComponent,
                //PreviewComponent,
                service_component_1.ServiceComponent,
                categories_component_1.CategoriesComponent,
                about_component_1.AboutComponent,
                contact_component_1.ContactComponent,
                gallery_component_1.GalleryComponent,
                footer_component_1.FooterComponent,
                cart_component_1.CartComponent
            ],
            bootstrap: [app_component_1.AppComponent]
        }), 
        __metadata('design:paramtypes', [])
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/ 
//# sourceMappingURL=app.module.js.map