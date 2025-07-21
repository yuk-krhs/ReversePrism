using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ContentArea                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 onSwipe                                  Subject`1<ValueTuple`2<int, SwipeState>> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillContentListView : DataModel
    {
        public RectTransform?                           ContentArea                             { get; set; }

        public static IdolSkillContentListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillContentListView() { Pointer= p0 };

            value.ContentArea                               = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 ContentArea                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
