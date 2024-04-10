using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 M_Status                                 00018654AAC0 ModelEnumType WebExceptionStatus WebExceptionStatus WebExceptionStatus Int32
    // 098 M_Response                               000186550A80 ModelClassType WebResponse WebResponse WebResponse Pointer
    // 0A0 M_InternalStatus                         00018654A0D0 ModelEnumType WebExceptionInternalStatus WebExceptionInternalStatus WebExceptionInternalStatus Int32
    public partial class WebException : DataModel
    {
        public WebExceptionStatus                       M_Status                                { get; set; }
        public WebResponse?                             M_Response                              { get; set; }
        public WebExceptionInternalStatus               M_InternalStatus                        { get; set; }

        public static WebException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebException() { Pointer= p0 };

            value.M_Status                                  = (WebExceptionStatus)GetInt32(new IntPtr(p + 0x090)); // 024667A8CAE8 0x90 M_Status                    ( 00018654AAC0 ModelEnumType WebExceptionStatus WebExceptionStatus WebExceptionStatus Int32 )
            value.M_Response                                = GetObject<WebResponse>(new IntPtr(p + 0x098), ReversePrism.DataModels.WebResponse.FromPointer); // 024667A8CB08 0x98 M_Response                  ( 000186550A80 ModelClassType WebResponse WebResponse WebResponse Pointer )
            value.M_InternalStatus                          = (WebExceptionInternalStatus)GetInt32(new IntPtr(p + 0x0A0)); // 024667A8CB28 0xA0 M_InternalStatus            ( 00018654A0D0 ModelEnumType WebExceptionInternalStatus WebExceptionInternalStatus WebExceptionInternalStatus Int32 )

            return value;
        }
    }
}
