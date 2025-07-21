using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Parent                                   ModelClassType Transform Transform Transform Pointer
    // 028 SkillViewPrefab                          ModelClassType AwakingIdolSkillView AwakingIdolSkillView AwakingIdolSkillView Pointer
    // 030 OnSelectedSkillId                        IObservable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillListView : DataModel
    {
        public Transform?                               Parent                                  { get; set; }
        public AwakingIdolSkillView?                    SkillViewPrefab                         { get; set; }

        public static IdolSkillListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillListView() { Pointer= p0 };

            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 Parent                      ( ModelClassType Transform Transform Transform Pointer )
            value.SkillViewPrefab                           = GetObject<AwakingIdolSkillView>(new IntPtr(p + 0x028), ReversePrism.DataModels.AwakingIdolSkillView.FromPointer); // 0x28 SkillViewPrefab             ( ModelClassType AwakingIdolSkillView AwakingIdolSkillView AwakingIdolSkillView Pointer )

            return value;
        }
    }
}
