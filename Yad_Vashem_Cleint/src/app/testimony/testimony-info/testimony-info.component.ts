import { Component, OnInit } from '@angular/core';
import { TestimonyDTOModel } from 'src/app/models/testimony-dto.model';
import { TestimonyService } from 'src/app/services/testimony.service';


@Component({
  selector: 'app-testimony',
  templateUrl: './testimony-info.component.html',
  styleUrls: ['./testimony-info.component.css']
})

export class TestimonyInfoComponent implements OnInit {

  testimony: TestimonyDTOModel = { title: '', tag: '', url: '', infoText: ''};
 
  constructor(private _testimonyService: TestimonyService) { }

  ngOnInit(): void {
    this._testimonyService.getTestimonyInfo().subscribe((data: TestimonyDTOModel) => {
      if (data) {
        this.testimony = data;
      }
      else{
        console.log("No Content!!")
      }
    })
  }
}
