var filgiftsApp = angular.module('auctionApp', ['ui.router']);

filgiftsApp.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('/home');

    $stateProvider
        .state('home', {
            url: '',
            abstract: true,
            views: {
                'header':
                    {
                        templateUrl: 'js/app/partials/header.html'
                    },
                'topbar':
                    {
                        templateUrl: 'js/app/partials/topbar.html'
                    }

            }
        })

        .state('home.index', {
            url: '/home',
            views: {
                'container@': {
                    templateUrl: 'js/app/templates/home.html'
                }
            }
        })

});