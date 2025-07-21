using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Modifier1                                ModelPrimitiveType int int int Int32
    // 014 Modifier2                                ModelPrimitiveType int int int Int32
    // 018 Button                                   ModelPrimitiveType int int int Int32
    // 01C OverrideModifiersNeedToBePressedFirst    ModelPrimitiveType bool bool bool Bool
    public partial class ButtonWithTwoModifiers : DataModel
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
            var value   = new ButtonWithTwoModifiers() { Pointer= p0 };

            value.Modifier1                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 Modifier1                   ( ModelPrimitiveType int int int Int32 )
            value.Modifier2                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 Modifier2                   ( ModelPrimitiveType int int int Int32 )
            value.Button                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Button                      ( ModelPrimitiveType int int int Int32 )
            value.OverrideModifiersNeedToBePressedFirst     = GetBool(new IntPtr(p + 0x01C)); // 0x1C OverrideModifiersNeedToBePressedFirst ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
