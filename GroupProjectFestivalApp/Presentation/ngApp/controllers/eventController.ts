namespace GroupProjectFestivalApp.Controllers {

    export class EventController {

        public events;
        public comments;

        constructor(private $http: ng.IHttpService, private $routeParams) {
            $http.get(`/api/events/${$routeParams.id}`)
                .then((response) => {
                    this.events = response.data;
                });
        }

        public addComment(event, comment): void {
            if (comment) {
                this.$http.post(`api/events/${event.id}`, comment)

                    .then((response) => {
                        let eventDto: any = response.data; // eventdto
                        event.rating = eventDto.rating;
                        event.attraction.rating = eventDto.attraction.rating;

                        alert('Thank you for your feedback!');
                    })
                    .catch((response) => {
                        alert('There was an error. Sorry :(');
                    });
            }
        }



    }
}
