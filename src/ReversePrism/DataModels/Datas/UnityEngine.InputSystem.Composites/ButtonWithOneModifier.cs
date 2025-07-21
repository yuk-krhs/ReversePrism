using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Modifier                                 ModelPrimitiveType int int int Int32
    // 014 Button                                   ModelPrimitiveType int int int Int32
    // 018 OverrideModifiersNeedToBePressedFirst    ModelPrimitiveType bool bool bool Bool
    public partial class ButtonWithOneModifier : DataModel
    {
        public int                                      Modifier                                { get; set; }
        public int                                      Button                                  { get; set; }
        public bool                                     OverrideModifiersNeedToBePressedFirst   { get; set; }

        public static ButtonWithOneModifier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonWithOneModifier() { Pointer= p0 };

            value.Modifier                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 Modifier                    ( ModelPrimitiveType int int int Int32 )
            value.Button                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Button                      ( ModelPrimitiveType int int int Int32 )
            value.OverrideModifiersNeedToBePressedFirst     = GetBool(new IntPtr(p + 0x018)); // 0x18 OverrideModifiersNeedToBePressedFirst ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
