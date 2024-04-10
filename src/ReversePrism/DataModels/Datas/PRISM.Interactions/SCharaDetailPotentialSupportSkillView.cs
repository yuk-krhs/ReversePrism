using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoContent                                000186770FA0 ModelClassType PotentialSupportSkillContentView PotentialSupportSkillContentView PotentialSupportSkillContentView Pointer
    // 030 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
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

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A399BA0 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoContent                                 = GetObject<PotentialSupportSkillContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PotentialSupportSkillContentView.FromPointer); // 02466A399BC0 0x28 GoContent                   ( 000186770FA0 ModelClassType PotentialSupportSkillContentView PotentialSupportSkillContentView PotentialSupportSkillContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466A399BE0 0x30 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
