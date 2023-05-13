import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipeQuickviewComponent } from './recipe-quickview.component';

describe('RecipeQuickviewComponent', () => {
  let component: RecipeQuickviewComponent;
  let fixture: ComponentFixture<RecipeQuickviewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecipeQuickviewComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipeQuickviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
