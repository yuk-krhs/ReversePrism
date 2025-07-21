using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Modifier                                 ModelPrimitiveType int int int Int32
    // 014 Binding                                  ModelPrimitiveType int int int Int32
    // 018 OverrideModifiersNeedToBePressedFirst    ModelPrimitiveType bool bool bool Bool
    // 01C M_ValueSizeInBytes                       ModelPrimitiveType int int int Int32
    // 020 M_ValueType                              ModelClassType Type Type Type Pointer
    // 028 M_BindingIsButton                        ModelPrimitiveType bool bool bool Bool
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

            value.Modifier                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 Modifier                    ( ModelPrimitiveType int int int Int32 )
            value.Binding                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 Binding                     ( ModelPrimitiveType int int int Int32 )
            value.OverrideModifiersNeedToBePressedFirst     = GetBool(new IntPtr(p + 0x018)); // 0x18 OverrideModifiersNeedToBePressedFirst ( ModelPrimitiveType bool bool bool Bool )
            value.M_ValueSizeInBytes                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_ValueSizeInBytes          ( ModelPrimitiveType int int int Int32 )
            value.M_ValueType                               = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 M_ValueType                 ( ModelClassType Type Type Type Pointer )
            value.M_BindingIsButton                         = GetBool(new IntPtr(p + 0x028)); // 0x28 M_BindingIsButton           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
