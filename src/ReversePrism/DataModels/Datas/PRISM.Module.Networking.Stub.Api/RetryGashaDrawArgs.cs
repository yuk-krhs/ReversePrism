using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RetryGashaDrawArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 GashaId                                  000186671910 ModelPrimitiveType string string string String
    // 000 GashaPriceIdFieldNumber                  int IL2CPP_TYPE_I4
    // 020 GashaPriceId                             000186671910 ModelPrimitiveType string string string String
    public partial class RetryGashaDrawArgs : DataModel
    {
        public string                                   GashaId                                 { get; set; }
        public string                                   GashaPriceId                            { get; set; }

        public static RetryGashaDrawArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RetryGashaDrawArgs() { Pointer= p0 };

            value.GashaId                                   = GetString(new IntPtr(p + 0x018)); // 0246619B2100 0x18 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaPriceId                              = GetString(new IntPtr(p + 0x020)); // 0246619B2140 0x20 GashaPriceId                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
