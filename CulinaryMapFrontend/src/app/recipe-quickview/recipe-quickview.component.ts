import { Component } from '@angular/core';
import { CardRecipe } from '../models/cardRecipe.model';

@Component({
  selector: 'app-recipe-quickview',
  templateUrl: './recipe-quickview.component.html',
  styleUrls: ['./recipe-quickview.component.scss']
})
export class RecipeQuickviewComponent {
  recipe: CardRecipe = {"image": 'https://www.bucovinacazare.ro/wp-content/uploads/2018/07/reteta_de_balmos_ciobanesc_autentic_bucovina.jpg', "name": "Cozonac Ardelenesc", "region": "Transilvania"}


}
