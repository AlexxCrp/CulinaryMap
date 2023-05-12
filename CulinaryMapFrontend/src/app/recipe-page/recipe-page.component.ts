import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FullRecipe } from '../models/fullRecipe.model';

@Component({
  selector: 'app-recipe-page',
  templateUrl: './recipe-page.component.html',
  styleUrls: ['./recipe-page.component.scss']
})
export class RecipePageComponent implements OnInit {
//   recipe : FullRecipe = {"id": 17,
//   "regionId": 7,
//   "region": "Moldova",
//   "latitude": 0,
//   "longitude": 0,
//   "name": "Balmos",
//   "prepMode": "În primul rând vă spunem că dacă nu aveți de unde lua zer, îl puteți înlocui cu o smântână mai ușoară, cât mai apoasă. Astfel, într-o oală înaltă puneți untul la topit, asezonat cu un pic de sare. Apoi turnați deasupra zerul/smântâna și lăsați la fiert, la foc mic. Când începe să clocotească, turnați mălaiul treptat și cernut – ca pentru mămăligă. Amestecați un pic să nu facă deloc cocoloașe și lăsați la fiert 15 minute. Puneți oul, amestecați. Radeți brânza peste balmoșul care se formează în oală și amestecați temeinic. Când începe să se desprindă de pe oală, mai lăsați 5 minute și dați la o parte de pe foc.\r\nSe servește cu caș fărâmițat deasupra și cu lapte acru din belșug.\r\n",
//   "history": "Una din mâncărurile de bază ale ciobanilor din pitoreasca zonă a Bucovinei, balmoșul este de multe ori confundat cu o banală mămăligă. Da, are la bază tot mălaiul, dar nu se fierbe în apă ci în zer (sau jintuială).",
//   "type": "Fel principal",
//   "prepTime": "75 min",
//   "ingredients": [
//     {
//       "id": 200,
//       "ingredientName": "Malai",
//       "ingredientId": 83,
//       "recipeName": "Balmos",
//       "recipeId": 17,
//       "quantity": "1 kg"
//     },
//     {
//       "id": 201,
//       "ingredientName": "Unt",
//       "ingredientId": 63,
//       "recipeName": "Balmos",
//       "recipeId": 17,
//       "quantity": "350 g"
//     },
//     {
//       "id": 202,
//       "ingredientName": "Smantana",
//       "ingredientId": 33,
//       "recipeName": "Balmos",
//       "recipeId": 17,
//       "quantity": "2 L"
//     },
//     {
//       "id": 203,
//       "ingredientName": "Ou",
//       "ingredientId": 27,
//       "recipeName": "Balmos",
//       "recipeId": 17,
//       "quantity": "1"
//     },
//     {
//       "id": 204,
//       "ingredientName": "Branza de oaie",
//       "ingredientId": 42,
//       "recipeName": "Balmos",
//       "recipeId": 17,
//       "quantity": "600 g"
//     },
//     {
//       "id": 205,
//       "ingredientName": "Cas",
//       "ingredientId": 84,
//       "recipeName": "Balmos",
//       "recipeId": 17,
//       "quantity": "250 g"
//     },
//     {
//       "id": 206,
//       "ingredientName": "Sare",
//       "ingredientId": 17,
//       "recipeName": "Balmos",
//       "recipeId": 17,
//       "quantity": ""
//     }
//   ],
//   "images": [
//     "https://www.bucovinacazare.ro/wp-content/uploads/2018/07/reteta_de_balmos_ciobanesc_autentic_bucovina.jpg",
//     "https://media.dcnews.ro/image/202002/full/balmos-bucovina_73780900.jpg"
//   ]
// }
  recipe : FullRecipe = { "id": 7, "regionId": 1, "region": "Transilvania", "latitude": 0, "longitude": 0, "name": "Cozonac Ardelenesc", "prepMode": "1. Se cerne făina şi se lasă la temperatura camerei 3-4 ore împreună cu celelalte ingrediente. Se separă ouăle iar uleiul se încălzeşte 5-10 minute. Se incalzeste putin laptele şi se amestecă cu 2 linguri de zahăr, cu drojdia şi se lasă la dospit acoperit cu un şervet.\r\n2. În bolul cu făină, se adaugă restul de zahăr, gălbenuşurile frecate cu sarea, zahărul vanilat, coaja de lămâie şi de portocală, drojdia dospită şi albuşurile bătute spumă.\r\n3. Toate ingredientele se amestecă până se obţine o cocă nici prea vârtoasă, nici prea moale. Se adaugă lapte dacă e prea tare şi apoi se frământă 30 de minute adăugându-se uleiul, câte puţin. După ce s-a încorporat tot uleiul, se acoperă şi se lasă la crescut o oră sau chiar mai mult.\r\n4. Între timp, se pregăteşte crema de nucă. Se amestecă nuca măcinată şi coaptă cu zahărul şi cu laptele fierbinte. Se adaugă o esenţă de vanilie şi 2-3 picături de rom, coaja de lămâie şi cacaoa. Crema se lasă la temperatura camerei. Se ung tăvile cu unt din abundenţă. Se împarte coca în două părţi şi se întind. Se umplu cu crema de nucă şi se rulează. Se aranjează în tavă una lângă alta şi se mai lasă 20 de minute la crescut. Se ung cu galbenuş şi se coc la aceeaşi temperatură.\r\n", "history": "NA", "type": "Desert", "prepTime": "120 min", "ingredients": [ { "id": 73, "ingredientName": "Esenta de rom", "ingredientId": 46, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "" }, { "id": 74, "ingredientName": "Esenta de vanilie", "ingredientId": 47, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "" }, { "id": 75, "ingredientName": "Zahar", "ingredientId": 38, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "350 g" }, { "id": 76, "ingredientName": "Lapte cald", "ingredientId": 13, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "600 ml" }, { "id": 77, "ingredientName": "Cacao", "ingredientId": 48, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "10 lingurite" }, { "id": 78, "ingredientName": "Nuca", "ingredientId": 49, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "500 g" }, { "id": 79, "ingredientName": "Coaja de lamaie", "ingredientId": 50, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "" }, { "id": 80, "ingredientName": "Zahar Vanilat", "ingredientId": 39, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "2 pliculete" }, { "id": 81, "ingredientName": "Sare", "ingredientId": 17, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "O lingurita" }, { "id": 82, "ingredientName": "Ulei", "ingredientId": 16, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "8 Linguri" }, { "id": 83, "ingredientName": "Zahar", "ingredientId": 38, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "10 Linguri" }, { "id": 84, "ingredientName": "Drojdie Uscata", "ingredientId": 37, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "50 g" }, { "id": 85, "ingredientName": "Ou", "ingredientId": 27, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "6 bucati" }, { "id": 86, "ingredientName": "Faina", "ingredientId": 9, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "1 kg" }, { "id": 87, "ingredientName": "Galbenus", "ingredientId": 14, "recipeName": "Cozonac Ardelenesc", "recipeId": 7, "quantity": "Un" } ], "images": [ "https://thumbor.unica.ro/unsafe/700x536/smart/filters:format(webp):contrast(8):quality(75)/https://retete.unica.ro/wp-content/uploads/2010/12/cozo-ardelenesc-colaj-e1481047445166.jpg", "https://img.spynews.ro/?u=https%3A%2F%2Fspynews.ro%2Fuploads%2Fmodules%2Fnews%2F0%2F2022%2F4%2F12%2F276417%2Fmedia146105652769019000.jpg&w=700" ] }

  imagesToSend: string[];

  ngOnInit(): void {
    this.imagesToSend = this.recipe.images;
  }
}
