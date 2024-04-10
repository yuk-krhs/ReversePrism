using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoContent                                00018676F3B0 ModelClassType PotentialLiveSkillContentView PotentialLiveSkillContentView PotentialLiveSkillContentView Pointer
    // 030 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 onLiveSkillDetail                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class PIdolDetailPotentialLiveSkillView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public PotentialLiveSkillContentView?           GoContent                               { get; set; }
        public Transform?                               ContentParent                           { get; set; }

        public static PIdolDetailPotentialLiveSkillView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailPotentialLiveSkillView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A359EF8 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoContent                                 = GetObject<PotentialLiveSkillContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PotentialLiveSkillContentView.FromPointer); // 02466A359F18 0x28 GoContent                   ( 00018676F3B0 ModelClassType PotentialLiveSkillContentView PotentialLiveSkillContentView PotentialLiveSkillContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466A359F38 0x30 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
