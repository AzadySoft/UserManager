class Control {
    state: any;
}

interface SelectableControl extends Control {
    select(): void;
}

class Button extends Control implements SelectableControl {
    select() { }
}

class TextBox extends Control {
    select() { }
}

// Error: Property 'state' is missing in type 'Image'.
class ImageTest implements SelectableControl {

    state: string;

    select() {

    }
}

function ajaxCallTs(url: string, successFn: Function, method: string, psotData: Object, failFunction: Function, completeFn: Function) {
    
}

