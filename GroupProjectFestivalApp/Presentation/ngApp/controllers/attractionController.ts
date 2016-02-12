namespace GroupProjectFestivalApp.Controllers {

    export class AttractionController {

        public attractions;

        constructor(private $http: ng.IHttpService) {
            $http.get(`/api/attractions`)
                .then((response) => {
                    this.attractions = response.data;
                });
        }
    }
}