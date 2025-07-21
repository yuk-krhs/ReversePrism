using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LivePlayRewardPackStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LiveBonusRewardListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_liveBonusRewardList_codec      FieldCodec`1<LivePlayRewardStatus> IL2CPP_TYPE_GENERICINST
    // 018 LiveBonusRewardList                      ModelClassListType RepeatedField`1<LivePlayRewardStatus> RepeatedField`1<LivePlayRewardStatus> List<LivePlayRewardStatus> Pointer
    // 000 ClearRewardListFieldNumber               int IL2CPP_TYPE_I4
    // 010 _repeated_clearRewardList_codec          FieldCodec`1<LivePlayRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 ClearRewardList                          ModelClassListType RepeatedField`1<LivePlayRewardStatus> RepeatedField`1<LivePlayRewardStatus> List<LivePlayRewardStatus> Pointer
    // 000 ScoreRankRewardListFieldNumber           int IL2CPP_TYPE_I4
    // 018 _repeated_scoreRankRewardList_codec      FieldCodec`1<LivePlayRewardStatus> IL2CPP_TYPE_GENERICINST
    // 028 ScoreRankRewardList                      ModelClassListType RepeatedField`1<LivePlayRewardStatus> RepeatedField`1<LivePlayRewardStatus> List<LivePlayRewardStatus> Pointer
    // 000 OtherRewardListFieldNumber               int IL2CPP_TYPE_I4
    // 020 _repeated_otherRewardList_codec          FieldCodec`1<LivePlayRewardStatus> IL2CPP_TYPE_GENERICINST
    // 030 OtherRewardList                          ModelClassListType RepeatedField`1<LivePlayRewardStatus> RepeatedField`1<LivePlayRewardStatus> List<LivePlayRewardStatus> Pointer
    public partial class LivePlayRewardPackStatus : DataModel
    {
        public List<LivePlayRewardStatus>?              LiveBonusRewardList                     { get; set; }
        public List<LivePlayRewardStatus>?              ClearRewardList                         { get; set; }
        public List<LivePlayRewardStatus>?              ScoreRankRewardList                     { get; set; }
        public List<LivePlayRewardStatus>?              OtherRewardList                         { get; set; }

        public static LivePlayRewardPackStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LivePlayRewardPackStatus() { Pointer= p0 };

            value.LiveBonusRewardList                       = GetObjectList<LivePlayRewardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LivePlayRewardStatus.FromPointer); // 0x18 LiveBonusRewardList         ( ModelClassListType RepeatedField`1<LivePlayRewardStatus> RepeatedField`1<LivePlayRewardStatus> List<LivePlayRewardStatus> Pointer )
            value.ClearRewardList                           = GetObjectList<LivePlayRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LivePlayRewardStatus.FromPointer); // 0x20 ClearRewardList             ( ModelClassListType RepeatedField`1<LivePlayRewardStatus> RepeatedField`1<LivePlayRewardStatus> List<LivePlayRewardStatus> Pointer )
            value.ScoreRankRewardList                       = GetObjectList<LivePlayRewardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LivePlayRewardStatus.FromPointer); // 0x28 ScoreRankRewardList         ( ModelClassListType RepeatedField`1<LivePlayRewardStatus> RepeatedField`1<LivePlayRewardStatus> List<LivePlayRewardStatus> Pointer )
            value.OtherRewardList                           = GetObjectList<LivePlayRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LivePlayRewardStatus.FromPointer); // 0x30 OtherRewardList             ( ModelClassListType RepeatedField`1<LivePlayRewardStatus> RepeatedField`1<LivePlayRewardStatus> List<LivePlayRewardStatus> Pointer )

            return value;
        }
    }
}
