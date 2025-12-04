window.onlineShop = window.onlineShop || {};
window.onlineShop.openFileDialogById = (elementId) => {
    const element = document.getElementById(elementId);
    if (element) {
        element.click();
    }
};

window.onlineShop.execEditorCommand = (editorId, command) => {
    const element = document.getElementById(editorId);
    if (!element) {
        return;
    }

    element.focus();
    document.execCommand(command, false, null);
};

window.onlineShop.getContentEditableValue = (editorId) => {
    const element = document.getElementById(editorId);
    return element ? element.innerHTML : "";
};

window.onlineShop.setContentEditableHtml = (editorId, value) => {
    const element = document.getElementById(editorId);
    if (element) {
        element.innerHTML = value || "";
    }
};

window.onlineShop.setHiddenInputValue = (inputId, value) => {
    const element = document.getElementById(inputId);
    if (element) {
        element.value = value || "";
    }
};
