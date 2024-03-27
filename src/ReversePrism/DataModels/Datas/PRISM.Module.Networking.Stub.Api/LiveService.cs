using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetSongListArgs         Marshaller`1<GetSongListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetSongListReply        Marshaller`1<GetSongListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetSongRatingListArgs   Marshaller`1<GetSongRatingListArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetSongRatingListReply  Marshaller`1<GetSongRatingListReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_SetFavoriteSongArgs     Marshaller`1<SetFavoriteSongArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_SetFavoriteSongReply    Marshaller`1<SetFavoriteSongReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_GetLiveUnitArgs         Marshaller`1<GetLiveUnitArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_GetLiveUnitReply        Marshaller`1<GetLiveUnitReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_SetLiveUnitArgs         Marshaller`1<SetLiveUnitArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_SetLiveUnitReply        Marshaller`1<SetLiveUnitReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_SetLiveUnitNameArgs     Marshaller`1<SetLiveUnitNameArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_SetLiveUnitNameReply    Marshaller`1<SetLiveUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 068 __Marshaller_api_GetLivePlayRewardListArgs Marshaller`1<GetLivePlayRewardListArgs> IL2CPP_TYPE_GENERICINST
    // 070 __Marshaller_api_GetLivePlayRewardListReply Marshaller`1<GetLivePlayRewardListReply> IL2CPP_TYPE_GENERICINST
    // 078 __Marshaller_api_StartLiveArgs           Marshaller`1<StartLiveArgs> IL2CPP_TYPE_GENERICINST
    // 080 __Marshaller_api_StartLiveReply          Marshaller`1<StartLiveReply> IL2CPP_TYPE_GENERICINST
    // 088 __Marshaller_api_FinishLiveArgs          Marshaller`1<FinishLiveArgs> IL2CPP_TYPE_GENERICINST
    // 090 __Marshaller_api_FinishLiveReply         Marshaller`1<FinishLiveReply> IL2CPP_TYPE_GENERICINST
    // 098 __Marshaller_api_BreakLiveArgs           Marshaller`1<BreakLiveArgs> IL2CPP_TYPE_GENERICINST
    // 0A0 __Marshaller_api_BreakLiveReply          Marshaller`1<BreakLiveReply> IL2CPP_TYPE_GENERICINST
    // 0A8 __Marshaller_api_GetStartLiveInfoArgs    Marshaller`1<GetStartLiveInfoArgs> IL2CPP_TYPE_GENERICINST
    // 0B0 __Marshaller_api_GetStartLiveInfoReply   Marshaller`1<GetStartLiveInfoReply> IL2CPP_TYPE_GENERICINST
    // 0B8 __Marshaller_api_SkipLiveArgs            Marshaller`1<SkipLiveArgs> IL2CPP_TYPE_GENERICINST
    // 0C0 __Marshaller_api_SkipLiveReply           Marshaller`1<SkipLiveReply> IL2CPP_TYPE_GENERICINST
    // 0C8 __Marshaller_api_GetMvUnitListArgs       Marshaller`1<GetMvUnitListArgs> IL2CPP_TYPE_GENERICINST
    // 0D0 __Marshaller_api_GetMvUnitListReply      Marshaller`1<GetMvUnitListReply> IL2CPP_TYPE_GENERICINST
    // 0D8 __Marshaller_api_SetMvUnitArgs           Marshaller`1<SetMvUnitArgs> IL2CPP_TYPE_GENERICINST
    // 0E0 __Marshaller_api_SetMvUnitReply          Marshaller`1<SetMvUnitReply> IL2CPP_TYPE_GENERICINST
    // 0E8 __Marshaller_api_SetMvUnitNameArgs       Marshaller`1<SetMvUnitNameArgs> IL2CPP_TYPE_GENERICINST
    // 0F0 __Marshaller_api_SetMvUnitNameReply      Marshaller`1<SetMvUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 0F8 __Marshaller_api_SetMvOriginalMemberArgs Marshaller`1<SetMvOriginalMemberArgs> IL2CPP_TYPE_GENERICINST
    // 100 __Marshaller_api_SetMvOriginalMemberReply Marshaller`1<SetMvOriginalMemberReply> IL2CPP_TYPE_GENERICINST
    // 108 __Marshaller_api_GetLiveHighScoreRankingArgs Marshaller`1<GetLiveHighScoreRankingArgs> IL2CPP_TYPE_GENERICINST
    // 110 __Marshaller_api_GetLiveHighScoreRankingReply Marshaller`1<GetLiveHighScoreRankingReply> IL2CPP_TYPE_GENERICINST
    // 118 __Marshaller_api_GetLiveEnableArgs       Marshaller`1<GetLiveEnableArgs> IL2CPP_TYPE_GENERICINST
    // 120 __Marshaller_api_GetLiveEnableReply      Marshaller`1<GetLiveEnableReply> IL2CPP_TYPE_GENERICINST
    // 128 __Marshaller_api_StartMVArgs             Marshaller`1<StartMVArgs> IL2CPP_TYPE_GENERICINST
    // 130 __Marshaller_api_StartMVReply            Marshaller`1<StartMVReply> IL2CPP_TYPE_GENERICINST
    // 138 __Marshaller_api_GetEventListArgs        Marshaller`1<GetEventListArgs> IL2CPP_TYPE_GENERICINST
    // 140 __Marshaller_api_GetEventListReply       Marshaller`1<GetEventListReply> IL2CPP_TYPE_GENERICINST
    // 148 __Method_GetSongList                     Method`2<GetSongListArgs, GetSongListReply> IL2CPP_TYPE_GENERICINST
    // 150 __Method_GetSongRatingList               Method`2<GetSongRatingListArgs, GetSongRatingListReply> IL2CPP_TYPE_GENERICINST
    // 158 __Method_SetFavoriteSong                 Method`2<SetFavoriteSongArgs, SetFavoriteSongReply> IL2CPP_TYPE_GENERICINST
    // 160 __Method_GetLiveUnit                     Method`2<GetLiveUnitArgs, GetLiveUnitReply> IL2CPP_TYPE_GENERICINST
    // 168 __Method_SetLiveUnit                     Method`2<SetLiveUnitArgs, SetLiveUnitReply> IL2CPP_TYPE_GENERICINST
    // 170 __Method_SetLiveUnitName                 Method`2<SetLiveUnitNameArgs, SetLiveUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 178 __Method_GetLivePlayRewardList           Method`2<GetLivePlayRewardListArgs, GetLivePlayRewardListReply> IL2CPP_TYPE_GENERICINST
    // 180 __Method_StartLive                       Method`2<StartLiveArgs, StartLiveReply> IL2CPP_TYPE_GENERICINST
    // 188 __Method_FinishLive                      Method`2<FinishLiveArgs, FinishLiveReply> IL2CPP_TYPE_GENERICINST
    // 190 __Method_BreakLive                       Method`2<BreakLiveArgs, BreakLiveReply> IL2CPP_TYPE_GENERICINST
    // 198 __Method_GetStartLiveInfo                Method`2<GetStartLiveInfoArgs, GetStartLiveInfoReply> IL2CPP_TYPE_GENERICINST
    // 1A0 __Method_SkipLive                        Method`2<SkipLiveArgs, SkipLiveReply> IL2CPP_TYPE_GENERICINST
    // 1A8 __Method_GetMvUnitList                   Method`2<GetMvUnitListArgs, GetMvUnitListReply> IL2CPP_TYPE_GENERICINST
    // 1B0 __Method_SetMvUnit                       Method`2<SetMvUnitArgs, SetMvUnitReply> IL2CPP_TYPE_GENERICINST
    // 1B8 __Method_SetMvUnitName                   Method`2<SetMvUnitNameArgs, SetMvUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 1C0 __Method_SetMvOriginalMember             Method`2<SetMvOriginalMemberArgs, SetMvOriginalMemberReply> IL2CPP_TYPE_GENERICINST
    // 1C8 __Method_GetLiveHighScoreRanking         Method`2<GetLiveHighScoreRankingArgs, GetLiveHighScoreRankingReply> IL2CPP_TYPE_GENERICINST
    // 1D0 __Method_GetLiveEnable                   Method`2<GetLiveEnableArgs, GetLiveEnableReply> IL2CPP_TYPE_GENERICINST
    // 1D8 __Method_StartMV                         Method`2<StartMVArgs, StartMVReply> IL2CPP_TYPE_GENERICINST
    // 1E0 __Method_GetEventList                    Method`2<GetEventListArgs, GetEventListReply> IL2CPP_TYPE_GENERICINST
    public partial class LiveService
    {

        public static LiveService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveService();


            return value;
        }
    }
}
