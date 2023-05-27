window.focusFirstComponent = {
    focusComponent: function (evt) {
        if (focusFirstComponent.selector && evt.altKey == true && evt.keyCode == 87) {
            // Alt + W, only for demos that provide a selector to focus
            var elToFocus = document.querySelector('.example-runner > .tabstrip-pane ' + focusFirstComponent.selector);
            if (elToFocus && elToFocus.focus) {
                elToFocus.focus();
            }
        }
    },
    selector: "",
    setSelector: function (currSelector) {
        focusFirstComponent.selector = currSelector;
    }
};

document.addEventListener("keydown", focusFirstComponent.focusComponent);
