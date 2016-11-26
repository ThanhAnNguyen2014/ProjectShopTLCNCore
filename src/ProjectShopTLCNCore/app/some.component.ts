import { Component } from '@angular/core';

///////// Using Absolute Paths ///////

@Component({
  selector: 'absolute-path',
  templateUrl: 'app/some.component.html',
  styleUrls:  ['app/some.component.css']
})
export class SomeAbsoluteComponent {
  class = 'absolute';
  type = 'Absolute template & style URLs';
  path = 'app/path.component.html';
}

///////// Using Relative Paths ///////

@Component({
  moduleId: module.id,
  selector: 'relative-path',
  templateUrl: 'some.component.html',
  styleUrls:  ['some.component.css']
})

export class SomeRelativeComponent {
  class = 'relative';
  type = 'Component-relative template & style URLs';
  path = 'path.component.html';

}


/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/