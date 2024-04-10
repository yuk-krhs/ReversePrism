using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Result                                   00018654F660 ModelEnumType WebRequestResult WebRequestResult WebRequestResult Int32
    // 018 ErrorMessage                             0001866722E0 ModelPrimitiveType string string string String
    // 020 ErrorBody                                0001866722E0 ModelPrimitiveType string string string String
    // 028 ResponseCode                             0001865F7E40 ModelPrimitiveType long long long Int64
    public partial class WebRequest : DataModel
    {
        public WebRequestResult                         Result                                  { get; set; }
        public string                                   ErrorMessage                            { get; set; }
        public string                                   ErrorBody                               { get; set; }
        public long                                     ResponseCode                            { get; set; }

        public static WebRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebRequest() { Pointer= p0 };

            value.Result                                    = (WebRequestResult)GetInt32(new IntPtr(p + 0x010)); // 02466BE0A5A0 0x10 Result                      ( 00018654F660 ModelEnumType WebRequestResult WebRequestResult WebRequestResult Int32 )
            value.ErrorMessage                              = GetString(new IntPtr(p + 0x018)); // 02466BE0A5C0 0x18 ErrorMessage                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ErrorBody                                 = GetString(new IntPtr(p + 0x020)); // 02466BE0A5E0 0x20 ErrorBody                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ResponseCode                              = GetInt64(new IntPtr(p + 0x028)); // 02466BE0A600 0x28 ResponseCode                ( 0001865F7E40 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
