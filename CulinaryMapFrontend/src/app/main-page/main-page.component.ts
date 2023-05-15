import { Component, Input, ViewChild } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';
import { MapComponent } from '../map/map.component';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.scss']
})
export class MainPageComponent {
  @Input() fullRecipes : FullRecipe[]
  filters: string[];
  recipeFromSearchbar: FullRecipe;
  filteredRecipes: FullRecipe[]

  regionFilters: string[] = [];
  typeFilters: string[] = [];

  @ViewChild(MapComponent) mapComponent: MapComponent;


  onCheckedValuesChangedButton(values: string[]): void {
    // Do something with the checked values
    this.filters = values;
    if(values[values.length-1] === 'Regiune')
    {
      this.regionFilters = [];
      for (let i = 0; i < values.length-1; i++) {
        this.regionFilters.push(values[i]);
      }
    }
    else if(values[values.length-1] === 'Tip')
    {
      this.typeFilters = [];
      for (let i = 0; i < values.length-1; i++) {
        this.typeFilters.push(values[i]);
      }
    }
    this.filteredRecipes = this.fullRecipes.filter(recipe => (this.regionFilters.includes(recipe.region) && this.typeFilters.includes(recipe.type))
                                                              || (this.regionFilters.includes(recipe.region) && this.typeFilters.length === 0)
                                                              || (this.regionFilters.length === 0 && this.typeFilters.includes(recipe.type)));
    this.mapComponent.updateMarkers(this.filteredRecipes);
  }

  onSelectedRecipe(recipe : FullRecipe)
  {
    this.mapComponent.updateMarkersTargeted(recipe);
  }
}
