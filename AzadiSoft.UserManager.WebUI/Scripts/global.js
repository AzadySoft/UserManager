function getModal() {

    return $('#modal-box');
}

function showLoading() {

    $.LoadingOverlay('show');
}

function hideLoading() {

    $.LoadingOverlay('hide');

}

function showModal(title, bodyText) {

    var modal = getModal();

    var titleBox = $('h4.modal-title', modal);

    titleBox.html(title);

    var bodyElm = $('div.modal-body', modal);

    bodyElm.html(bodyText);

    modal.modal('show');
}

function closeModal() {

    getModal().modal('hide');
}

function ajaxCall(url, successFn, method, postData, failFunction, completeFn) {

    

    var options = {
        url: url,

        success: function(html) {

            try {

                if (successFn) {
                    successFn(html);
                }

            } catch (e) {

            }
        },

        error: function(ex) {


            if (failFunction) {

                failFunction(ex);

            } else {

                console.error(ex);
            }
        },

        complete: function(e) {

            if (completeFn) {

                completeFn(e);
            }

            hideLoading();

        },

        type: method,

        data: postData

    };

    showLoading();

    $.ajax(options);

}

$.fn.checked = function () {
    var obj = $(this);
    return obj.prop('checked');
}

$.fn.check = function () {
    var obj = $(this);
    obj.prop('checked', true);
}

$.fn.uncheck = function () {
    var obj = $(this);
    obj.prop('checked', false);
}


$.fn.disabled = function () {
    var obj = $(this);
    return obj.prop('disabled');
}

$.fn.disable = function () {
    var obj = $(this);
    obj.prop('disabled', true);
}

$.fn.enable = function () {
    var obj = $(this);
    obj.prop('disabled', false);
}