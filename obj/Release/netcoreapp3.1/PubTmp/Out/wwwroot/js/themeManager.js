window.theme = {
    changeCss: function (cssFileUrl) {
        var oldLink = document.getElementById("kendoCss");

        if (cssFileUrl === oldLink.getAttribute("href")) {
            return;
        }

        var newLink = document.createElement("link");
        newLink.setAttribute("id", "kendoCss");
        newLink.setAttribute("rel", "stylesheet");
        newLink.setAttribute("type", "text/css");
        newLink.setAttribute("href", cssFileUrl);
        newLink.onload = () => {
            oldLink.parentElement.removeChild(oldLink);

            var componentElements = document.querySelectorAll(".k-chart, .k-scheduler-layout");
            var instances = TelerikBlazor._instances;

            for (var i = 0; i < componentElements.length; i++) {
                var id = componentElements[i].getAttribute("id");
                var instance = instances[id];

                if (instance && instance.refresh) {
                    instance.refresh();
                }
            }
        };

        document.getElementsByTagName("head")[0].appendChild(newLink);
    }
}
