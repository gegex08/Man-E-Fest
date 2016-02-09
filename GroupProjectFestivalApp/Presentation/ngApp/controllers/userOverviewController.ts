namespace GroupProjectFestivalApp.Controllers {

    export class OverviewController {

        public overview;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/overview')
                .then((response) => {
                    this.overview = response.data;
                });

        }
    }
}
