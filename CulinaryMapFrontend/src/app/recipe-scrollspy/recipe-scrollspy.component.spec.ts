import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipeScrollspyComponent } from './recipe-scrollspy.component';

describe('RecipeScrollspyComponent', () => {
  let component: RecipeScrollspyComponent;
  let fixture: ComponentFixture<RecipeScrollspyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecipeScrollspyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipeScrollspyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
