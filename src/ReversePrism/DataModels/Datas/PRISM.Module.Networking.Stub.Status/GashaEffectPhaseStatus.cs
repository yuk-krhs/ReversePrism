using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaEffectPhaseStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 ValueListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_valueList_codec                FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 020 ValueList                                000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class GashaEffectPhaseStatus
    {
        public string                                   Name                                    { get; set; }
        public List<string>?                            ValueList                               { get; set; }

        public static GashaEffectPhaseStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaEffectPhaseStatus();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D1589748 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ValueList                                 = GetStringList(new IntPtr(p + 0x020)); // 0270D15897A8 0x20 ValueList                   ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
