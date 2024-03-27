using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 delete_method                            HttpMethod IL2CPP_TYPE_CLASS
    // 008 get_method                               HttpMethod IL2CPP_TYPE_CLASS
    // 010 Head_method                              0001866E0CD0 ModelClassType HttpMethod HttpMethod HttpMethod Pointer
    // 018 Options_method                           0001866E0CD0 ModelClassType HttpMethod HttpMethod HttpMethod Pointer
    // 020 Post_method                              0001866E0CD0 ModelClassType HttpMethod HttpMethod HttpMethod Pointer
    // 028 Put_method                               0001866E0CD0 ModelClassType HttpMethod HttpMethod HttpMethod Pointer
    // 030 Trace_method                             0001866E0CD0 ModelClassType HttpMethod HttpMethod HttpMethod Pointer
    // 010 Method                                   000186672F10 ModelPrimitiveType string string string String
    public partial class HttpMethod
    {
        public HttpMethod?                              Head_method                             { get; set; }
        public HttpMethod?                              Options_method                          { get; set; }
        public HttpMethod?                              Post_method                             { get; set; }
        public HttpMethod?                              Put_method                              { get; set; }
        public HttpMethod?                              Trace_method                            { get; set; }
        public string                                   Method                                  { get; set; }

        public static HttpMethod? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpMethod();

            value.Head_method                               = GetObject<HttpMethod>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpMethod.FromPointer); // 0270DB82BF70 0x10 Head_method                 ( 0001866E0CD0 ModelClassType HttpMethod HttpMethod HttpMethod Pointer )
            value.Options_method                            = GetObject<HttpMethod>(new IntPtr(p + 0x018), ReversePrism.DataModels.HttpMethod.FromPointer); // 0270DB82BF90 0x18 Options_method              ( 0001866E0CD0 ModelClassType HttpMethod HttpMethod HttpMethod Pointer )
            value.Post_method                               = GetObject<HttpMethod>(new IntPtr(p + 0x020), ReversePrism.DataModels.HttpMethod.FromPointer); // 0270DB82BFB0 0x20 Post_method                 ( 0001866E0CD0 ModelClassType HttpMethod HttpMethod HttpMethod Pointer )
            value.Put_method                                = GetObject<HttpMethod>(new IntPtr(p + 0x028), ReversePrism.DataModels.HttpMethod.FromPointer); // 0270DB82BFD0 0x28 Put_method                  ( 0001866E0CD0 ModelClassType HttpMethod HttpMethod HttpMethod Pointer )
            value.Trace_method                              = GetObject<HttpMethod>(new IntPtr(p + 0x030), ReversePrism.DataModels.HttpMethod.FromPointer); // 0270DB82BFF0 0x30 Trace_method                ( 0001866E0CD0 ModelClassType HttpMethod HttpMethod HttpMethod Pointer )
            value.Method                                    = GetString(new IntPtr(p + 0x010)); // 0270DB82C010 0x10 Method                      ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
