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
    // 018 Binding                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C OverrideModifiersNeedToBePressedFirst    000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 M_ValueSizeInBytes                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_ValueType                              000186692850 ModelClassType Type Type Type Pointer
    // 030 M_BindingIsButton                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TwoModifiersComposite : DataModel
    {
        public int                                      Modifier1                               { get; set; }
        public int                                      Modifier2                               { get; set; }
        public int                                      Binding                                 { get; set; }
        public bool                                     OverrideModifiersNeedToBePressedFirst   { get; set; }
        public int                                      M_ValueSizeInBytes                      { get; set; }
        public Type?                                    M_ValueType                             { get; set; }
        public bool                                     M_BindingIsButton                       { get; set; }

        public static TwoModifiersComposite? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwoModifiersComposite() { Pointer= p0 };

            value.Modifier1                                 = GetInt32(new IntPtr(p + 0x010)); // 024667946590 0x10 Modifier1                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Modifier2                                 = GetInt32(new IntPtr(p + 0x014)); // 0246679465B0 0x14 Modifier2                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Binding                                   = GetInt32(new IntPtr(p + 0x018)); // 0246679465D0 0x18 Binding                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OverrideModifiersNeedToBePressedFirst     = GetBool(new IntPtr(p + 0x01C)); // 0246679465F0 0x1C OverrideModifiersNeedToBePressedFirst ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_ValueSizeInBytes                        = GetInt32(new IntPtr(p + 0x020)); // 024667946610 0x20 M_ValueSizeInBytes          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ValueType                               = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 024667946630 0x28 M_ValueType                 ( 000186692850 ModelClassType Type Type Type Pointer )
            value.M_BindingIsButton                         = GetBool(new IntPtr(p + 0x030)); // 024667946650 0x30 M_BindingIsButton           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
