namespace GroupProjectFestivalApp.Controllers {

    export class EventController {

        public events;
        public comments;

        constructor(private $http: ng.IHttpService, private $routeParams) {
            $http.get(`/api/events`)
                .then((response) => {
                    this.events = response.data;
                });
        }

        public addComment(eventid, comment): void {
            console.log(eventid);
            console.log(comment);
            if (comment) {
                this.$http.post(`api/events/${eventid}`, {
                //this.$http.post(`/api/addComment`, {
                this.$http.post(`/api/${eventid}`, {

                    eventId: this.events.message,
                    comment: comment
                })
                    .then((response) => {
                        this.events.apply(response.data);
                    })
                    .catch((response) => {
                    });
            }
        }

        public getComment() {
            this.$http.get(`/api/comments`)
                .then((response) => {
                    this.comments = response.data;
                });
        }
    }
}
