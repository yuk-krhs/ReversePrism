using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsFeatured                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 Items                                    000185D133D8 ModelClassListType IReadOnlyList`1<MedalGashaRewardItemData> IReadOnlyList`1<MedalGashaRewardItemData> List<MedalGashaRewardItemData> Pointer
    // 020 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class MedalGashaRewardBodyData
    {
        public bool                                     IsFeatured                              { get; set; }
        public List<MedalGashaRewardItemData>?          Items                                   { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static MedalGashaRewardBodyData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardBodyData();

            value.IsFeatured                                = GetBool(new IntPtr(p + 0x010)); // 0270D629E6D0 0x10 IsFeatured                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Items                                     = GetObjectList<MedalGashaRewardItemData>(new IntPtr(p + 0x018), ReversePrism.DataModels.MedalGashaRewardItemData.FromPointer); // 0270D629E6F0 0x18 Items                       ( 000185D133D8 ModelClassListType IReadOnlyList`1<MedalGashaRewardItemData> IReadOnlyList`1<MedalGashaRewardItemData> List<MedalGashaRewardItemData> Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x020), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270D629E710 0x20 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
