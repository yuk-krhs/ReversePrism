using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RevertGashaExchangePointArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaExchangeIdListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_gashaExchangeIdList_codec      FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 GashaExchangeIdList                      000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class RevertGashaExchangePointArgs
    {
        public List<string>?                            GashaExchangeIdList                     { get; set; }

        public static RevertGashaExchangePointArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RevertGashaExchangePointArgs();

            value.GashaExchangeIdList                       = GetStringList(new IntPtr(p + 0x018)); // 0270D1A231C0 0x18 GashaExchangeIdList         ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
