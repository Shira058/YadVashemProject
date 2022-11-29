import { Component, EventEmitter, OnInit, Injectable } from '@angular/core';
import { ResourceModel } from 'src/app/models/resource.model';
import { ElementModel } from 'src/app/models/element.model';
import { TestimonyService } from 'src/app/services/testimony.service';
import { MatTabChangeEvent } from '@angular/material/tabs';
import { FlatTreeControl } from '@angular/cdk/tree';
import { MatTreeFlattener, MatTreeFlatDataSource } from '@angular/material/tree';

interface ExampleFlatNode {
  expandable: boolean;
  name: string;
  level: number;
}

@Component({
  selector: 'app-testimony-resource',
  templateUrl: './testimony-resource.component.html',
  styleUrls: ['./testimony-resource.component.css']
})
export class TestimonyResourceComponent implements OnInit {
 
  resource: ResourceModel = {
    title: '',
    url: '',
    urlTitle: '',
    type: 0,
    elements: []
  };

  private _transformer = (node: ElementModel, level: number) => {
    return {
      expandable: !!node.children && node.children.length > 0,
      name: node.title,
      level: level,
    };
  }

  constructor(private _testimonyService: TestimonyService) { }

  ngOnInit(): void {
  }

  tabChanged(event: MatTabChangeEvent) {
    this._testimonyService.getTestimonyResourceByType(event.index).subscribe(data => {
      if (data) {
        this.resource = data;
        this.dataSource.data=data.elements;
      }
      else{
        console.log("No content!!");
      }
    })
  }

  treeControl = new FlatTreeControl<{ expandable: boolean; name: string | undefined; level: number; }, { expandable: boolean; name: string | undefined; level: number; }>(
    node => node.level,
    node => node.expandable,
  );
  
  treeFlattener = new MatTreeFlattener(
    this._transformer, node => node.level, node => node.expandable, node => node.children);

  dataSource = new MatTreeFlatDataSource(this.treeControl, this.treeFlattener);
  
  hasChild = (_: number, node: ExampleFlatNode) => node.expandable;

}
