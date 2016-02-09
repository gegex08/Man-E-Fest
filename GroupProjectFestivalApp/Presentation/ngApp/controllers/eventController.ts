namespace GroupProjectFestivalApp.Controllers {

    export class EventController {

        public events;

        constructor(private $http: ng.IHttpService) {
            $http.get(`/api/events`)
                .then((response) => {
                    this.events = response.data;
                });
        }
    }
}