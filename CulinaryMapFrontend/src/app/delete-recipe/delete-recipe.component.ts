import { Component, OnInit } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';
import { RecipeService } from '../services/recipe.service';
import { Observable, debounceTime, distinctUntilChanged, map } from 'rxjs';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-delete-recipe',
  templateUrl: './delete-recipe.component.html',
  styleUrls: ['./delete-recipe.component.scss']
})
export class DeleteRecipeComponent implements OnInit {

  recipes: FullRecipe[];
  recipeToDelete: FullRecipe;
  constructor(private recipeService: RecipeService) {
  }

  ngOnInit(): void {
    this.recipeService.getRecipes().subscribe((result: FullRecipe[]) => {
      this.recipes = result;
    });
  }

  search = (text$: Observable<string>) =>
    text$.pipe(
      debounceTime(200),
      distinctUntilChanged(),
      map((term) => {
        if (term.length < 1) {
          return [];
        } else {
          const recipesByIngredient = this.recipes.filter((recipe) => {
            // Check if recipe name or any ingredient name matches the search term
            const recipeNameMatches = recipe.name.toLowerCase().startsWith(term.toLowerCase());
            const ingredientNameMatches = recipe.ingredients.some(
              (recipeIngredient) =>
                recipeIngredient.ingredientName.toLowerCase().includes(term.toLowerCase())
            );
            return recipeNameMatches || ingredientNameMatches;
          });
          return recipesByIngredient.map((recipe) => recipe.name).splice(0, 10);
        }
      })
    );

  selectRecipe(selectedRecipe: string){
    this.recipeToDelete = this.recipes.find((r) => r.name === selectedRecipe);
  }

  submitForm() {
    this.recipeService.deleteRecipe(this.recipeToDelete.id).subscribe(
      response => {
        console.log('Recipe deleted successfully:', response);
      });
  }
}
