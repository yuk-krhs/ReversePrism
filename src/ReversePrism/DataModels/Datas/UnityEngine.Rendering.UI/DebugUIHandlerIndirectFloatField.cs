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
    // 070 getter                                   Func`1<float> IL2CPP_TYPE_GENERICINST
    // 078 setter                                   Action`1<float> IL2CPP_TYPE_GENERICINST
    // 080 incStepGetter                            Func`1<float> IL2CPP_TYPE_GENERICINST
    // 088 incStepMultGetter                        Func`1<float> IL2CPP_TYPE_GENERICINST
    // 090 decimalsGetter                           Func`1<float> IL2CPP_TYPE_GENERICINST
    public partial class DebugUIHandlerIndirectFloatField : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public Text?                                    ValueLabel                              { get; set; }

        public static DebugUIHandlerIndirectFloatField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerIndirectFloatField() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0x60 NameLabel                   ( ModelClassType Text Text Text Pointer )
            value.ValueLabel                                = GetObject<Text>(new IntPtr(p + 0x068), ReversePrism.DataModels.Text.FromPointer); // 0x68 ValueLabel                  ( ModelClassType Text Text Text Pointer )

            return value;
        }
    }
}
