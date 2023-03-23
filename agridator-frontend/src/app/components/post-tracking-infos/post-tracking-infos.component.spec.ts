import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PostTrackingInfosComponent } from './post-tracking-infos.component';

describe('PostTrackingInfosComponent', () => {
  let component: PostTrackingInfosComponent;
  let fixture: ComponentFixture<PostTrackingInfosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PostTrackingInfosComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PostTrackingInfosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
