/// <reference path="GoogleMaps/google.maps.d.ts" />
/// <reference path="jquery.d.ts" />

module mypage.maps {
    export class GoogleMap {
        private googleMap: google.maps.Map;
        private infoWindow: google.maps.InfoWindow = new google.maps.InfoWindow();
        private timeoutClick: any;
        private Div: any;
        
        constructor(key: string, div: any, options?: any) {
            this.Div = div;
            var opts = {
                latitude: 0,
                longitude: 0,
                zoom: 2,
                mapControlsVisible: true
            };

            var obj = $.extend(opts, options);
            var p = new google.maps.LatLng(obj.latitude, obj.longitude);
            this.LoadMap(p, obj.zoom);
        }

        public LoadMap(startPos: google.maps.LatLng, startZoom: number) {
            var me = this;
            var mapOptions: google.maps.MapOptions =
                {
                    zoom: startZoom,
                    center: startPos,
                    mapTypeId: google.maps.MapTypeId.ROADMAP,
                    mapTypeControl: true,
                    navigationControl: true,
                    streetViewControl: true
                };

            this.googleMap = new google.maps.Map(this.Div, mapOptions);

            google.maps.event.addListener(me.googleMap, "click", function (latlng) {
                me.timeoutClick = setTimeout(function () { me._click(latlng, me); }, 200);

            });

            google.maps.event.addListenerOnce(me.googleMap, "idle", function () {
                
            });

            google.maps.event.addListener(me.googleMap, "dblclick", function (latlng) {
                if (me.timeoutClick)
                    clearTimeout(me.timeoutClick);

                var param = {
                    x: 0,
                    y: 0,
                    latitude: latlng.latLng.lat(),
                    longitude: latlng.latLng.lng()
                }

                
            });

        }
        private _click(latlng: any, me: any) {
            var param = {
                x: 0,
                y: 0,
                latitude: latlng.latLng.lat(),
                longitude: latlng.latLng.lng()
            }
                me.OnClick(param);

            if (me.onClickEvents != null) {
                for (var i = 0; i < me.onClickEvents.length; i++) {
                    me.onClickEvents[i](param);
                }
            }
        }

        public Geocode(address: string, callbackResult: (result: any) => void): void {
            var geocoder = new google.maps.Geocoder();
            var gRequest = { address: address };
            geocoder.geocode(
                gRequest,
                function (results: google.maps.GeocoderResult[], status: google.maps.GeocoderStatus) {
                    if (status == google.maps.GeocoderStatus.OK) {
                        if (results) {
                            var opts = {
                                Latitude: results[0].geometry.location.lat(),
                                Longitude: results[0].geometry.location.lng()
                            };

                            callbackResult(opts);
                        } else {
                            callbackResult(null);
                        }
                    }
                }
            );
        }
        

        public ZoomIn() {
            this.googleMap.setZoom(this.googleMap.getZoom() + 1);
        }

        public ZoomOut() {
            this.googleMap.setZoom(this.googleMap.getZoom() - 1);
        }

        public FindRoute(address1: string, address2: string, callbackResult: (result: any) => void): void {
            var me = this;
            var directionsService = new google.maps.DirectionsService();
            var route;
            
            var request = {
                origin: address1,
                destination: address2,
                travelMode: google.maps.TravelMode.DRIVING
            };

            directionsService.route(request, function (result, status) {
                if (status == google.maps.DirectionsStatus.OK) {
                    callbackResult(result.routes[0].overview_path);
                }
                else
                    callbackResult(new Array());
            });
        }
    }

    $(document).ready(function () {
        var map = new GoogleMap("googleMap", $("div[id='divMap']")[0], {});
    });
}