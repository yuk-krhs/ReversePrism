using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataListRefHeaderAndRow                  000185CE6458 ModelClassListType List`1<IMedalGashaRewardListData> List`1<IMedalGashaRewardListData> List<IMedalGashaRewardListData> Pointer
    // 000 ItemLimitPerRow                          int IL2CPP_TYPE_I4
    // 018 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 020 HasRemainFeatured                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 024 RemainCount                              0001865F4260 ModelPrimitiveType int int int Int32
    // 028 BoxNumber                                0001865F8300 ModelPrimitiveType long long long Int64
    // 030 IsLoop                                   0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class MedalGashaRewardAllListViewModel
    {
        public List<IMedalGashaRewardListData>?         DataListRefHeaderAndRow                 { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public bool                                     HasRemainFeatured                       { get; set; }
        public int                                      RemainCount                             { get; set; }
        public long                                     BoxNumber                               { get; set; }
        public bool                                     IsLoop                                  { get; set; }

        public static MedalGashaRewardAllListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardAllListViewModel();

            value.DataListRefHeaderAndRow                   = GetObjectList<IMedalGashaRewardListData>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMedalGashaRewardListData.FromPointer); // 0270D6292458 0x10 DataListRefHeaderAndRow     ( 000185CE6458 ModelClassListType List`1<IMedalGashaRewardListData> List`1<IMedalGashaRewardListData> List<IMedalGashaRewardListData> Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270D6292498 0x18 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.HasRemainFeatured                         = GetBool(new IntPtr(p + 0x020)); // 0270D62924B8 0x20 HasRemainFeatured           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.RemainCount                               = GetInt32(new IntPtr(p + 0x024)); // 0270D62924D8 0x24 RemainCount                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BoxNumber                                 = GetInt64(new IntPtr(p + 0x028)); // 0270D62924F8 0x28 BoxNumber                   ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.IsLoop                                    = GetBool(new IntPtr(p + 0x030)); // 0270D6292518 0x30 IsLoop                      ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
