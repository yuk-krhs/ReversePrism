using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Separator                                string IL2CPP_TYPE_STRING
    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Value                                    0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    public partial class NamedValue
    {
        public string                                   Name                                    { get; set; }
        public PrimitiveValue                           Value                                   { get; set; }

        public static NamedValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamedValue();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D7697AE0 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = (PrimitiveValue)GetInt32(new IntPtr(p + 0x018)); // 0270D7697B00 0x18 Value                       ( 0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )

            return value;
        }
    }
}
