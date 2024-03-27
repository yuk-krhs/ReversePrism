using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 018 DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 ScoreRankRewardListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_scoreRankRewardList_codec      FieldCodec`1<ScoreRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 ScoreRankRewardList                      000185CEFCB8 ModelClassListType RepeatedField`1<ScoreRankRewardStatus> RepeatedField`1<ScoreRankRewardStatus> List<ScoreRankRewardStatus> Pointer
    // 000 ComboRankRewardListFieldNumber           int IL2CPP_TYPE_I4
    // 010 _repeated_comboRankRewardList_codec      FieldCodec`1<ComboRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 028 ComboRankRewardList                      000185CD2078 ModelClassListType RepeatedField`1<ComboRankRewardStatus> RepeatedField`1<ComboRankRewardStatus> List<ComboRankRewardStatus> Pointer
    public partial class RankRewardStatus
    {
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public List<ScoreRankRewardStatus>?             ScoreRankRewardList                     { get; set; }
        public List<ComboRankRewardStatus>?             ComboRankRewardList                     { get; set; }

        public static RankRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankRewardStatus();

            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0270D136C6F8 0x18 DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.ScoreRankRewardList                       = GetObjectList<ScoreRankRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScoreRankRewardStatus.FromPointer); // 0270D136C758 0x20 ScoreRankRewardList         ( 000185CEFCB8 ModelClassListType RepeatedField`1<ScoreRankRewardStatus> RepeatedField`1<ScoreRankRewardStatus> List<ScoreRankRewardStatus> Pointer )
            value.ComboRankRewardList                       = GetObjectList<ComboRankRewardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ComboRankRewardStatus.FromPointer); // 0270D136C7B8 0x28 ComboRankRewardList         ( 000185CD2078 ModelClassListType RepeatedField`1<ComboRankRewardStatus> RepeatedField`1<ComboRankRewardStatus> List<ComboRankRewardStatus> Pointer )

            return value;
        }
    }
}
