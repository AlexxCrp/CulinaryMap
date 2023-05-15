import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {
  @Input() recipes : FullRecipe[]
  TypeRegiune : string = 'Regiune';
  TypeTip : string = 'Tip';
  filters : string[];
  @Output() filtersEmitter = new EventEmitter<string[]>();
  @Output() recipeEmitter = new EventEmitter<FullRecipe>();
  recipe : FullRecipe;

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
