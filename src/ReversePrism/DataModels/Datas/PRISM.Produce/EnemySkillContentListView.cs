using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 LeftArea                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 RightArea                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class EnemySkillContentListView
    {
        public RectTransform?                           LeftArea                                { get; set; }
        public RectTransform?                           RightArea                               { get; set; }

        public static EnemySkillContentListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnemySkillContentListView();

            value.LeftArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5B08E60 0x30 LeftArea                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RightArea                                 = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5B08E80 0x38 RightArea                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
