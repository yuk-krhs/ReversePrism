using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JumpParam                                ModelClassType LiveOnlyProduceIdolUpgradingViewParameter LiveOnlyProduceIdolUpgradingViewParameter LiveOnlyProduceIdolUpgradingViewParameter Pointer
    public partial class LiveOnlyProduceIdolUpgradingArgument : DataModel
    {
        public LiveOnlyProduceIdolUpgradingViewParameter? JumpParam                               { get; set; }

        public static LiveOnlyProduceIdolUpgradingArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveOnlyProduceIdolUpgradingArgument() { Pointer= p0 };

            value.JumpParam                                 = GetObject<LiveOnlyProduceIdolUpgradingViewParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveOnlyProduceIdolUpgradingViewParameter.FromPointer); // 0x10 JumpParam                   ( ModelClassType LiveOnlyProduceIdolUpgradingViewParameter LiveOnlyProduceIdolUpgradingViewParameter LiveOnlyProduceIdolUpgradingViewParameter Pointer )

            return value;
        }
    }
}
