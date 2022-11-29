import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TestimonyInfoComponent } from './testimony/testimony-info/testimony-info.component';
import { TestimonyResourceComponent } from './testimony/testimony-resource/testimony-resource.component';

const routes: Routes = [
  { path: '', component: TestimonyInfoComponent, outlet: "left-zone" },
  { path: '', component: TestimonyResourceComponent, outlet: "right-zone" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
