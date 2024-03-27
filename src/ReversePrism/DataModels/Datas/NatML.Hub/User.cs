using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Email                                    0001866722E0 ModelPrimitiveType string string string String
    // 018 Username                                 0001866722E0 ModelPrimitiveType string string string String
    // 020 Billing                                  000186751500 ModelClassType Billing Billing Billing Pointer
    public partial class User
    {
        public string                                   Email                                   { get; set; }
        public string                                   Username                                { get; set; }
        public Billing?                                 Billing                                 { get; set; }

        public static User? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new User();

            value.Email                                     = GetString(new IntPtr(p + 0x010)); // 0270033422F8 0x10 Email                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Username                                  = GetString(new IntPtr(p + 0x018)); // 027003342318 0x18 Username                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Billing                                   = GetObject<Billing>(new IntPtr(p + 0x020), ReversePrism.DataModels.Billing.FromPointer); // 027003342338 0x20 Billing                     ( 000186751500 ModelClassType Billing Billing Billing Pointer )

            return value;
        }
    }
}
