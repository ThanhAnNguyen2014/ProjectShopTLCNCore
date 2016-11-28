import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { HeaderComponent } from './Header/header.component';
import { FooterComponent } from './Footer/footer.component';
import { ContactComponent } from './contact/contact.component';
//import { SlideComponent } from './Slide/slide.component';
import { ServiceComponent } from './service/service.component';
import { ProductComponent } from './product/product.component';
import { AboutComponent } from './about/about.component';
import { GalleryComponent } from './gallery/gallery.component';
import { CartComponent } from './Cart/cart.component';
import { CategoriesComponent } from './categories/categories.component';
//import { PreviewComponent } from './Preview/preview.component';



const appRoutes: Routes = [
    //{ path: 'product', component: ProductComponent },
    { path: 'contact', component: ContactComponent },
    { path: 'service', component: ServiceComponent },
    { path: 'about', component: AboutComponent },
    { path: 'gallery', component: GalleryComponent },
    { path: 'product', component: ProductComponent },
    { path: 'categories', component: CategoriesComponent },
    //{ path: 'categories/preview', component: PreviewComponent }

];
@NgModule({
    imports: [
        BrowserModule,
        RouterModule.forRoot(appRoutes)
    ],
    declarations: [
        AppComponent,
        HeaderComponent,
        //SlideComponent,
        ProductComponent,
        //PreviewComponent,
        ServiceComponent,
        CategoriesComponent,
        AboutComponent,
        ContactComponent,
        GalleryComponent,
        FooterComponent,
        CartComponent
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }


/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/