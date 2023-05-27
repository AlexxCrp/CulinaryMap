import { AfterViewInit, Component, Input, OnInit, ViewChild } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';
import { MapComponent } from '../map/map.component';
import { Ingredient } from '../models/ingredient.model';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.scss']
})
export class MainPageComponent implements AfterViewInit{
  @Input() fullRecipes : FullRecipe[];
  @Input() ingredients: Ingredient[];
  filters: string[];
  recipeFromSearchbar: FullRecipe;
  filteredRecipes: FullRecipe[]

  regionFilters: string[] = [];
  typeFilters: string[] = [];

  @ViewChild(MapComponent, {static : false}) mapComponent: MapComponent;

  ngAfterViewInit(): void {
    // Call the updateMarkers method after the view has been initialized
      setTimeout(() => {
        this.mapComponent.filteredRecipes = this.filteredRecipes;

        this.mapComponent.updateMarkers(this.filteredRecipes);
      }, 5);
  }

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
    if(this.filters.length > 1){
      this.filteredRecipes = this.fullRecipes.filter(recipe => (this.regionFilters.includes(recipe.region) && this.typeFilters.includes(recipe.type))
                                                              || (this.regionFilters.includes(recipe.region) && this.typeFilters.length === 0)
                                                              || (this.regionFilters.length === 0 && this.typeFilters.includes(recipe.type)));
    }
    //there are no filters selected, only the flag is present in the filter list
    if(this.filters.length === 1){
      this.filteredRecipes = this.fullRecipes;
    }
    this.mapComponent.updateMarkers(this.filteredRecipes);
  }

  onSelectedRecipe(recipe : FullRecipe)
  {
    this.mapComponent.updateMarkersTargeted(recipe);
  }
}
