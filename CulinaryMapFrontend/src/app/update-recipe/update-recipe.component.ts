import { Component, Input, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Observable, debounceTime, distinctUntilChanged, map } from 'rxjs';
import { FullRecipe } from '../models/fullRecipe.model';
import { RecipeService } from '../services/recipe.service';
import { PostRecipe } from '../models/postRecipe.model';
import { PutRecipe } from '../models/putRecipe.model';

@Component({
  selector: 'app-update-recipe',
  templateUrl: './update-recipe.component.html',
  styleUrls: ['./update-recipe.component.scss']
})
export class UpdateRecipeComponent implements OnInit {
  recipes: FullRecipe[];
  model: any = {}; // Define an empty object to hold the form values
  modelToPut: PutRecipe
  regionId: number
  recipeId: number

  constructor(private recipeService: RecipeService) {
    this.modelToPut = new PutRecipe(0, '', 0, '0', '0', '', '', '', '');
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

  // Method to handle selecting a recipe from the typeahead
  onSelectRecipe(selectedRecipe: string) {
    // Find the selected recipe from the recipes array
    const recipe = this.recipes.find((r) => r.name === selectedRecipe);

    // Populate the form model with the selected recipe's data
    this.model.numeInput = recipe.name;
    this.model.istorieText = recipe.history;
    this.model.preparareText = recipe.prepMode;
    this.model.inputStateRegiune = recipe.region === "Moldova" ? "Moldova&Bucovina" : recipe.region;
    this.model.inputStateTip = recipe.type;
    this.model.lat = recipe.latitude;
    this.model.lon = recipe.longitude;

    this.recipeId = recipe.id;
    // Populate other form fields with corresponding recipe data

    // You can also set other form fields with the recipe's data in a similar manner

    // After setting the form values, you can optionally trigger form validation or other actions
  }

  submitForm(recipeForm: NgForm) {
    console.log(recipeForm.value);
    switch(recipeForm.value.inputStateRegiune){
      case "Transilvania":
        this.regionId = 1;
        break;
      case "Banat":
        this.regionId = 2;
        break;
      case "Crisana":
        this.regionId = 3;
        break;
      case "Muntenia":
        this.regionId = 4;
        break;
      case "Oltenia":
        this.regionId = 5;
        break;
      case "Dobrogea":
        this.regionId = 6;
        break;
      case "Moldova&Bucovina":
        this.regionId = 7;
        break;
      case "Maramures":
        this.regionId = 9;
        break;
    }

    this.modelToPut.id = this.recipeId;
    this.modelToPut.name = recipeForm.value.numeInput;
    this.modelToPut.regionId = this.regionId;
    this.modelToPut.latitude = recipeForm.value.lat;
    this.modelToPut.longitude = recipeForm.value.lon;
    this.modelToPut.prepMode = recipeForm.value.preparareText;
    this.modelToPut.history = recipeForm.value.istorieText;
    this.modelToPut.type = recipeForm.value.inputStateTip;
    this.modelToPut.prepTime = recipeForm.value.timp;


    this.recipeService.putRecipe(this.modelToPut).subscribe(
      response => {
        console.log('Recipe posted successfully:', response);
      });
  }
}
