import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Observable } from 'rxjs';
import { debounceTime, distinctUntilChanged, map } from 'rxjs/operators';
import { FullRecipe } from '../models/fullRecipe.model';
import { Ingredient } from '../models/ingredient.model';

@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.scss']
})
export class SearchbarComponent implements OnInit {
  @Input() recipes : FullRecipe[]
  @Input() ingredients: Ingredient[]
  recipeNames : String[]
  @Output() selectedRecipe = new EventEmitter<FullRecipe>();
  recipeSelected : FullRecipe;


  // constructor(config: NgbTypeaheadConfig) {
	// 	// customize default values of typeaheads used by this component tree
	// 	config.showHint = true;
	// }

  ngOnInit(): void {
    this.recipeNames = this.recipes.map(recipe => recipe.name);
  }

  // search = (text$: Observable<string>) =>
	// 	text$.pipe(
	// 		debounceTime(200),
	// 		distinctUntilChanged(),
	// 		map((term) =>
	// 			term.length < 1 ? [] : this.recipeNames.filter((v) => v.toLowerCase().includes(term.toLocaleLowerCase())).splice(0, 10),
	// 		),
	// 	);

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
        return recipesByIngredient
          .map((recipe) => recipe.name)
          .splice(0, 10);
      }
    })
  );




  emitSelectedRecipe(){
    const input = document.getElementById('typeahead-config') as HTMLInputElement | null;
    let recipeName = input?.value;
    this.recipeSelected = this.recipes.filter(recipe => recipe.name === recipeName)[0];
    this.selectedRecipe.emit(this.recipeSelected);
  }
}
