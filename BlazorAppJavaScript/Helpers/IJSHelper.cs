using Microsoft.JSInterop;

namespace BlazorAppJavaScript.Helpers
{
    public static class IJSHelper
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async ValueTask ToastrDanger(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "danger", message);
        }
        public static async ValueTask ToastrWarning(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "warning", message);
        }
        public static async ValueTask ToastrInfo(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "info", message);
        }
    }
}
