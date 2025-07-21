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
    // 010 InputUssClassName                        ModelPrimitiveType string string string String
    // 018 NoTextVariantUssClassName                ModelPrimitiveType string string string String
    // 020 CheckmarkUssClassName                    ModelPrimitiveType string string string String
    // 028 TextUssClassName                         ModelPrimitiveType string string string String
    // 030 MixedValuesUssClassName                  ModelPrimitiveType string string string String
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

            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0x10 InputUssClassName           ( ModelPrimitiveType string string string String )
            value.NoTextVariantUssClassName                 = GetString(new IntPtr(p + 0x018)); // 0x18 NoTextVariantUssClassName   ( ModelPrimitiveType string string string String )
            value.CheckmarkUssClassName                     = GetString(new IntPtr(p + 0x020)); // 0x20 CheckmarkUssClassName       ( ModelPrimitiveType string string string String )
            value.TextUssClassName                          = GetString(new IntPtr(p + 0x028)); // 0x28 TextUssClassName            ( ModelPrimitiveType string string string String )
            value.MixedValuesUssClassName                   = GetString(new IntPtr(p + 0x030)); // 0x30 MixedValuesUssClassName     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
