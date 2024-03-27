using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TimeoutDefault                           TimeSpan IL2CPP_TYPE_VALUETYPE
    // 020 Base_address                             0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 028 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Headers                                  0001866E2A10 ModelClassType HttpRequestHeaders HttpRequestHeaders HttpRequestHeaders Pointer
    // 040 Buffer_size                              0001865F7700 ModelPrimitiveType long long long Int64
    // 048 Timeout                                  00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    public partial class HttpClient
    {
        public Uri?                                     Base_address                            { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public bool                                     Disposed                                { get; set; }
        public HttpRequestHeaders?                      Headers                                 { get; set; }
        public long                                     Buffer_size                             { get; set; }
        public TimeSpan                                 Timeout                                 { get; set; }

        public static HttpClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpClient();

            value.Base_address                              = GetObject<Uri>(new IntPtr(p + 0x020), ReversePrism.DataModels.Uri.FromPointer); // 0270DB6DC3B0 0x20 Base_address                ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270DB6DC3D0 0x28 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x030)); // 0270DB6DC3F0 0x30 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Headers                                   = GetObject<HttpRequestHeaders>(new IntPtr(p + 0x038), ReversePrism.DataModels.HttpRequestHeaders.FromPointer); // 0270DB6DC410 0x38 Headers                     ( 0001866E2A10 ModelClassType HttpRequestHeaders HttpRequestHeaders HttpRequestHeaders Pointer )
            value.Buffer_size                               = GetInt64(new IntPtr(p + 0x040)); // 0270DB6DC430 0x40 Buffer_size                 ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Timeout                                   = (TimeSpan)GetInt32(new IntPtr(p + 0x048)); // 0270DB6DC450 0x48 Timeout                     ( 00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}
