using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentRank                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 SeasonRewardList                         000185D06FF8 ModelClassListType List`1<SeasonReward> List`1<SeasonReward> List<SeasonReward> Pointer
    // 020 IsPremumUnLock                           0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 024 LockBeginRank                            0001865F4260 ModelPrimitiveType int int int Int32
    // 028 LockEndRank                              0001865F4260 ModelPrimitiveType int int int Int32
    // 02C IsRewardExplanation                      0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class SeasonMissionRewardListViewModel
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
            var value   = new SeasonMissionRewardListViewModel();

            value.CurrentRank                               = GetInt32(new IntPtr(p + 0x010)); // 0270D66BD8A8 0x10 CurrentRank                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SeasonRewardList                          = GetObjectList<SeasonReward>(new IntPtr(p + 0x018), ReversePrism.DataModels.SeasonReward.FromPointer); // 0270D66BD8C8 0x18 SeasonRewardList            ( 000185D06FF8 ModelClassListType List`1<SeasonReward> List`1<SeasonReward> List<SeasonReward> Pointer )
            value.IsPremumUnLock                            = GetBool(new IntPtr(p + 0x020)); // 0270D66BD8E8 0x20 IsPremumUnLock              ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.LockBeginRank                             = GetInt32(new IntPtr(p + 0x024)); // 0270D66BD908 0x24 LockBeginRank               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LockEndRank                               = GetInt32(new IntPtr(p + 0x028)); // 0270D66BD928 0x28 LockEndRank                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsRewardExplanation                       = GetBool(new IntPtr(p + 0x02C)); // 0270D66BD948 0x2C IsRewardExplanation         ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
