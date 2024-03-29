import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';

@Component({
  selector: 'app-recipe-scrollspy',
  templateUrl: './recipe-scrollspy.component.html',
  styleUrls: ['./recipe-scrollspy.component.scss']
})
export class RecipeScrollspyComponent implements OnChanges {
  @Input() recipe: FullRecipe;
  ingredientsList: string;

  ngOnChanges(changes: SimpleChanges) {
    if (changes['recipe'] && !changes['recipe'].firstChange) {
      this.updateRecipeData();
    }
  }

  private updateRecipeData() {
    if (this.recipe) {
      document.querySelector('#name p').innerHTML = this.recipe.name;
      document.querySelector('#region p').innerHTML = this.recipe.region;
      document.querySelector('#preptype p').innerHTML = this.recipe.type;
      document.querySelector('#prepmode p').innerHTML = this.recipe.prepMode.replace(/\n|\r/g, '<br>');

      this.ingredientsList = this.recipe.ingredients.reduce((accumulator, currentValue) => {
        return accumulator + `<li>${currentValue.quantity} ${currentValue.ingredientName}</li>`;
      }, "");

      document.querySelector('#ingredients p').innerHTML = `
        <ul>
          ${this.ingredientsList}
        </ul>
      `;
    }
  }

  scrollToElement(elementId: string) {
    const element = document.getElementById(elementId);
    if (element) {
      element.scrollIntoView({ behavior: 'smooth' });
    }
  }
}
