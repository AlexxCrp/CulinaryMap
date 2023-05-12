// import { Component, Input } from '@angular/core';

// @Component({
//   selector: 'app-recipe-carousel',
//   templateUrl: './recipe-carousel.component.html',
//   styleUrls: ['./recipe-carousel.component.scss']
// })
// export class RecipeCarouselComponent {
//   @Input() images: string[]
//   currentImageIndex = 0;

//   prevImage() {
//     this.currentImageIndex = (this.currentImageIndex === 0) ? this.images.length - 1 : this.currentImageIndex - 1;
//   }

//   nextImage() {
//     this.currentImageIndex = (this.currentImageIndex === this.images.length - 1) ? 0 : this.currentImageIndex + 1;
//   }

// }

import { Component, Input } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-recipe-carousel',
  templateUrl: './recipe-carousel.component.html',
  styleUrls: ['./recipe-carousel.component.scss'],
  providers: [NgbCarouselConfig]
})
export class RecipeCarouselComponent {
  @Input() images: string[];
  currentImageIndex = 0;

  constructor(config: NgbCarouselConfig) {
    config.interval = 0; // Disable autoplay
  }

  prevImage() {
    this.currentImageIndex = (this.currentImageIndex === 0) ? this.images.length - 1 : this.currentImageIndex - 1;
  }

  nextImage() {
    this.currentImageIndex = (this.currentImageIndex === this.images.length - 1) ? 0 : this.currentImageIndex + 1;
  }
}

