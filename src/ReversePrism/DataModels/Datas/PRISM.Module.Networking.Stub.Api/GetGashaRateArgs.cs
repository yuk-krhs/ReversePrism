using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGashaRateArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 GashaId                                  000186671910 ModelPrimitiveType string string string String
    public partial class GetGashaRateArgs : DataModel
    {
        public string                                   GashaId                                 { get; set; }

        public static GetGashaRateArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGashaRateArgs() { Pointer= p0 };

            value.GashaId                                   = GetString(new IntPtr(p + 0x018)); // 0246619A44E8 0x18 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
