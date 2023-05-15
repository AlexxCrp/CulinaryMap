import { Component, Input, OnInit } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';

@Component({
  selector: 'app-recipe-quickview',
  templateUrl: './recipe-quickview.component.html',
  styleUrls: ['./recipe-quickview.component.scss']
})
export class RecipeQuickviewComponent implements OnInit {

  @Input() recipe: FullRecipe


  ngOnInit(): void {
  }
}
