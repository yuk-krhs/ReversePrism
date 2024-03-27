using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SliderView                               0001865829A0 ModelClassType ProduceStaminaUsageSliderView ProduceStaminaUsageSliderView ProduceStaminaUsageSliderView Pointer
    // 028 onClosed                                 Subject`1<ValueTuple`3<bool, int, bool>> IL2CPP_TYPE_GENERICINST
    // 030 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceStaminaUsagePopupView
    {
        public ProduceStaminaUsageSliderView?           SliderView                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceStaminaUsagePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceStaminaUsagePopupView();

            value.SliderView                                = GetObject<ProduceStaminaUsageSliderView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceStaminaUsageSliderView.FromPointer); // 0270DA115D70 0x20 SliderView                  ( 0001865829A0 ModelClassType ProduceStaminaUsageSliderView ProduceStaminaUsageSliderView ProduceStaminaUsageSliderView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA115DB0 0x30 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
