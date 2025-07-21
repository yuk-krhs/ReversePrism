using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 040 RectViewPort                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 RectContent                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 VerticalLayoutGroup                      ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer
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

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x38 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.RectViewPort                              = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 RectViewPort                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RectContent                               = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0x48 RectContent                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.VerticalLayoutGroup                       = GetObject<VerticalLayoutGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.VerticalLayoutGroup.FromPointer); // 0x50 VerticalLayoutGroup         ( ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer )

            return value;
        }
    }
}
