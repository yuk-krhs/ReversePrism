using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handler                                  0001866E02F0 ModelClassType HttpMessageHandler HttpMessageHandler HttpMessageHandler Pointer
    // 018 DisposeHandler                           0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class HttpMessageInvoker : DataModel
    {
        public HttpMessageHandler?                      Handler                                 { get; set; }
        public bool                                     DisposeHandler                          { get; set; }

        public static HttpMessageInvoker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpMessageInvoker() { Pointer= p0 };

            value.Handler                                   = GetObject<HttpMessageHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpMessageHandler.FromPointer); // 02466B768878 0x10 Handler                     ( 0001866E02F0 ModelClassType HttpMessageHandler HttpMessageHandler HttpMessageHandler Pointer )
            value.DisposeHandler                            = GetBool(new IntPtr(p + 0x018)); // 02466B768898 0x18 DisposeHandler              ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
