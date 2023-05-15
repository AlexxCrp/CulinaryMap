import { Component, OnInit } from '@angular/core';
import { FullRecipe } from './models/fullRecipe.model';
import { RecipeService } from './services/recipe.service';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  fullRecipes : FullRecipe[] = null;
  filteredRecipe: FullRecipe[]
  title: any;

  constructor(public recipeService: RecipeService) {

  }

  ngOnInit(): void {
    this.recipeService.getRecipes().subscribe((result : FullRecipe[]) =>
      this.fullRecipes = result);
  }
}
