using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SliderView                               ModelClassType LiveBonusUsageSliderView LiveBonusUsageSliderView LiveBonusUsageSliderView Pointer
    // 028 ZeroUsageAnnotation                      ModelClassType GameObject GameObject GameObject Pointer
    // 030 ZeroUnselectableAnnotation               ModelClassType GameObject GameObject GameObject Pointer
    // 038 onSliderValueChanged                     Action`1<int> IL2CPP_TYPE_GENERICINST
    // 040 onClick                                  Subject`1<ValueTuple`3<bool, int, bool>> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LiveBonusUsageSettingPopupView : DataModel
    {
        public LiveBonusUsageSliderView?                SliderView                              { get; set; }
        public GameObject?                              ZeroUsageAnnotation                     { get; set; }
        public GameObject?                              ZeroUnselectableAnnotation              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveBonusUsageSettingPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveBonusUsageSettingPopupView() { Pointer= p0 };

            value.SliderView                                = GetObject<LiveBonusUsageSliderView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveBonusUsageSliderView.FromPointer); // 0x20 SliderView                  ( ModelClassType LiveBonusUsageSliderView LiveBonusUsageSliderView LiveBonusUsageSliderView Pointer )
            value.ZeroUsageAnnotation                       = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ZeroUsageAnnotation         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ZeroUnselectableAnnotation                = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 ZeroUnselectableAnnotation  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
