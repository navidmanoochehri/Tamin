window.telerikNav = {
    footerSelector: "#telerik-global-footer-container",
    headerHtml: "",
    footerHtml: "",
    addHeaderToDom: function () {
        var appElem = document.getElementsByTagName('app')[0];
        var HtmlContent = document.createRange().createContextualFragment(this.headerHtml);
        appElem.prepend(HtmlContent);

        setTimeout(function() {
            document.getElementById('js-tlrk-nav').style.display = 'block';
            document.getElementById('header-placeholder').style.display = 'none';
        }, 200);

    },
    addFooterToDom: function () {
        var containerElem = document.querySelector(this.footerSelector);
        containerElem.innerHTML = this.footerHtml;
    },
    displayNavigation: function () {
        if (!document.getElementById("js-tlrk-nav")) {
            var intervalLimit = 0;
            var intervalHeader = setInterval(function () {
                intervalLimit++;
                if (telerikNav.headerHtml !== '' || intervalLimit >= 50) {
                    telerikNav.addHeaderToDom();
                    clearInterval(intervalHeader);
                }
            }, 20);
        } else {
            document.getElementById('header-placeholder').style.display = 'none';
        }

        if (!document.querySelector(this.footerSelector).hasChildNodes()) {
            var intervalFooterLimit = 0;
            var intervalFooter = setInterval(function () {
                intervalFooterLimit++;
                if (telerikNav.footerHtml !== '' || intervalFooterLimit >= 50) {
                    telerikNav.addFooterToDom();
                    clearInterval(intervalFooter);
                }
            }, 20);
        }
    },
    initialize: function () {
        var currentUrl = location.href;
        var cdnEnvironment = "";
        var telerikNavigationVersion = "stable";
        var productName = "blazor-ui";
        var headerUrl = "";
        var footerUrl = "";


        // if (currentUrl.indexOf("localhost") === -1) {

        if (currentUrl.indexOf("kendobuild") !== -1) {
            cdnEnvironment = "uat";
        }

        headerUrl = `https://${cdnEnvironment}cdn.telerik-web-assets.com/telerik-navigation/${telerikNavigationVersion}/nav-${productName}-csa-abs-component.html`;
        footerUrl = `https://${cdnEnvironment}cdn.telerik-web-assets.com/telerik-navigation/${telerikNavigationVersion}/footer-big-abs-markup.html`;

        fetch(headerUrl)
            .then(function (response) {
                return response.text();
            })
            .then(function (html) {
                window.telerikNav.headerHtml = html;
            })
            .catch(function () { });

        fetch(footerUrl)
            .then(function (response) {
                return response.text();
            })
            .then(function (html) {
                window.telerikNav.footerHtml = html;
            })
            .catch(function () { });
    // }
    }
};

(function () {
    window.telerikNav.initialize();
})();
