namespace GroupProjectFestivalApp.Controllers {

    export class MapController {

        public categories: any = {};

        public togglePin(category: string) {
            for (let key in this.categories) {
                this.categories[key] = false;
        
            }
            this.categories[category] = true;            
        }
    }
}