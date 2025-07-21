using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Email                                    ModelPrimitiveType string string string String
    // 018 Username                                 ModelPrimitiveType string string string String
    // 020 Billing                                  ModelClassType Billing Billing Billing Pointer
    public partial class User : DataModel
    {
        public string                                   Email                                   { get; set; }
        public string                                   Username                                { get; set; }
        public Billing?                                 Billing                                 { get; set; }

        public static User? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new User() { Pointer= p0 };

            value.Email                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Email                       ( ModelPrimitiveType string string string String )
            value.Username                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Username                    ( ModelPrimitiveType string string string String )
            value.Billing                                   = GetObject<Billing>(new IntPtr(p + 0x020), ReversePrism.DataModels.Billing.FromPointer); // 0x20 Billing                     ( ModelClassType Billing Billing Billing Pointer )

            return value;
        }
    }
}
