import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PreTrackingInfosComponent } from './pre-tracking-infos.component';

describe('PreTrackingInfosComponent', () => {
  let component: PreTrackingInfosComponent;
  let fixture: ComponentFixture<PreTrackingInfosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PreTrackingInfosComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PreTrackingInfosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
