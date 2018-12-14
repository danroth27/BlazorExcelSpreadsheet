using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorUtils
{
    public static class FileUtil
    {
        public static Task SaveAs(string filename, byte[] data)
            => JSRuntime.Current.InvokeAsync<object>(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
    }
}
