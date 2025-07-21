using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dish                                     ModelClassType FrameRateDish FrameRateDish FrameRateDish Pointer
    // 000 stack                                    ActivationStack`1<FrameRateDish> IL2CPP_TYPE_GENERICINST
    public partial class FrameRateScope : DataModel
    {
        public FrameRateDish?                           Dish                                    { get; set; }

        public static FrameRateScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameRateScope() { Pointer= p0 };

            value.Dish                                      = GetObject<FrameRateDish>(new IntPtr(p + 0x010), ReversePrism.DataModels.FrameRateDish.FromPointer); // 0x10 Dish                        ( ModelClassType FrameRateDish FrameRateDish FrameRateDish Pointer )

            return value;
        }
    }
}
