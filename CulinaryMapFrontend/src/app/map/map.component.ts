import { Component, AfterViewInit, Input, ViewContainerRef, ViewChild, AfterContentInit, OnChanges, SimpleChanges } from '@angular/core';
import * as L from 'leaflet';
import { FullRecipe } from '../models/fullRecipe.model';
import {RecipeQuickviewComponent} from '../recipe-quickview/recipe-quickview.component'

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
export class MapComponent implements AfterViewInit   {
  private map;
  private markers = []; // keep track of added markers
  @Input() preFilteredRecipes : FullRecipe[]
  filteredRecipes: FullRecipe[];
  selectedRecipe: FullRecipe = null;
  test:boolean = false;
  @ViewChild('vc', {read: ViewContainerRef}) vc: ViewContainerRef;


  constructor() {}


  private initMap(): void {
    const bounds = L.latLngBounds([41.62, 19.22], [49.27, 30.67]);

    this.map = L.map('map', {
      maxBounds: bounds,
      zoomSnap: 0.5,
      minZoom: 7
    }).setView([45.94, 25.19], 7);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
      attribution:
        '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(this.map);

    this.filteredRecipes = this.preFilteredRecipes;
    this.addMarkers();
  }

  ngAfterViewInit(): void {
    this.initMap();
  }

  setFilteredRecipes(filteredRecipes: FullRecipe[]): void {
    this.filteredRecipes = filteredRecipes;
  }

  private addMarkers(): void {
    // remove existing markers
    this.markers.forEach((marker) => marker.removeFrom(this.map));
    this.markers = [];

    // Hide all quickview components initially
    this.vc.clear();

    if (this.selectedRecipe === null) {
      // add markers for filtered recipes
      this.filteredRecipes.forEach((recipe) => {
        const quickView = this.vc.createComponent<RecipeQuickviewComponent>(RecipeQuickviewComponent);
        quickView.instance.recipe = recipe;
        quickView.location.nativeElement.style.visibility = 'hidden'; // Set visibility to hidden

        const marker = L.marker([recipe.latitude, recipe.longitude])
          .bindPopup(() => {
            // Show the quickview component when the marker is clicked
            quickView.location.nativeElement.style.visibility = 'visible';
            return quickView.location.nativeElement;
          })
          .addTo(this.map);
        this.markers.push(marker);
      });
    } else {
      const quickView = this.vc.createComponent<RecipeQuickviewComponent>(RecipeQuickviewComponent);
      quickView.instance.recipe = this.selectedRecipe;
      quickView.location.nativeElement.style.visibility = 'hidden'; // Set visibility to hidden

      const marker = L.marker([this.selectedRecipe.latitude, this.selectedRecipe.longitude])
        .bindPopup(() => {
          // Show the quickview component when the marker is clicked
          quickView.location.nativeElement.style.visibility = 'visible';
          return quickView.location.nativeElement;
        })
        .addTo(this.map);
      this.markers.push(marker);
    }

    console.log(this.filteredRecipes[0].latitude);
  }



  //function to update markers when filtered recipes change
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
