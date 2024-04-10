using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiSafeArea                               0001866F2010 ModelClassType UISafeArea UISafeArea UISafeArea Pointer
    // 028 RectMarginObj                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 RectCenteringReferenceObjInMargin        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class CenteringObjectsOutsideSafeArea : DataModel
    {
        public UISafeArea?                              UiSafeArea                              { get; set; }
        public RectTransform?                           RectMarginObj                           { get; set; }
        public RectTransform?                           RectCenteringReferenceObjInMargin       { get; set; }

        public static CenteringObjectsOutsideSafeArea? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CenteringObjectsOutsideSafeArea() { Pointer= p0 };

            value.UiSafeArea                                = GetObject<UISafeArea>(new IntPtr(p + 0x020), ReversePrism.DataModels.UISafeArea.FromPointer); // 024665476D18 0x20 UiSafeArea                  ( 0001866F2010 ModelClassType UISafeArea UISafeArea UISafeArea Pointer )
            value.RectMarginObj                             = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 024665476D38 0x28 RectMarginObj               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RectCenteringReferenceObjInMargin         = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 024665476D58 0x30 RectCenteringReferenceObjInMargin ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
