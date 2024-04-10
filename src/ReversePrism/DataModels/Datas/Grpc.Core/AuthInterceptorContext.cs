using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ServiceUrl                               000186672F10 ModelPrimitiveType string string string String
    // 018 MethodName                               000186672F10 ModelPrimitiveType string string string String
    public partial class AuthInterceptorContext : DataModel
    {
        public string                                   ServiceUrl                              { get; set; }
        public string                                   MethodName                              { get; set; }

        public static AuthInterceptorContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthInterceptorContext() { Pointer= p0 };

            value.ServiceUrl                                = GetString(new IntPtr(p + 0x010)); // 024669414AF8 0x10 ServiceUrl                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.MethodName                                = GetString(new IntPtr(p + 0x018)); // 024669414B18 0x18 MethodName                  ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
