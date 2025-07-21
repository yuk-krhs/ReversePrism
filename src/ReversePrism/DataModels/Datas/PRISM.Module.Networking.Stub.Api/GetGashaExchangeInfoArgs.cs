using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGashaExchangeInfoArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaExchangeIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 GashaExchangeId                          ModelPrimitiveType string string string String
    public partial class GetGashaExchangeInfoArgs : DataModel
    {
        public string                                   GashaExchangeId                         { get; set; }

        public static GetGashaExchangeInfoArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGashaExchangeInfoArgs() { Pointer= p0 };

            value.GashaExchangeId                           = GetString(new IntPtr(p + 0x018)); // 0x18 GashaExchangeId             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
