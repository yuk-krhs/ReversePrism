using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentRank                              ModelPrimitiveType int int int Int32
    // 018 SeasonRewardList                         ModelClassListType List`1<SeasonReward> List`1<SeasonReward> List<SeasonReward> Pointer
    // 020 IsPremumUnLock                           ModelPrimitiveType bool bool bool Bool
    // 024 LockBeginRank                            ModelPrimitiveType int int int Int32
    // 028 LockEndRank                              ModelPrimitiveType int int int Int32
    // 02C IsRewardExplanation                      ModelPrimitiveType bool bool bool Bool
    public partial class SeasonMissionRewardListViewModel : DataModel
    {
        public int                                      CurrentRank                             { get; set; }
        public List<SeasonReward>?                      SeasonRewardList                        { get; set; }
        public bool                                     IsPremumUnLock                          { get; set; }
        public int                                      LockBeginRank                           { get; set; }
        public int                                      LockEndRank                             { get; set; }
        public bool                                     IsRewardExplanation                     { get; set; }

        public static SeasonMissionRewardListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionRewardListViewModel() { Pointer= p0 };

            value.CurrentRank                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 CurrentRank                 ( ModelPrimitiveType int int int Int32 )
            value.SeasonRewardList                          = GetObjectList<SeasonReward>(new IntPtr(p + 0x018), ReversePrism.DataModels.SeasonReward.FromPointer); // 0x18 SeasonRewardList            ( ModelClassListType List`1<SeasonReward> List`1<SeasonReward> List<SeasonReward> Pointer )
            value.IsPremumUnLock                            = GetBool(new IntPtr(p + 0x020)); // 0x20 IsPremumUnLock              ( ModelPrimitiveType bool bool bool Bool )
            value.LockBeginRank                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 LockBeginRank               ( ModelPrimitiveType int int int Int32 )
            value.LockEndRank                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 LockEndRank                 ( ModelPrimitiveType int int int Int32 )
            value.IsRewardExplanation                       = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsRewardExplanation         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
