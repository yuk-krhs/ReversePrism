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
    // 070 M_Field                                  000186589F70 ModelClassType Value Value Value Pointer
    // 078 M_Timer                                  000186665DE0 ModelPrimitiveType float float float Single
    // 000 k_ZeroColor                              Color IL2CPP_TYPE_VALUETYPE
    public partial class DebugUIHandlerValue
    {
        public Text?                                    NameLabel                               { get; set; }
        public Text?                                    ValueLabel                              { get; set; }
        public Value?                                   M_Field                                 { get; set; }
        public float                                    M_Timer                                 { get; set; }

        public static DebugUIHandlerValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerValue();

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0270D93379F8 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.ValueLabel                                = GetObject<Text>(new IntPtr(p + 0x068), ReversePrism.DataModels.Text.FromPointer); // 0270D9337A18 0x68 ValueLabel                  ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.M_Field                                   = GetObject<Value>(new IntPtr(p + 0x070), ReversePrism.DataModels.Value.FromPointer); // 0270D9337A38 0x70 M_Field                     ( 000186589F70 ModelClassType Value Value Value Pointer )
            value.M_Timer                                   = GetSingle(new IntPtr(p + 0x078)); // 0270D9337A58 0x78 M_Timer                     ( 000186665DE0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
