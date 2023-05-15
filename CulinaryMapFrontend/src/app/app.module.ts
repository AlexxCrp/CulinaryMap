import { Injector, NgModule } from '@angular/core';
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
    MapComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    CommonModule,
    HttpClientModule,
    NgbModule
  ],
  providers: [
    RecipeService,
    RecipeCachingService
  ],
  bootstrap: [AppComponent],
  entryComponents:[RecipeQuickviewComponent]
})
export class AppModule {
  // constructor(private injector: Injector) {
  //   const PopupElement = createCustomElement(RecipeQuickviewComponent, {injector});
  //   // Register the custom element with the browser.
  //   customElements.define('popup-element', PopupElement);
 }
