using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_name                                   ModelPrimitiveType string string string String
    // 018 M_token                                  ModelEnumType CookieToken CookieToken CookieToken Int32
    public partial class RecognizedAttribute : DataModel
    {
        public string                                   M_name                                  { get; set; }
        public CookieToken                              M_token                                 { get; set; }

        public static RecognizedAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecognizedAttribute() { Pointer= p0 };

            value.M_name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_name                      ( ModelPrimitiveType string string string String )
            value.M_token                                   = (CookieToken)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_token                     ( ModelEnumType CookieToken CookieToken CookieToken Int32 )

            return value;
        }
    }
}
