using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                ModelClassType Text Text Text Pointer
    // 068 ValueLabel                               ModelClassType Text Text Text Pointer
    // 070 M_Field                                  ModelClassType UIntField UIntField UIntField Pointer
    public partial class DebugUIHandlerUIntField : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public Text?                                    ValueLabel                              { get; set; }
        public UIntField?                               M_Field                                 { get; set; }

        public static DebugUIHandlerUIntField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerUIntField() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0x60 NameLabel                   ( ModelClassType Text Text Text Pointer )
            value.ValueLabel                                = GetObject<Text>(new IntPtr(p + 0x068), ReversePrism.DataModels.Text.FromPointer); // 0x68 ValueLabel                  ( ModelClassType Text Text Text Pointer )
            value.M_Field                                   = GetObject<UIntField>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIntField.FromPointer); // 0x70 M_Field                     ( ModelClassType UIntField UIntField UIntField Pointer )

            return value;
        }
    }
}
