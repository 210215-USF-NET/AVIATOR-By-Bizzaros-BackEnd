import { Component, OnInit } from '@angular/core';
declare var ParseEngine: any;
declare var FileManagement: any;
@Component({
  selector: 'app-script',
  templateUrl: './script.component.html',
  styleUrls: ['./script.component.css']
})
export class ScriptComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    new FileManagement();

  }

}
