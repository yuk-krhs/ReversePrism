using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleButtonGroup                        000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 onClosed                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 030 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class RecommendSupportCharacterPopupView
    {
        public ToggleButtonGroup?                       ToggleButtonGroup                       { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static RecommendSupportCharacterPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecommendSupportCharacterPopupView();

            value.ToggleButtonGroup                         = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270DA12D468 0x20 ToggleButtonGroup           ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA12D4A8 0x30 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
