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
///////// Using Absolute Paths ///////
var SomeAbsoluteComponent = (function () {
    function SomeAbsoluteComponent() {
        this.class = 'absolute';
        this.type = 'Absolute template & style URLs';
        this.path = 'app/path.component.html';
    }
    SomeAbsoluteComponent = __decorate([
        core_1.Component({
            selector: 'absolute-path',
            templateUrl: 'app/some.component.html',
            styleUrls: ['app/some.component.css']
        }), 
        __metadata('design:paramtypes', [])
    ], SomeAbsoluteComponent);
    return SomeAbsoluteComponent;
}());
exports.SomeAbsoluteComponent = SomeAbsoluteComponent;
///////// Using Relative Paths ///////
var SomeRelativeComponent = (function () {
    function SomeRelativeComponent() {
        this.class = 'relative';
        this.type = 'Component-relative template & style URLs';
        this.path = 'path.component.html';
    }
    SomeRelativeComponent = __decorate([
        core_1.Component({
            moduleId: module.id,
            selector: 'relative-path',
            templateUrl: 'some.component.html',
            styleUrls: ['some.component.css']
        }), 
        __metadata('design:paramtypes', [])
    ], SomeRelativeComponent);
    return SomeRelativeComponent;
}());
exports.SomeRelativeComponent = SomeRelativeComponent;
/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/ 
//# sourceMappingURL=some.component.js.map