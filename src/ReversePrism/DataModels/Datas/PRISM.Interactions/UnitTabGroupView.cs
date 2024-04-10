using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 040 RectViewPort                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 RectContent                              000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 VerticalLayoutGroup                      000186515B70 ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer
    // 058 onChangeUnit                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class UnitTabGroupView : DataModel
    {
        public ScrollRect?                              ScrollRect                              { get; set; }
        public RectTransform?                           RectViewPort                            { get; set; }
        public RectTransform?                           RectContent                             { get; set; }
        public VerticalLayoutGroup?                     VerticalLayoutGroup                     { get; set; }

        public static UnitTabGroupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitTabGroupView() { Pointer= p0 };

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466A284490 0x38 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.RectViewPort                              = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A2844B0 0x40 RectViewPort                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RectContent                               = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A2844D0 0x48 RectContent                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.VerticalLayoutGroup                       = GetObject<VerticalLayoutGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.VerticalLayoutGroup.FromPointer); // 02466A2844F0 0x50 VerticalLayoutGroup         ( 000186515B70 ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer )

            return value;
        }
    }
}
