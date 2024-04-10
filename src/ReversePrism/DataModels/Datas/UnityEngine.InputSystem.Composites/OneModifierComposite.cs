using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Modifier                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Binding                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 OverrideModifiersNeedToBePressedFirst    000186595960 ModelPrimitiveType bool bool bool Bool
    // 01C M_ValueSizeInBytes                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_ValueType                              000186692850 ModelClassType Type Type Type Pointer
    // 028 M_BindingIsButton                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class OneModifierComposite : DataModel
    {
        public int                                      Modifier                                { get; set; }
        public int                                      Binding                                 { get; set; }
        public bool                                     OverrideModifiersNeedToBePressedFirst   { get; set; }
        public int                                      M_ValueSizeInBytes                      { get; set; }
        public Type?                                    M_ValueType                             { get; set; }
        public bool                                     M_BindingIsButton                       { get; set; }

        public static OneModifierComposite? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OneModifierComposite() { Pointer= p0 };

            value.Modifier                                  = GetInt32(new IntPtr(p + 0x010)); // 0246679460C0 0x10 Modifier                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Binding                                   = GetInt32(new IntPtr(p + 0x014)); // 0246679460E0 0x14 Binding                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OverrideModifiersNeedToBePressedFirst     = GetBool(new IntPtr(p + 0x018)); // 024667946100 0x18 OverrideModifiersNeedToBePressedFirst ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_ValueSizeInBytes                        = GetInt32(new IntPtr(p + 0x01C)); // 024667946120 0x1C M_ValueSizeInBytes          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ValueType                               = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 024667946140 0x20 M_ValueType                 ( 000186692850 ModelClassType Type Type Type Pointer )
            value.M_BindingIsButton                         = GetBool(new IntPtr(p + 0x028)); // 024667946160 0x28 M_BindingIsButton           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
