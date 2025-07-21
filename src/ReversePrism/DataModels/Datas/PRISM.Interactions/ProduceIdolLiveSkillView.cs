using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoPotentialLiveSkillContentViewPrefab    ModelClassType PotentialLiveSkillContentView PotentialLiveSkillContentView PotentialLiveSkillContentView Pointer
    // 030 ContentParent                            ModelClassType Transform Transform Transform Pointer
    // 038 onLiveSkillDetail                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ProduceIdolLiveSkillView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public PotentialLiveSkillContentView?           GoPotentialLiveSkillContentViewPrefab   { get; set; }
        public Transform?                               ContentParent                           { get; set; }

        public static ProduceIdolLiveSkillView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolLiveSkillView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoPotentialLiveSkillContentViewPrefab     = GetObject<PotentialLiveSkillContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PotentialLiveSkillContentView.FromPointer); // 0x28 GoPotentialLiveSkillContentViewPrefab ( ModelClassType PotentialLiveSkillContentView PotentialLiveSkillContentView PotentialLiveSkillContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 ContentParent               ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
