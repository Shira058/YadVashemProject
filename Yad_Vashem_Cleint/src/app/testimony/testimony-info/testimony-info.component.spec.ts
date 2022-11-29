import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestimonyInfoComponent } from './testimony-info.component';

describe('TestimonyComponent', () => {
  let component: TestimonyInfoComponent;
  let fixture: ComponentFixture<TestimonyInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TestimonyInfoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TestimonyInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
