window.SweetAlertHelper = {
    showAlert: function (title, text, icon) {
        Swal.fire(
            {
                title: title,
                text: text,
                icon: icon,
                confirmButtonText: 'OK'
            });
    },
    showConfirmation: function (title, text) {
        return Swal.fire(
            {
                title: title,
                text: text,
                icon: 'warning',
                showCancelButton: true,
                confirmButtonText: 'Yes',
                cancelButtonText: 'No'
            });
    }
};