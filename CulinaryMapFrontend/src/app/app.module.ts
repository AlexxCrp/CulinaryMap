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

const appRoutes: Routes = [
  { path: 'home',
    component: HomeWrapperComponent },
  { path: 'recipe/:id',
  component: RecipePageComponent },
  {
    path:'auth',
    component: AuthComponent
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
    AuthComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    CommonModule,
    HttpClientModule,
    NgbModule,
    RouterModule.forRoot(appRoutes)
  ],
  exports: [
    RouterModule
  ],
  providers: [
    RecipeService,
    RecipeCachingService
  ],
  bootstrap: [AppComponent],
  entryComponents:[RecipeQuickviewComponent]
})
export class AppModule {
 }
