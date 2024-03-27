using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GetLiveHighScoreRankingReply             000186540310 ModelClassType IGetLiveHighScoreRankingReply IGetLiveHighScoreRankingReply IGetLiveHighScoreRankingReply Pointer
    // 018 GetSelfProfileReply                      00018654C580 ModelClassType IGetSelfProfileReply IGetSelfProfileReply IGetSelfProfileReply Pointer
    // 020 CurrentDifficulty                        00018661C520 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 028 CurrentMusicData                         000186664B50 ModelClassType MusicData MusicData MusicData Pointer
    // 030 <AllMusic>k__BackingField                IList`1<MusicData> IL2CPP_TYPE_GENERICINST
    // 038 LiveService                              000186598FD0 ModelClassType ILiveService ILiveService ILiveService Pointer
    // 040 ProfileService                           0001865FEC30 ModelClassType IProfileService IProfileService IProfileService Pointer
    // 048 onChangeMusic                            Subject`1<ValueTuple`2<MusicData, SongDifficultyLevel>> IL2CPP_TYPE_GENERICINST
    public partial class MusicRankingOverlayViewModel
    {
        public IGetLiveHighScoreRankingReply?           GetLiveHighScoreRankingReply            { get; set; }
        public IGetSelfProfileReply?                    GetSelfProfileReply                     { get; set; }
        public SongDifficultyLevel                      CurrentDifficulty                       { get; set; }
        public MusicData?                               CurrentMusicData                        { get; set; }
        public ILiveService?                            LiveService                             { get; set; }
        public IProfileService?                         ProfileService                          { get; set; }

        public static MusicRankingOverlayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRankingOverlayViewModel();

            value.GetLiveHighScoreRankingReply              = GetObject<IGetLiveHighScoreRankingReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGetLiveHighScoreRankingReply.FromPointer); // 0270D63F4A18 0x10 GetLiveHighScoreRankingReply ( 000186540310 ModelClassType IGetLiveHighScoreRankingReply IGetLiveHighScoreRankingReply IGetLiveHighScoreRankingReply Pointer )
            value.GetSelfProfileReply                       = GetObject<IGetSelfProfileReply>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGetSelfProfileReply.FromPointer); // 0270D63F4A38 0x18 GetSelfProfileReply         ( 00018654C580 ModelClassType IGetSelfProfileReply IGetSelfProfileReply IGetSelfProfileReply Pointer )
            value.CurrentDifficulty                         = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x020)); // 0270D63F4A58 0x20 CurrentDifficulty           ( 00018661C520 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.CurrentMusicData                          = GetObject<MusicData>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicData.FromPointer); // 0270D63F4A78 0x28 CurrentMusicData            ( 000186664B50 ModelClassType MusicData MusicData MusicData Pointer )
            value.LiveService                               = GetObject<ILiveService>(new IntPtr(p + 0x038), ReversePrism.DataModels.ILiveService.FromPointer); // 0270D63F4AB8 0x38 LiveService                 ( 000186598FD0 ModelClassType ILiveService ILiveService ILiveService Pointer )
            value.ProfileService                            = GetObject<IProfileService>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProfileService.FromPointer); // 0270D63F4AD8 0x40 ProfileService              ( 0001865FEC30 ModelClassType IProfileService IProfileService IProfileService Pointer )

            return value;
        }
    }
}
