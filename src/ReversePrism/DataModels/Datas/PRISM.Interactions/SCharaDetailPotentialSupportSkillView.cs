using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoContent                                ModelClassType PotentialSupportSkillContentView PotentialSupportSkillContentView PotentialSupportSkillContentView Pointer
    // 030 ContentParent                            ModelClassType Transform Transform Transform Pointer
    public partial class SCharaDetailPotentialSupportSkillView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public PotentialSupportSkillContentView?        GoContent                               { get; set; }
        public Transform?                               ContentParent                           { get; set; }

        public static SCharaDetailPotentialSupportSkillView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaDetailPotentialSupportSkillView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoContent                                 = GetObject<PotentialSupportSkillContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PotentialSupportSkillContentView.FromPointer); // 0x28 GoContent                   ( ModelClassType PotentialSupportSkillContentView PotentialSupportSkillContentView PotentialSupportSkillContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 ContentParent               ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
