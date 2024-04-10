using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                0001866320F0 ModelClassType Text Text Text Pointer
    // 068 ValueLabel                               0001866320F0 ModelClassType Text Text Text Pointer
    // 070 M_Field                                  00018658A740 ModelClassType ValueTuple ValueTuple ValueTuple Pointer
    // 078 ValueElements                            000185CAA768 ModelClassListType Text[] Text[] List<Text> Pointer
    // 000 k_XOffset                                float IL2CPP_TYPE_R4
    // 080 M_Timer                                  0001866656B0 ModelPrimitiveType float float float Single
    // 000 k_ZeroColor                              Color IL2CPP_TYPE_VALUETYPE
    public partial class DebugUIHandlerValueTuple : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public Text?                                    ValueLabel                              { get; set; }
        public ValueTuple?                              M_Field                                 { get; set; }
        public List<Text>?                              ValueElements                           { get; set; }
        public float                                    M_Timer                                 { get; set; }

        public static DebugUIHandlerValueTuple? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerValueTuple() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 02466939CFC0 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.ValueLabel                                = GetObject<Text>(new IntPtr(p + 0x068), ReversePrism.DataModels.Text.FromPointer); // 02466939CFE0 0x68 ValueLabel                  ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.M_Field                                   = GetObject<ValueTuple>(new IntPtr(p + 0x070), ReversePrism.DataModels.ValueTuple.FromPointer); // 02466939D000 0x70 M_Field                     ( 00018658A740 ModelClassType ValueTuple ValueTuple ValueTuple Pointer )
            value.ValueElements                             = GetObjectList<Text>(new IntPtr(p + 0x078), ReversePrism.DataModels.Text.FromPointer); // 02466939D020 0x78 ValueElements               ( 000185CAA768 ModelClassListType Text[] Text[] List<Text> Pointer )
            value.M_Timer                                   = GetSingle(new IntPtr(p + 0x080)); // 02466939D060 0x80 M_Timer                     ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
