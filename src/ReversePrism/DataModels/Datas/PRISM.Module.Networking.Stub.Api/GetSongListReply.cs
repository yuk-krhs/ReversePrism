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
    // 018 SongList                                 ModelClassListType RepeatedField`1<SongStatus> RepeatedField`1<SongStatus> List<SongStatus> Pointer
    // 000 TotalHighScoreRatingFieldNumber          int IL2CPP_TYPE_I4
    // 020 TotalHighScoreRating                     ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer
    // 000 TotalTechnicalRatingFieldNumber          int IL2CPP_TYPE_I4
    // 028 TotalTechnicalRating                     ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer
    // 000 FavoriteSongListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_favoriteSongList_codec         FieldCodec`1<FavoriteSongStatus> IL2CPP_TYPE_GENERICINST
    // 030 FavoriteSongList                         ModelClassListType RepeatedField`1<FavoriteSongStatus> RepeatedField`1<FavoriteSongStatus> List<FavoriteSongStatus> Pointer
    public partial class GetSongListReply : DataModel
    {
        public List<SongStatus>?                        SongList                                { get; set; }
        public TotalHighScoreRatingStatus?              TotalHighScoreRating                    { get; set; }
        public TotalTechnicalRatingStatus?              TotalTechnicalRating                    { get; set; }
        public List<FavoriteSongStatus>?                FavoriteSongList                        { get; set; }

        public static GetSongListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSongListReply() { Pointer= p0 };

            value.SongList                                  = GetObjectList<SongStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SongStatus.FromPointer); // 0x18 SongList                    ( ModelClassListType RepeatedField`1<SongStatus> RepeatedField`1<SongStatus> List<SongStatus> Pointer )
            value.TotalHighScoreRating                      = GetObject<TotalHighScoreRatingStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.TotalHighScoreRatingStatus.FromPointer); // 0x20 TotalHighScoreRating        ( ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<TotalTechnicalRatingStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.TotalTechnicalRatingStatus.FromPointer); // 0x28 TotalTechnicalRating        ( ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer )
            value.FavoriteSongList                          = GetObjectList<FavoriteSongStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.FavoriteSongStatus.FromPointer); // 0x30 FavoriteSongList            ( ModelClassListType RepeatedField`1<FavoriteSongStatus> RepeatedField`1<FavoriteSongStatus> List<FavoriteSongStatus> Pointer )

            return value;
        }
    }
}
