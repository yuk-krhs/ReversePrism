using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResponseCode                             000186684F90 ModelEnumType GoogleBillingResponseCode GoogleBillingResponseCode GoogleBillingResponseCode Int32
    // 018 DebugMessage                             000186672F10 ModelPrimitiveType string string string String
    public partial class GoogleBillingResult
    {
        public GoogleBillingResponseCode                ResponseCode                            { get; set; }
        public string                                   DebugMessage                            { get; set; }

        public static GoogleBillingResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleBillingResult();

            value.ResponseCode                              = (GoogleBillingResponseCode)GetInt32(new IntPtr(p + 0x010)); // 027006924B00 0x10 ResponseCode                ( 000186684F90 ModelEnumType GoogleBillingResponseCode GoogleBillingResponseCode GoogleBillingResponseCode Int32 )
            value.DebugMessage                              = GetString(new IntPtr(p + 0x018)); // 027006924B20 0x18 DebugMessage                ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
