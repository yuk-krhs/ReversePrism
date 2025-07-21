using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeLevelImage                         ModelClassType UIImage UIImage UIImage Pointer
    // 028 AfterLevelImage                          ModelClassType UIImage UIImage UIImage Pointer
    // 030 LevelUpAnimator                          ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    public partial class ScheduleLevelUpContent : DataModel
    {
        public UIImage?                                 BeforeLevelImage                        { get; set; }
        public UIImage?                                 AfterLevelImage                         { get; set; }
        public AnimatorWithEvent?                       LevelUpAnimator                         { get; set; }

        public static ScheduleLevelUpContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleLevelUpContent() { Pointer= p0 };

            value.BeforeLevelImage                          = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 BeforeLevelImage            ( ModelClassType UIImage UIImage UIImage Pointer )
            value.AfterLevelImage                           = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 AfterLevelImage             ( ModelClassType UIImage UIImage UIImage Pointer )
            value.LevelUpAnimator                           = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x30 LevelUpAnimator             ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )

            return value;
        }
    }
}
