// import { Component, Input } from '@angular/core';
// import { FullRecipe } from '../models/fullRecipe.model';

// @Component({
//   selector: 'app-searchbar',
//   templateUrl: './searchbar.component.html',
//   styleUrls: ['./searchbar.component.scss']
// })
// export class SearchbarComponent {
//   @Input() recipes : FullRecipe[]

// }
//*********************************************************************************************** */
// import { Component, Input } from '@angular/core';
// import { FullRecipe } from '../models/fullRecipe.model';
// import { Observable } from 'rxjs';
// import { map } from 'rxjs/operators';

// @Component({
//   selector: 'app-searchbar',
//   templateUrl: './searchbar.component.html',
//   styleUrls: ['./searchbar.component.css']
// })
// export class SearchbarComponent {
//   @Input() recipes : FullRecipe[];
//   searchTerm: string;
//   suggestions: FullRecipe[];

//   search = (text$: Observable<string>) =>
//     text$.pipe(
//       map(term => term.trim() === '' ? []
//         : this.recipes.filter(recipe => recipe.name.toLowerCase().indexOf(term.toLowerCase()) > -1 ||
//                                           recipe.region.toLowerCase().indexOf(term.toLowerCase()) > -1).slice(0, 10))
//     );

//   formatInput = (value: FullRecipe) => value.name + ' - ' + value.region;

//   onSelect(event) {
//     // Do something with the selected suggestion
//     console.log('Selected suggestion:', event.item);
//   }

//   onFocus() {
//     // Show all suggestions when the input field is focused
//     this.suggestions = this.recipes.slice(0, 10);
//   }

//   onBlur() {
//     // Hide the suggestions when the input field loses focus
//     this.suggestions = [];
//   }
// }
//*********************************************************************************************** */

import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Observable } from 'rxjs';
import { NgbTypeaheadConfig, NgbTypeaheadModule } from '@ng-bootstrap/ng-bootstrap';
import { debounceTime, distinctUntilChanged, map } from 'rxjs/operators';
import { FormsModule } from '@angular/forms';
import { FullRecipe } from '../models/fullRecipe.model';

@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.scss']
})
export class SearchbarComponent implements OnInit {
  @Input() recipes : FullRecipe[]
  recipeNames : String[]
  @Output() selectedRecipe = new EventEmitter<FullRecipe>();
  recipeSelected : FullRecipe;


  constructor(config: NgbTypeaheadConfig) {
		// customize default values of typeaheads used by this component tree
		config.showHint = true;
	}

  ngOnInit(): void {
    this.recipeNames = this.recipes.map(recipe => recipe.name);
  }

  search = (text$: Observable<string>) =>
		text$.pipe(
			debounceTime(200),
			distinctUntilChanged(),
			map((term) =>
				term.length < 1 ? [] : this.recipeNames.filter((v) => v.toLowerCase().startsWith(term.toLocaleLowerCase())).splice(0, 10),
			),
		);

  emitSelectedRecipe(){
    const input = document.getElementById('typeahead-config') as HTMLInputElement | null;
    let recipeName = input?.value;
    this.recipeSelected = this.recipes.filter(recipe => recipe.name === recipeName)[0];
    this.selectedRecipe.emit(this.recipeSelected);
  }
}
