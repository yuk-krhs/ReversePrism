using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SliderView                               ModelClassType ProduceStaminaUsageSliderView ProduceStaminaUsageSliderView ProduceStaminaUsageSliderView Pointer
    // 028 onClosed                                 Subject`1<ValueTuple`3<bool, int, bool>> IL2CPP_TYPE_GENERICINST
    // 030 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceStaminaUsagePopupView : DataModel
    {
        public ProduceStaminaUsageSliderView?           SliderView                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceStaminaUsagePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceStaminaUsagePopupView() { Pointer= p0 };

            value.SliderView                                = GetObject<ProduceStaminaUsageSliderView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceStaminaUsageSliderView.FromPointer); // 0x20 SliderView                  ( ModelClassType ProduceStaminaUsageSliderView ProduceStaminaUsageSliderView ProduceStaminaUsageSliderView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x30 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
