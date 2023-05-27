import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';
import { Ingredient } from '../models/ingredient.model';
import { AuthService } from '../services/auth.service';
import { switchMap, take } from 'rxjs';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  @Input() recipes : FullRecipe[]
  @Input() ingredients: Ingredient[];
  TypeRegiune : string = 'Regiune';
  TypeTip : string = 'Tip';
  filters : string[];
  @Output() filtersEmitter = new EventEmitter<string[]>();
  @Output() recipeEmitter = new EventEmitter<FullRecipe>();
  recipe : FullRecipe;
  role: string

  constructor(private authService: AuthService){};

  ngOnInit(): void {
    this.authService.user.pipe(
      take(1)
    ).subscribe(user => {
      this.role = user.role;
      console.log(this.role);
    });
  }


  onCheckedValuesChangedButton(values: string[]): void {
    // Do something with the checked values
    this.filters = values;
    this.emitFilterValues();
  }

  onSelectedRecipe(recipe : FullRecipe)
  {
    this.recipe = recipe;
    this.emitRecipe();
  }

  emitFilterValues()
  {
    this.filtersEmitter.emit(this.filters);
  }

  emitRecipe()
  {
    this.recipeEmitter.emit(this.recipe);
  }

}
