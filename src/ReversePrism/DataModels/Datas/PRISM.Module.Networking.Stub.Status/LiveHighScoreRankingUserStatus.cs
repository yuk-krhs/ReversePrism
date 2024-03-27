using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveHighScoreRankingUserStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HighScoreFieldNumber                     int IL2CPP_TYPE_I4
    // 01C HighScore                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TotalPowerFieldNumber                    int IL2CPP_TYPE_I4
    // 020 TotalPower                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IdolListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_idolList_codec                 FieldCodec`1<LiveRankingUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 028 IdolList                                 000185CE3768 ModelClassListType RepeatedField`1<LiveRankingUnitIdolStatus> RepeatedField`1<LiveRankingUnitIdolStatus> List<LiveRankingUnitIdolStatus> Pointer
    // 000 UserProfileFieldNumber                   int IL2CPP_TYPE_I4
    // 030 UserProfile                              00018656B480 ModelClassType LiveRankingUserProfileStatus LiveRankingUserProfileStatus LiveRankingUserProfileStatus Pointer
    public partial class LiveHighScoreRankingUserStatus
    {
        public int                                      Rank                                    { get; set; }
        public int                                      HighScore                               { get; set; }
        public int                                      TotalPower                              { get; set; }
        public List<LiveRankingUnitIdolStatus>?         IdolList                                { get; set; }
        public LiveRankingUserProfileStatus?            UserProfile                             { get; set; }

        public static LiveHighScoreRankingUserStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveHighScoreRankingUserStatus();

            value.Rank                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D134DD20 0x18 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HighScore                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D134DD60 0x1C HighScore                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalPower                                = GetInt32(new IntPtr(p + 0x020)); // 0270D134DDA0 0x20 TotalPower                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolList                                  = GetObjectList<LiveRankingUnitIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveRankingUnitIdolStatus.FromPointer); // 0270D134DE00 0x28 IdolList                    ( 000185CE3768 ModelClassListType RepeatedField`1<LiveRankingUnitIdolStatus> RepeatedField`1<LiveRankingUnitIdolStatus> List<LiveRankingUnitIdolStatus> Pointer )
            value.UserProfile                               = GetObject<LiveRankingUserProfileStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveRankingUserProfileStatus.FromPointer); // 0270D134DE40 0x30 UserProfile                 ( 00018656B480 ModelClassType LiveRankingUserProfileStatus LiveRankingUserProfileStatus LiveRankingUserProfileStatus Pointer )

            return value;
        }
    }
}
