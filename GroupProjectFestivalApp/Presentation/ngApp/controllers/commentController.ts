namespace GroupProjectFestivalApp.Controllers {
    export class CommentController {

        public comments;
        public attractions;

        constructor(private $http: ng.IHttpService, private $routeParams) {
            $http.get(`/api/event/comments`)
                .then((response) => {
                    this.comments = response.data;
                });
        }

        public getTag(tags): void {
            this.$http.get(`api/events/comments`)
                .then((response) => {
                    this.comments = response.data
                })
        }

        public getAttractions(events): void {
            this.$http.get(`/api/events/attractions`)
                .then((response) => {
                    this.attractions = response.data;
                });
        }
    }
}