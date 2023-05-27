import { Observable, map, shareReplay, switchMap, take } from "rxjs";
import { RecipeCachingService } from "./recipeCaching.service";
import { FullRecipe } from "../models/fullRecipe.model";
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { AuthService } from "./auth.service";

@Injectable()
export class RecipeService {
  readonly endpoint = 'https://localhost:44376/api/Recipe';
  readonly endpointById = 'https://localhost:44376/api/Recipe/ById'
  headers: HttpHeaders = null;


  constructor(private http: HttpClient,
              private usersCacheService: RecipeCachingService,
              private authService: AuthService) {
  }

  getRecipes(): Observable<FullRecipe[]> {
    return this.authService.user.pipe(
      take(1),
      switchMap(user => {
        const headers = new HttpHeaders().set('Authorization', `Bearer ${user.token}`);
        let recipes$ = this.usersCacheService.getValue();

        if (!recipes$) {
          recipes$ = this.http.get<FullRecipe[]>(this.endpoint, { headers }).pipe(
            map((response: any) => response),
            shareReplay(1)
          );
          this.usersCacheService.setValue(recipes$);
        }
        return recipes$;
      })
    );
  }

  getRecipeById(id: number): Observable<FullRecipe> {
    return this.authService.user.pipe(
      take(1),
      switchMap(user => {
        const url = `${this.endpointById}?id=${id}`;
        const headers = new HttpHeaders().set('Authorization', `Bearer ${user.token}`);

        return this.http.get<FullRecipe>(url, { headers });
      })
    );
  }

  postRecipe(recipe: any): Observable<any> {
    return this.authService.user.pipe(
      take(1),
      switchMap(user => {
        const headers = new HttpHeaders().set('Authorization', `Bearer ${user.token}`);
        return this.http.post<any>(this.endpoint, recipe, { headers });
      })
    );
  }

  putRecipe(recipe: any): Observable<any> {
    return this.authService.user.pipe(
      take(1),
      switchMap(user => {
        const headers = new HttpHeaders().set('Authorization', `Bearer ${user.token}`);
        return this.http.put<any>(this.endpoint, recipe, { headers });
      })
    );
  }

  deleteRecipe(id: any): Observable<any> {
    return this.authService.user.pipe(
      take(1),
      switchMap(user => {
        const headers = new HttpHeaders().set('Authorization', `Bearer ${user.token}`);
        const url = `${this.endpoint}?id=${id}`;
        return this.http.delete<any>(url, { headers });
      })
    );
  }

}
