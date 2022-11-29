import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestimonyResourceComponent } from './testimony-resource.component';

describe('TestimonyResourceComponent', () => {
  let component: TestimonyResourceComponent;
  let fixture: ComponentFixture<TestimonyResourceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TestimonyResourceComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TestimonyResourceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
