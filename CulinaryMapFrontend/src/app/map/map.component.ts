import { Component, AfterViewInit, Input, ViewContainerRef, ViewChild, AfterContentInit } from '@angular/core';
import * as L from 'leaflet';
import { FullRecipe } from '../models/fullRecipe.model';
import {RecipeQuickviewComponent} from '../recipe-quickview/recipe-quickview.component'
import { createInjectableType } from '@angular/compiler';

const iconRetinaUrl = 'assets/marker-icon-2x.png';
const iconUrl = 'assets/marker-icon.png';
const shadowUrl = 'assets/marker-shadow.png';
const iconDefault = L.icon({
  iconRetinaUrl,
  iconUrl,
  shadowUrl,
  iconSize: [25, 41],
  iconAnchor: [12, 41],
  popupAnchor: [1, -34],
  tooltipAnchor: [16, -28],
  shadowSize: [41, 41]
});
L.Marker.prototype.options.icon = iconDefault;

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.scss']
})
export class MapComponent implements AfterViewInit  {
  private map;
  private markers = []; // keep track of added markers

  filteredRecipes: FullRecipe[];
  selectedRecipe: FullRecipe = null;

  @ViewChild('vc', {read: ViewContainerRef}) vc: ViewContainerRef;


  constructor() {}


  private initMap(): void {
    const bounds = L.latLngBounds([42.62, 20.22], [48.27, 29.67]);

    this.map = L.map('map', {
      maxBounds: bounds,
      zoomSnap: 0.5,
      minZoom: 7
    }).setView([45.94, 25.19], 7);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
      attribution:
        '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(this.map);
  }

  ngAfterViewInit(): void {
    this.initMap();
  }

  // function to add markers for filtered recipes
  private addMarkers(): void {
    // remove existing markers
    this.markers.forEach((marker) => marker.removeFrom(this.map));
    this.markers = [];
    if(this.selectedRecipe === null)
    {
      // add markers for filtered recipes
      this.filteredRecipes.forEach((recipe) => {
        var quickView = this.vc.createComponent<RecipeQuickviewComponent>(RecipeQuickviewComponent);
        quickView.instance.recipe = recipe;
        const marker = L.marker([recipe.latitude, recipe.longitude])
          .bindPopup(quickView.location.nativeElement)
          .addTo(this.map);
        this.markers.push(marker);
      });
    }
    else
    {
      var quickView = this.vc.createComponent<RecipeQuickviewComponent>(RecipeQuickviewComponent);
      quickView.instance.recipe = this.selectedRecipe;
      const marker = L.marker([this.selectedRecipe.latitude, this.selectedRecipe.longitude])
          .bindPopup(quickView.location.nativeElement)
          .addTo(this.map);
        this.markers.push(marker);
    }

    console.log(this.filteredRecipes[0].latitude);
  }

  // function to update markers when filtered recipes change
  public updateMarkers(filteredRecipes : FullRecipe[]): void {
    this.filteredRecipes = filteredRecipes;
    this.selectedRecipe = null;
    this.addMarkers();
  }
  public updateMarkersTargeted(recipe : FullRecipe): void {
    this.selectedRecipe = recipe;
    this.filteredRecipes = null;
    this.addMarkers();
  }
}
