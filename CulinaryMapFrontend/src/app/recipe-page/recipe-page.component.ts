import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';
import { ActivatedRoute } from '@angular/router';
import { RecipeService } from '../services/recipe.service';

@Component({
  selector: 'app-recipe-page',
  templateUrl: './recipe-page.component.html',
  styleUrls: ['./recipe-page.component.scss']
})
export class RecipePageComponent implements OnInit {
  recipe : FullRecipe
  imagesToSend: string[];


  constructor(private route: ActivatedRoute, public recipeService: RecipeService) { }

  ngOnInit(): void {
    const id = this.route.snapshot.params['id'];

    this.recipeService.getRecipeById(id).subscribe(
      (recipe: FullRecipe) => {
        this.recipe = recipe;
        console.log(this.recipe);
        this.imagesToSend = this.recipe.images;
      },
      (error) => {
        console.error(error);
      }
    );
  }
}
