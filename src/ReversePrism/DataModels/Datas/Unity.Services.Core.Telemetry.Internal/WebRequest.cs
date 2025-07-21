using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Result                                   ModelEnumType WebRequestResult WebRequestResult WebRequestResult Int32
    // 018 ErrorMessage                             ModelPrimitiveType string string string String
    // 020 ErrorBody                                ModelPrimitiveType string string string String
    // 028 ResponseCode                             ModelPrimitiveType long long long Int64
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

            value.Result                                    = (WebRequestResult)GetInt32(new IntPtr(p + 0x010)); // 0x10 Result                      ( ModelEnumType WebRequestResult WebRequestResult WebRequestResult Int32 )
            value.ErrorMessage                              = GetString(new IntPtr(p + 0x018)); // 0x18 ErrorMessage                ( ModelPrimitiveType string string string String )
            value.ErrorBody                                 = GetString(new IntPtr(p + 0x020)); // 0x20 ErrorBody                   ( ModelPrimitiveType string string string String )
            value.ResponseCode                              = GetInt64(new IntPtr(p + 0x028)); // 0x28 ResponseCode                ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
