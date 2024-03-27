using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetSongListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SongListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_songList_codec                 FieldCodec`1<SongStatus> IL2CPP_TYPE_GENERICINST
    // 018 SongList                                 000185CF1AB8 ModelClassListType RepeatedField`1<SongStatus> RepeatedField`1<SongStatus> List<SongStatus> Pointer
    // 000 TotalHighScoreRatingFieldNumber          int IL2CPP_TYPE_I4
    // 020 TotalHighScoreRating                     00018668CAE0 ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer
    // 000 TotalTechnicalRatingFieldNumber          int IL2CPP_TYPE_I4
    // 028 TotalTechnicalRating                     00018668D290 ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer
    // 000 RankRewardListFieldNumber                int IL2CPP_TYPE_I4
    // 010 _repeated_rankRewardList_codec           FieldCodec`1<RankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 030 RankRewardList                           000185CEE7D8 ModelClassListType RepeatedField`1<RankRewardStatus> RepeatedField`1<RankRewardStatus> List<RankRewardStatus> Pointer
    // 000 FavoriteSongListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_favoriteSongList_codec         FieldCodec`1<FavoriteSongStatus> IL2CPP_TYPE_GENERICINST
    // 038 FavoriteSongList                         000185CD73C8 ModelClassListType RepeatedField`1<FavoriteSongStatus> RepeatedField`1<FavoriteSongStatus> List<FavoriteSongStatus> Pointer
    public partial class GetSongListReply
    {
        public List<SongStatus>?                        SongList                                { get; set; }
        public TotalHighScoreRatingStatus?              TotalHighScoreRating                    { get; set; }
        public TotalTechnicalRatingStatus?              TotalTechnicalRating                    { get; set; }
        public List<RankRewardStatus>?                  RankRewardList                          { get; set; }
        public List<FavoriteSongStatus>?                FavoriteSongList                        { get; set; }

        public static GetSongListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSongListReply();

            value.SongList                                  = GetObjectList<SongStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SongStatus.FromPointer); // 0270D21DB998 0x18 SongList                    ( 000185CF1AB8 ModelClassListType RepeatedField`1<SongStatus> RepeatedField`1<SongStatus> List<SongStatus> Pointer )
            value.TotalHighScoreRating                      = GetObject<TotalHighScoreRatingStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.TotalHighScoreRatingStatus.FromPointer); // 0270D21DB9D8 0x20 TotalHighScoreRating        ( 00018668CAE0 ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<TotalTechnicalRatingStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.TotalTechnicalRatingStatus.FromPointer); // 0270D21DBA18 0x28 TotalTechnicalRating        ( 00018668D290 ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer )
            value.RankRewardList                            = GetObjectList<RankRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.RankRewardStatus.FromPointer); // 0270D21DBA78 0x30 RankRewardList              ( 000185CEE7D8 ModelClassListType RepeatedField`1<RankRewardStatus> RepeatedField`1<RankRewardStatus> List<RankRewardStatus> Pointer )
            value.FavoriteSongList                          = GetObjectList<FavoriteSongStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.FavoriteSongStatus.FromPointer); // 0270D21DBAD8 0x38 FavoriteSongList            ( 000185CD73C8 ModelClassListType RepeatedField`1<FavoriteSongStatus> RepeatedField`1<FavoriteSongStatus> List<FavoriteSongStatus> Pointer )

            return value;
        }
    }
}
