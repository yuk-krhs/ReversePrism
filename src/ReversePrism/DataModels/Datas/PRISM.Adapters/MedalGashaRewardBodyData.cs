using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsFeatured                               ModelPrimitiveType bool bool bool Bool
    // 018 Items                                    ModelClassListType IReadOnlyList`1<IMedalGashaRewardStatus> IReadOnlyList`1<IMedalGashaRewardStatus> List<IMedalGashaRewardStatus> Pointer
    public partial class MedalGashaRewardBodyData : DataModel
    {
        public bool                                     IsFeatured                              { get; set; }
        public List<IMedalGashaRewardStatus>?           Items                                   { get; set; }

        public static MedalGashaRewardBodyData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardBodyData() { Pointer= p0 };

            value.IsFeatured                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IsFeatured                  ( ModelPrimitiveType bool bool bool Bool )
            value.Items                                     = GetObjectList<IMedalGashaRewardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMedalGashaRewardStatus.FromPointer); // 0x18 Items                       ( ModelClassListType IReadOnlyList`1<IMedalGashaRewardStatus> IReadOnlyList`1<IMedalGashaRewardStatus> List<IMedalGashaRewardStatus> Pointer )

            return value;
        }
    }
}
