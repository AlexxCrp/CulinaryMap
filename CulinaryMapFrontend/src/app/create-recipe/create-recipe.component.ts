import { Component } from '@angular/core';
import { RecipeService } from '../services/recipe.service';
import { NgForm } from '@angular/forms';
import { PostRecipe } from '../models/postRecipe.model';

@Component({
  selector: 'app-create-recipe',
  templateUrl: './create-recipe.component.html',
  styleUrls: ['./create-recipe.component.scss']
})
export class CreateRecipeComponent {
  constructor(private recipeService: RecipeService) {
    this.model = {
      numeInput: '',
      istorieText: '',
      preparareText: '',
      inputStateTip: '',
      inputStateRegiune: '',
      timp: '',
      lat: '0',
      lon: '0'
    };

    this.modelToPost = new PostRecipe('', 0, '0', '0', '', '', '', '');

  }
  model:{
    numeInput: string,
    istorieText: string,
    preparareText: string,
    inputStateTip: string,
    inputStateRegiune: string,
    timp: string,
    lat: string,
    lon: string
  }
  modelToPost: PostRecipe;
  regionId: number;

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

    this.modelToPost.name = recipeForm.value.numeInput;
    this.modelToPost.regionId = this.regionId;
    this.modelToPost.latitude = recipeForm.value.lat;
    this.modelToPost.longitude = recipeForm.value.lon;
    this.modelToPost.prepMode = recipeForm.value.preparareText;
    this.modelToPost.history = recipeForm.value.istorieText;
    this.modelToPost.type = recipeForm.value.inputStateTip;
    this.modelToPost.prepTime = recipeForm.value.timp;


    this.recipeService.postRecipe(this.modelToPost).subscribe(
      response => {
        console.log('Recipe posted successfully:', response);
      });

    recipeForm.reset();
  }
}
