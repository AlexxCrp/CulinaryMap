import { Observable } from "rxjs";
import { FullRecipe } from "../models/fullRecipe.model";
import * as moment from "moment";

export class RecipeCachingService {

  readonly CACHE_DURATION_IN_MINUTES = 60;

  private cache: {
    expires: Date,
    value: Observable<FullRecipe[]>
  } = null;

  constructor() {
  }

  getValue(): Observable<FullRecipe[]> {
    if (!this.cache) {
      return null;
    }

    if (moment().isAfter(moment(this.cache.expires))) {
      return null;
    }

    return this.cache.value;
  }

  setValue(value: Observable<FullRecipe[]>) {
    this.cache = {
      value,
      expires: moment(new Date()).add(this.CACHE_DURATION_IN_MINUTES, 'minutes').toDate()
    };

  }

  clearCache() {
    this.cache = null;
  }
}
