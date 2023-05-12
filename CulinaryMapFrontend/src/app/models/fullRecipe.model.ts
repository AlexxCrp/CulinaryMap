import { FullRecipeIngredient } from "./fullRecipeIngredient.model";

export interface FullRecipe{
  id: number;
  regionId: number;
  region: string;
  latitude: number;
  longitude: number;
  name: string;
  prepMode: string;
  history?: string;
  type: string;
  prepTime?: string;
  ingredients: FullRecipeIngredient[];
  images: string[];
}
