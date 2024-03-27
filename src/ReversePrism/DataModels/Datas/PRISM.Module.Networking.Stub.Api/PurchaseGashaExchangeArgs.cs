using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PurchaseGashaExchangeArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaExchangeRewardIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 GashaExchangeRewardId                    000186671910 ModelPrimitiveType string string string String
    public partial class PurchaseGashaExchangeArgs
    {
        public string                                   GashaExchangeRewardId                   { get; set; }

        public static PurchaseGashaExchangeArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseGashaExchangeArgs();

            value.GashaExchangeRewardId                     = GetString(new IntPtr(p + 0x018)); // 0270D1A1EE98 0x18 GashaExchangeRewardId       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
