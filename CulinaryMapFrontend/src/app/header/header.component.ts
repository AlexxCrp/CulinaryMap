import { Component, Input } from '@angular/core';
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
  recipe : FullRecipe;

  onCheckedValuesChangedButton(values: string[]): void {
    // Do something with the checked values
    this.filters = values;
  }

  onSelectedRecipe(recipe : FullRecipe)
  {
    this.recipe = recipe;
  }

}
