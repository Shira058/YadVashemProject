import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestimonyInfoComponent } from './testimony-info/testimony-info.component';
import { TestimonyResourceComponent } from './testimony-resource/testimony-resource.component';
import { AngularMaterialModule } from '../angular-material/angular-material.module';



@NgModule({
  declarations: [
    TestimonyInfoComponent,
    TestimonyResourceComponent
  ],
  imports: [
    CommonModule,
    AngularMaterialModule
  ]
})
export class TestimonyModule { }
