using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Modifier1                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Modifier2                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Button                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C OverrideModifiersNeedToBePressedFirst    000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class ButtonWithTwoModifiers
    {
        public int                                      Modifier1                               { get; set; }
        public int                                      Modifier2                               { get; set; }
        public int                                      Button                                  { get; set; }
        public bool                                     OverrideModifiersNeedToBePressedFirst   { get; set; }

        public static ButtonWithTwoModifiers? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonWithTwoModifiers();

            value.Modifier1                                 = GetInt32(new IntPtr(p + 0x010)); // 0270D78D5E40 0x10 Modifier1                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Modifier2                                 = GetInt32(new IntPtr(p + 0x014)); // 0270D78D5E60 0x14 Modifier2                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Button                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D78D5E80 0x18 Button                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OverrideModifiersNeedToBePressedFirst     = GetBool(new IntPtr(p + 0x01C)); // 0270D78D5EA0 0x1C OverrideModifiersNeedToBePressedFirst ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
