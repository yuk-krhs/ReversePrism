using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Type                                   00018672C380 ModelEnumType PayoutType PayoutType PayoutType Int32
    // 018 M_Subtype                                000186671910 ModelPrimitiveType string string string String
    // 020 M_Quantity                               0001865C2950 ModelPrimitiveType double double double Double
    // 028 M_Data                                   000186671910 ModelPrimitiveType string string string String
    // 000 MaxSubtypeLength                         int IL2CPP_TYPE_I4
    // 000 MaxDataLength                            int IL2CPP_TYPE_I4
    public partial class PayoutDefinition : DataModel
    {
        public PayoutType                               M_Type                                  { get; set; }
        public string                                   M_Subtype                               { get; set; }
        public double                                   M_Quantity                              { get; set; }
        public string                                   M_Data                                  { get; set; }

        public static PayoutDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PayoutDefinition() { Pointer= p0 };

            value.M_Type                                    = (PayoutType)GetInt32(new IntPtr(p + 0x010)); // 0245A4C0B0D8 0x10 M_Type                      ( 00018672C380 ModelEnumType PayoutType PayoutType PayoutType Int32 )
            value.M_Subtype                                 = GetString(new IntPtr(p + 0x018)); // 0245A4C0B0F8 0x18 M_Subtype                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Quantity                                = GetDouble(new IntPtr(p + 0x020)); // 0245A4C0B118 0x20 M_Quantity                  ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_Data                                    = GetString(new IntPtr(p + 0x028)); // 0245A4C0B138 0x28 M_Data                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
