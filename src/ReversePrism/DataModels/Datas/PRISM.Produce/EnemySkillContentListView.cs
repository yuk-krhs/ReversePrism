using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 LeftArea                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 RightArea                                ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class EnemySkillContentListView : DataModel
    {
        public RectTransform?                           LeftArea                                { get; set; }
        public RectTransform?                           RightArea                               { get; set; }

        public static EnemySkillContentListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnemySkillContentListView() { Pointer= p0 };

            value.LeftArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 LeftArea                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RightArea                                 = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 RightArea                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
