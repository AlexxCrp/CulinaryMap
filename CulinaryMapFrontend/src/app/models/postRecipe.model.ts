export class PostRecipe {
  constructor(
    public name: string,
    public regionId: number,
    public latitude: string,
    public longitude: string,
    public prepMode: string,
    public history: string,
    public type: string,
    public prepTime: string
  ) {}
}
