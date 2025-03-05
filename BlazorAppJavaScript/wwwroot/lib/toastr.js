window.ShowToastr = (type, message) => {
    if (type === "success") toastr.success(message)
    else if (type === "danger") toastr.error(message)
    else if (type === "warning") toastr.warning(message)
    else if (type === "info") toastr.info(message)

}

toastr.options = {
    "closeButton": false,
    "debug": false,
    "newestOnTop": false,
    "progressBar": true,
    "positionClass": "toast-bottom-center",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "300",
    "hideDuration": "1000",
    "timeOut": "5000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
}