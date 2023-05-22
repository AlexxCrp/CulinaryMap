import { Observable, map, shareReplay, switchMap, take } from "rxjs";
import { RecipeCachingService } from "./recipeCaching.service";
import { FullRecipe } from "../models/fullRecipe.model";
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { AuthService } from "./auth.service";
import { IngredientCachingService } from "./ingredientCaching.service";
import { Ingredient } from "../models/ingredient.model";

@Injectable()
export class IngredientService {
  readonly endpoint = 'https://localhost:44376/api/Ingredients/All';
  readonly endpointById = 'https://localhost:44376/api/Ingredients/ById'
  headers: HttpHeaders = null;


  constructor(private http: HttpClient,
              private usersCacheService: IngredientCachingService,
              private authService: AuthService) {
  }

  getIngredients(): Observable<Ingredient[]> {
    return this.authService.user.pipe(
      take(1),
      switchMap(user => {
        const headers = new HttpHeaders().set('Authorization', `Bearer ${user.token}`);
        let ingredients$ = this.usersCacheService.getValue();

        if (!ingredients$) {
          ingredients$ = this.http.get<Ingredient[]>(this.endpoint, { headers }).pipe(
            map((response: any) => response),
            shareReplay(1)
          );
          this.usersCacheService.setValue(ingredients$);
        }
        return ingredients$;
      })
    );
  }

  // getRecipeById(id: number): Observable<FullRecipe> {
  //   return this.authService.user.pipe(
  //     take(1),
  //     switchMap(user => {
  //       const url = `${this.endpointById}?id=${id}`;
  //       const headers = new HttpHeaders().set('Authorization', `Bearer ${user.token}`);

  //       return this.http.get<FullRecipe>(url, { headers });
  //     })
  //   );
  // }

}
