using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Parent                                   0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 SkillViewPrefab                          00018672F210 ModelClassType AwakingIdolSkillView AwakingIdolSkillView AwakingIdolSkillView Pointer
    // 030 OnSelectedSkillId                        IObservable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillListView
    {
        public Transform?                               Parent                                  { get; set; }
        public AwakingIdolSkillView?                    SkillViewPrefab                         { get; set; }

        public static IdolSkillListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillListView();

            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270DA345A68 0x20 Parent                      ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.SkillViewPrefab                           = GetObject<AwakingIdolSkillView>(new IntPtr(p + 0x028), ReversePrism.DataModels.AwakingIdolSkillView.FromPointer); // 0270DA345A88 0x28 SkillViewPrefab             ( 00018672F210 ModelClassType AwakingIdolSkillView AwakingIdolSkillView AwakingIdolSkillView Pointer )

            return value;
        }
    }
}
