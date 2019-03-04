function getModal() {

    return $('#modal-box');
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

function ajaxCall(url, successFn, method, postData, failFunction) {

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

        type: method,

        data: postData

    };

    $.ajax(options);

}