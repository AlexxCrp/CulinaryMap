import { Observable } from "rxjs";
import * as moment from "moment";
import { Ingredient } from "../models/ingredient.model";

export class IngredientCachingService {

  readonly CACHE_DURATION_IN_MINUTES = 60;

  private cache: {
    expires: Date,
    value: Observable<Ingredient[]>
  } = null;

  constructor() {
  }

  getValue(): Observable<Ingredient[]> {
    if (!this.cache) {
      return null;
    }

    if (moment().isAfter(moment(this.cache.expires))) {
      return null;
    }

    return this.cache.value;
  }

  setValue(value: Observable<Ingredient[]>) {
    this.cache = {
      value,
      expires: moment(new Date()).add(this.CACHE_DURATION_IN_MINUTES, 'minutes').toDate()
    };

  }

  clearCache() {
    this.cache = null;
  }
}
