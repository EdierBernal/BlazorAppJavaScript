using Microsoft.JSInterop;

namespace BlazorAppJavaScript.Helpers
{
    public class SweetAlertService
    {
        private readonly IJSRuntime _jsRuntime;

        //Inyección de dependencias
        public SweetAlertService(IJSRuntime jsRuntime) { _jsRuntime = jsRuntime; }
        public async Task ShowAlert(string tittle, string text, string icon)
        {
            await _jsRuntime.InvokeVoidAsync("SweetAlertHelper.showAlert", tittle, text, icon);
        }
        public async Task<bool> ShowConfirmation(string tittle, string text)
        {
            bool result = await _jsRuntime.InvokeAsync<bool>("SweetAlertHelper.showConfirmation", tittle, text);
            return result;
        }
    }
}
