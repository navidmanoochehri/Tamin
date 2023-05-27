window.codeManager = {
    renderCode: function (url) {

        var xhr = new XMLHttpRequest();
        xhr.open('GET', '/blazor-ui/source/index?path=/Pages' + url.replace(/-/g, '_'));
        var snippetContainer = document.getElementById("codecontainer");
        xhr.onload = function () {
            if (xhr.status === 200) {
                if (snippetContainer) {
                    snippetContainer.innerHTML = xhr.responseText;
                    prettyPrint();
                }
            }
            else {
                if (snippetContainer) {
                    snippetContainer.innerHTML = 'Request for code snippet failed.  Returned status of ' + xhr.status;
                }
            }
        };
        xhr.send();
    }
}
