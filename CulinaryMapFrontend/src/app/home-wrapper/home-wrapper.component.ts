import { Component, Input } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';
import { RecipeService } from '../services/recipe.service';
import { IngredientService } from '../services/ingredient.service';
import { Ingredient } from '../models/ingredient.model';

@Component({
  selector: 'app-home-wrapper',
  templateUrl: './home-wrapper.component.html',
  styleUrls: ['./home-wrapper.component.scss']
})
export class HomeWrapperComponent {
  fullRecipes : FullRecipe[] = null;
  ingredients: Ingredient[] = null;
  filteredRecipe: FullRecipe[];

  constructor(public recipeService: RecipeService, public ingredientService: IngredientService) {

  }

  ngOnInit(): void {
    this.recipeService.getRecipes().subscribe((result : FullRecipe[]) =>
      this.fullRecipes = result);
    this.ingredientService.getIngredients().subscribe((result : Ingredient[]) =>
      this.ingredients = result);
  }

}
