(function () {
    jQuery.fn.extend({
        createpath: function (urlParts) {
            var url;
            var char = urlParts.substr(0, 1);
            var enviroment = 1;
            if (char === '/')
                urlParts = urlParts.substr(1, urlParts.length - 1);

            if (enviroment == 1) {

                url = "/" + urlParts;

            } else if (enviroment == 2) {

                url = "/SICMST/" + urlParts;

            } else if (enviroment == 3) {

                url = "/SICMST2/" + urlParts;

            }
            return url;
        }
    });
})(jQuery);