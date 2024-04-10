using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ContentArea                              000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class IdolSkillContentListView : DataModel
    {
        public RectTransform?                           ContentArea                             { get; set; }

        public static IdolSkillContentListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillContentListView() { Pointer= p0 };

            value.ContentArea                               = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 024665C3DF38 0x30 ContentArea                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
