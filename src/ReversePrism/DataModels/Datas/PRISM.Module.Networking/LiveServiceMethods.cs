using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetSongList                              Method`2<IGetSongListArgs, IGetSongListReply> IL2CPP_TYPE_GENERICINST
    // 018 GetSongRatingList                        Method`2<IGetSongRatingListArgs, IGetSongRatingListReply> IL2CPP_TYPE_GENERICINST
    // 030 SetFavoriteSong                          Method`2<ISetFavoriteSongArgs, ISetFavoriteSongReply> IL2CPP_TYPE_GENERICINST
    // 048 GetLiveUnit                              Method`2<IGetLiveUnitArgs, IGetLiveUnitReply> IL2CPP_TYPE_GENERICINST
    // 060 SetLiveUnit                              Method`2<ISetLiveUnitArgs, ISetLiveUnitReply> IL2CPP_TYPE_GENERICINST
    // 078 SetLiveUnitName                          Method`2<ISetLiveUnitNameArgs, ISetLiveUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 090 GetLivePlayRewardList                    Method`2<IGetLivePlayRewardListArgs, IGetLivePlayRewardListReply> IL2CPP_TYPE_GENERICINST
    // 0A8 StartLive                                Method`2<IStartLiveArgs, IStartLiveReply> IL2CPP_TYPE_GENERICINST
    // 0C0 FinishLive                               Method`2<IFinishLiveArgs, IFinishLiveReply> IL2CPP_TYPE_GENERICINST
    // 0D8 BreakLive                                Method`2<IBreakLiveArgs, IBreakLiveReply> IL2CPP_TYPE_GENERICINST
    // 0F0 GetStartLiveInfo                         Method`2<IGetStartLiveInfoArgs, IGetStartLiveInfoReply> IL2CPP_TYPE_GENERICINST
    // 108 SkipLive                                 Method`2<ISkipLiveArgs, ISkipLiveReply> IL2CPP_TYPE_GENERICINST
    // 120 GetMvUnitList                            Method`2<IGetMvUnitListArgs, IGetMvUnitListReply> IL2CPP_TYPE_GENERICINST
    // 138 SetMvUnit                                Method`2<ISetMvUnitArgs, ISetMvUnitReply> IL2CPP_TYPE_GENERICINST
    // 150 SetMvUnitName                            Method`2<ISetMvUnitNameArgs, ISetMvUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 168 SetMvOriginalMember                      Method`2<ISetMvOriginalMemberArgs, ISetMvOriginalMemberReply> IL2CPP_TYPE_GENERICINST
    // 180 GetLiveHighScoreRanking                  Method`2<IGetLiveHighScoreRankingArgs, IGetLiveHighScoreRankingReply> IL2CPP_TYPE_GENERICINST
    // 198 GetLiveEnable                            Method`2<IGetLiveEnableArgs, IGetLiveEnableReply> IL2CPP_TYPE_GENERICINST
    // 1B0 StartMV                                  Method`2<IStartMVArgs, IStartMVReply> IL2CPP_TYPE_GENERICINST
    // 1C8 GetEventList                             Method`2<IGetEventListArgs, IGetEventListReply> IL2CPP_TYPE_GENERICINST
    public partial class LiveServiceMethods : DataModel
    {

        public static LiveServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
