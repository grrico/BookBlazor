function initialize(bookLatLngs, booklatlng, zoom, serializedString) {

    //Creating a JavaScriptSerializer Object

    var verticesLinea = JSON.parse(serializedString);

    if (booklatlng != null) {
        var latlngRepDom = new google.maps.LatLng(booklatlng.latitud, booklatlng.longitud);

        console.log(booklatlng.latitud);

        var options = {
            zoom: zoom, center: latlngRepDom,
            /*mapTypeId: google.maps.MapTypeId.ROADMAP,*/
            mapTypeId: google.maps.MapTypeId.satellite
        };
        var map = new google.maps.Map(document.getElementById("map"), options);

        bookLatLngs.forEach((booklatlng) => {
            if (booklatlng.latitud && booklatlng.longitud) {
                var marker = new google.maps.Marker({
                    position: new google.maps.LatLng(booklatlng.latitud, booklatlng.longitud),
                    map: map,
                });
            }
        })

        var linea = new google.maps.Polyline({
            path: verticesLinea ,
            map: map,
            strokeColor: 'rgb(255, 0, 0)',
            strokeWeight: 2
        });
    }
}