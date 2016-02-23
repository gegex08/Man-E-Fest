namespace GroupProjectFestivalApp.Controllers {
    export class CommentController {
        
        public comments;        

        constructor(private $http: ng.IHttpService, private $routeParams) {
            $http.get(`/api/comments/${$routeParams.id}`)
                .then((response) => {
                    this.comments = response.data;
                });
        }
    }
}
