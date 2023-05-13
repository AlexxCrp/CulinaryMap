import { Component, AfterViewInit } from '@angular/core';
import * as L from 'leaflet';


@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.scss']
})
export class MapComponent implements AfterViewInit {
  private map;

  private initMap(): void {
    const bounds = L.latLngBounds([42.62, 20.22], [48.27, 29.67]);

    this.map = L.map("map", {
      maxBounds: bounds,
      zoomSnap: 0.5,
      minZoom: 7
    }).setView([45.94, 25.19], 7);

    L.tileLayer("https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png", {
      attribution:
        '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(this.map);



  }

  constructor() { }

  ngAfterViewInit(): void {
    this.initMap();
  }
}
