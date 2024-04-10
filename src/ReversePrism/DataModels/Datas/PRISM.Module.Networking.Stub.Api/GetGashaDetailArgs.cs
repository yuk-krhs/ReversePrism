using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGashaDetailArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 GashaId                                  000186671910 ModelPrimitiveType string string string String
    // 000 DetailIdListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_detailIdList_codec             FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 020 DetailIdList                             000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class GetGashaDetailArgs : DataModel
    {
        public string                                   GashaId                                 { get; set; }
        public List<string>?                            DetailIdList                            { get; set; }

        public static GetGashaDetailArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGashaDetailArgs() { Pointer= p0 };

            value.GashaId                                   = GetString(new IntPtr(p + 0x018)); // 02466199A018 0x18 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.DetailIdList                              = GetStringList(new IntPtr(p + 0x020)); // 02466199A078 0x20 DetailIdList                ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
