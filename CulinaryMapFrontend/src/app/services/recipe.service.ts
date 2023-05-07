import { Observable, map, shareReplay } from "rxjs";
import { RecipeCachingService } from "./recipeCaching.service";
import { FullRecipe } from "../models/fullRecipe.model";
import { HttpClient } from '@angular/common/http';
import { Injectable } from "@angular/core";

@Injectable()
export class RecipeService {
  readonly endpoint = 'https://localhost:44376/api/Recipe';

  constructor(private http: HttpClient,
              private usersCacheService: RecipeCachingService) {
  }

  getRecipes(): Observable<FullRecipe[]> {
    let recipes$ = this.usersCacheService.getValue();

    if (!recipes$) {
      recipes$ = this.http.get(this.endpoint).pipe(
        map((response: any) => response),
        shareReplay(1)
      );
      this.usersCacheService.setValue(recipes$);
    }
    return recipes$;
  }
}
