using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BoneName                               000186671910 ModelPrimitiveType string string string String
    // 018 M_HumanName                              000186671910 ModelPrimitiveType string string string String
    // 020 Limit                                    0001866E7D80 ModelEnumType HumanLimit HumanLimit HumanLimit Int32
    public partial class HumanBone
    {
        public string                                   M_BoneName                              { get; set; }
        public string                                   M_HumanName                             { get; set; }
        public HumanLimit                               Limit                                   { get; set; }

        public static HumanBone? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HumanBone();

            value.M_BoneName                                = GetString(new IntPtr(p + 0x010)); // 02700227E8D0 0x10 M_BoneName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.M_HumanName                               = GetString(new IntPtr(p + 0x018)); // 02700227E8F0 0x18 M_HumanName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Limit                                     = (HumanLimit)GetInt32(new IntPtr(p + 0x020)); // 02700227E910 0x20 Limit                       ( 0001866E7D80 ModelEnumType HumanLimit HumanLimit HumanLimit Int32 )

            return value;
        }
    }
}
