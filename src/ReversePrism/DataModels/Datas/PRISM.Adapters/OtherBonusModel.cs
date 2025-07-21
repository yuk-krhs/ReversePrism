using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 idolSkillLevels                          Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 018 DressUnlockPremiseStarList               ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 ViewModel                                ModelClassType OtherBonusViewModel OtherBonusViewModel OtherBonusViewModel Pointer
    // 028 LiveOnly                                 ModelPrimitiveType bool bool bool Bool
    public partial class OtherBonusModel : DataModel
    {
        public List<int>?                               DressUnlockPremiseStarList              { get; set; }
        public OtherBonusViewModel?                     ViewModel                               { get; set; }
        public bool                                     LiveOnly                                { get; set; }

        public static OtherBonusModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OtherBonusModel() { Pointer= p0 };

            value.DressUnlockPremiseStarList                = GetInt32List(new IntPtr(p + 0x018)); // 0x18 DressUnlockPremiseStarList  ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.ViewModel                                 = GetObject<OtherBonusViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.OtherBonusViewModel.FromPointer); // 0x20 ViewModel                   ( ModelClassType OtherBonusViewModel OtherBonusViewModel OtherBonusViewModel Pointer )
            value.LiveOnly                                  = GetBool(new IntPtr(p + 0x028)); // 0x28 LiveOnly                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
