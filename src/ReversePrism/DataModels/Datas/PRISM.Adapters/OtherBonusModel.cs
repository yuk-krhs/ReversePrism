using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 idolSkillLevels                          Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 018 DressUnlockPremiseStarList               000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 ViewModel                                0001866EED30 ModelClassType OtherBonusViewModel OtherBonusViewModel OtherBonusViewModel Pointer
    public partial class OtherBonusModel
    {
        public List<int>?                               DressUnlockPremiseStarList              { get; set; }
        public OtherBonusViewModel?                     ViewModel                               { get; set; }

        public static OtherBonusModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OtherBonusModel();

            value.DressUnlockPremiseStarList                = GetInt32List(new IntPtr(p + 0x018)); // 0270D5FC8E80 0x18 DressUnlockPremiseStarList  ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.ViewModel                                 = GetObject<OtherBonusViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.OtherBonusViewModel.FromPointer); // 0270D5FC8EA0 0x20 ViewModel                   ( 0001866EED30 ModelClassType OtherBonusViewModel OtherBonusViewModel OtherBonusViewModel Pointer )

            return value;
        }
    }
}
