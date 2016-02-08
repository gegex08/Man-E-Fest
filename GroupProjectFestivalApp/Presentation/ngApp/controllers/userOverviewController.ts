namespace GroupProjectFestivalApp.Controllers {

    export class OverViewController {

        public overview;

        constructor(private $http: ng.IHttpService, private $routeParams) {
            $http.get(`/api/overview/${$routeParams.id}`)
                .then((response) => {
                    this.overview = response.data;
                });

        }
    }
}
