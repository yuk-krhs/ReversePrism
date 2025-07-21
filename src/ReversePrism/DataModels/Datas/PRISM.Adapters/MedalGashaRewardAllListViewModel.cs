using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataListRefHeaderAndRow                  ModelClassListType List`1<IMedalGashaRewardListData> List`1<IMedalGashaRewardListData> List<IMedalGashaRewardListData> Pointer
    // 000 ItemLimitPerRow                          int IL2CPP_TYPE_I4
    // 018 HasRemainFeatured                        ModelPrimitiveType bool bool bool Bool
    // 01C RemainCount                              ModelPrimitiveType int int int Int32
    public partial class MedalGashaRewardAllListViewModel : DataModel
    {
        public List<IMedalGashaRewardListData>?         DataListRefHeaderAndRow                 { get; set; }
        public bool                                     HasRemainFeatured                       { get; set; }
        public int                                      RemainCount                             { get; set; }

        public static MedalGashaRewardAllListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardAllListViewModel() { Pointer= p0 };

            value.DataListRefHeaderAndRow                   = GetObjectList<IMedalGashaRewardListData>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMedalGashaRewardListData.FromPointer); // 0x10 DataListRefHeaderAndRow     ( ModelClassListType List`1<IMedalGashaRewardListData> List`1<IMedalGashaRewardListData> List<IMedalGashaRewardListData> Pointer )
            value.HasRemainFeatured                         = GetBool(new IntPtr(p + 0x018)); // 0x18 HasRemainFeatured           ( ModelPrimitiveType bool bool bool Bool )
            value.RemainCount                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C RemainCount                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
