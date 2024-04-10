using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoContent                                0001866BEB00 ModelClassType IdolSkillLvContentView IdolSkillLvContentView IdolSkillLvContentView Pointer
    // 030 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 <OnIdolSkillDetail>k__BackingField       IObservable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class PIdolDetailIdolSkillView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public IdolSkillLvContentView?                  GoContent                               { get; set; }
        public Transform?                               ContentParent                           { get; set; }

        public static PIdolDetailIdolSkillView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailIdolSkillView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A359438 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoContent                                 = GetObject<IdolSkillLvContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillLvContentView.FromPointer); // 02466A359458 0x28 GoContent                   ( 0001866BEB00 ModelClassType IdolSkillLvContentView IdolSkillLvContentView IdolSkillLvContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466A359478 0x30 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
