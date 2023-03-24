import { CommonModule } from '@angular/common';
import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeldkalenderComponent } from './feldkalender.component';

describe('FeldkalenderComponent', () => {
  let component: FeldkalenderComponent;
  let fixture: ComponentFixture<FeldkalenderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FeldkalenderComponent ],
      imports: [
        CommonModule
      ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FeldkalenderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
