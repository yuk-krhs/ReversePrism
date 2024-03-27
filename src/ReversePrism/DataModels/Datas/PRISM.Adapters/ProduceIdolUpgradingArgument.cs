using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JumpParam                                000186556190 ModelClassType ProduceIdolUpgradingViewParameter ProduceIdolUpgradingViewParameter ProduceIdolUpgradingViewParameter Pointer
    public partial class ProduceIdolUpgradingArgument
    {
        public ProduceIdolUpgradingViewParameter?       JumpParam                               { get; set; }

        public static ProduceIdolUpgradingArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolUpgradingArgument();

            value.JumpParam                                 = GetObject<ProduceIdolUpgradingViewParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceIdolUpgradingViewParameter.FromPointer); // 0270D5FC9770 0x10 JumpParam                   ( 000186556190 ModelClassType ProduceIdolUpgradingViewParameter ProduceIdolUpgradingViewParameter ProduceIdolUpgradingViewParameter Pointer )

            return value;
        }
    }
}
