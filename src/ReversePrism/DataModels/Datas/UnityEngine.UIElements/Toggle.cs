using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 labelUssClassName                        string IL2CPP_TYPE_STRING
    // 010 InputUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 018 NoTextVariantUssClassName                000186674040 ModelPrimitiveType string string string String
    // 020 CheckmarkUssClassName                    000186674040 ModelPrimitiveType string string string String
    // 028 TextUssClassName                         000186674040 ModelPrimitiveType string string string String
    // 030 MixedValuesUssClassName                  000186674040 ModelPrimitiveType string string string String
    public partial class Toggle : DataModel
    {
        public string                                   InputUssClassName                       { get; set; }
        public string                                   NoTextVariantUssClassName               { get; set; }
        public string                                   CheckmarkUssClassName                   { get; set; }
        public string                                   TextUssClassName                        { get; set; }
        public string                                   MixedValuesUssClassName                 { get; set; }

        public static Toggle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Toggle() { Pointer= p0 };

            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0245A6702148 0x10 InputUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.NoTextVariantUssClassName                 = GetString(new IntPtr(p + 0x018)); // 0245A6702168 0x18 NoTextVariantUssClassName   ( 000186674040 ModelPrimitiveType string string string String )
            value.CheckmarkUssClassName                     = GetString(new IntPtr(p + 0x020)); // 0245A6702188 0x20 CheckmarkUssClassName       ( 000186674040 ModelPrimitiveType string string string String )
            value.TextUssClassName                          = GetString(new IntPtr(p + 0x028)); // 0245A67021A8 0x28 TextUssClassName            ( 000186674040 ModelPrimitiveType string string string String )
            value.MixedValuesUssClassName                   = GetString(new IntPtr(p + 0x030)); // 0245A67021C8 0x30 MixedValuesUssClassName     ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
