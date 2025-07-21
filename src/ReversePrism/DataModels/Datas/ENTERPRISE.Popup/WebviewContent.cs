using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Webview                                  ModelClassType WebviewController WebviewController WebviewController Pointer
    public partial class WebviewContent : DataModel
    {
        public WebviewController?                       Webview                                 { get; set; }

        public static WebviewContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebviewContent() { Pointer= p0 };

            value.Webview                                   = GetObject<WebviewController>(new IntPtr(p + 0x060), ReversePrism.DataModels.WebviewController.FromPointer); // 0x60 Webview                     ( ModelClassType WebviewController WebviewController WebviewController Pointer )

            return value;
        }
    }
}
