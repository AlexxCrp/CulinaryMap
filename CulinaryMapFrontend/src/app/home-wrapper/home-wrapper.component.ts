import { Component, Input } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';
import { RecipeService } from '../services/recipe.service';

@Component({
  selector: 'app-home-wrapper',
  templateUrl: './home-wrapper.component.html',
  styleUrls: ['./home-wrapper.component.scss']
})
export class HomeWrapperComponent {
  fullRecipes : FullRecipe[] = null;
  filteredRecipe: FullRecipe[];

  constructor(public recipeService: RecipeService) {

  }

  ngOnInit(): void {
    this.recipeService.getRecipes().subscribe((result : FullRecipe[]) =>
      this.fullRecipes = result);
  }

}
