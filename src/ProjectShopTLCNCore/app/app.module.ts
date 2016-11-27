import { NgModule } from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeaderComponent } from './Header/header.component';
import { FooterComponent } from './Footer/footer.component';
import { ContactComponent } from './contact/contact.component';
import { SlideComponent } from './Slide/slide.component';
import { ServiceComponent } from './service/service.component';
import { ProductComponent } from './product/product.component';
import { AboutComponent } from './about/about.component';
import { GalleryComponent } from './gallery/gallery.component';
import { CartComponent } from './Cart/cart.component';
@NgModule({
  imports: [
    BrowserModule
  ],
  declarations: [
    AppComponent,
    HeaderComponent,
    SlideComponent,
    ProductComponent,
    ServiceComponent,
    AboutComponent,
    ContactComponent,
    GalleryComponent,
    FooterComponent,
    CartComponent
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }


/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/