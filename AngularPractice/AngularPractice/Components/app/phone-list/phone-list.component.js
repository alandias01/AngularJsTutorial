﻿angular.
    module('phoneList').
    component('phoneList', {
    templateUrl: 'app/phone-list/phone-list.template.html',
    controller: function PhoneListController() {
        this.phones = [
          {
              name: 'Nexus S',
              snippet: 'Fast just got faster with Nexus S.'
          }, {
              name: 'Motorola XOOM™ with Wi-Fi',
              snippet: 'The Next, Next Generation tablet.'
          }, {
              name: 'MOTOROLA XOOM™',
              snippet: 'The Next, Next Generation tablet.'
          }
        ];

        /* put $http inside  controller: function PhoneListController($http)
        var self = this;
        self.orderProp = 'age';

        $http.get('phones/phones.json').then(function(response) {
            self.phones = response.data;
        });
        */




    }

});
