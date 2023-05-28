import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { RecipeService } from './services/recipe.service';
import { RecipeCachingService } from './services/recipeCaching.service';
import { FilterButtonComponent } from './filter-button/filter-button.component';
import { SearchbarComponent } from './searchbar/searchbar.component';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeWrapperComponent } from './home-wrapper/home-wrapper.component';
import { RecipePageComponent } from './recipe-page/recipe-page.component';
import { RecipeCarouselComponent } from './recipe-carousel/recipe-carousel.component';
import { RecipeScrollspyComponent } from './recipe-scrollspy/recipe-scrollspy.component';
import { RecipeQuickviewComponent } from './recipe-quickview/recipe-quickview.component';
import { MainPageComponent } from './main-page/main-page.component';
import { MapComponent } from './map/map.component';
import { RouterModule, Routes } from '@angular/router';
import { AuthComponent } from './auth/auth.component';
import { IngredientCachingService } from './services/ingredientCaching.service';
import { IngredientService } from './services/ingredient.service';
import { AdminPageComponent } from './admin-page/admin-page.component';
import { UpdateRecipeComponent } from './update-recipe/update-recipe.component';
import { CreateRecipeComponent } from './create-recipe/create-recipe.component';
import { DeleteRecipeComponent } from './delete-recipe/delete-recipe.component';
import { adminGuard, authGuard } from './services/auth.guard';

const appRoutes: Routes = [
  { path: 'home',
    component: HomeWrapperComponent,
    canActivate: [authGuard]
  },
  { path: 'recipe/:id',
    component: RecipePageComponent,
    canActivate: [authGuard]
  },
  {
    path:'',
    component: AuthComponent
  },
  {path: 'admin',
    component: AdminPageComponent,
    canActivate: [authGuard, adminGuard]
  }
];


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FilterButtonComponent,
    SearchbarComponent,
    HomeWrapperComponent,
    RecipePageComponent,
    RecipeCarouselComponent,
    RecipeScrollspyComponent,
    RecipeQuickviewComponent,
    MainPageComponent,
    MapComponent,
    AuthComponent,
    AdminPageComponent,
    UpdateRecipeComponent,
    CreateRecipeComponent,
    DeleteRecipeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    CommonModule,
    HttpClientModule,
    NgbModule,
    RouterModule.forRoot(appRoutes),
  ],
  exports: [
    RouterModule
  ],
  providers: [
    RecipeService,
    RecipeCachingService,
    IngredientCachingService,
    IngredientService
  ],
  bootstrap: [AppComponent],
  entryComponents:[RecipeQuickviewComponent]
})
export class AppModule {
 }
