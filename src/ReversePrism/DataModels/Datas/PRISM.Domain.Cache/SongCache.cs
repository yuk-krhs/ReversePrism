using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 songDic                                  Dictionary`2<int, ISongStatus> IL2CPP_TYPE_GENERICINST
    // 018 TotalHighScoreRating                     ModelClassType ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus Pointer
    // 020 TotalTechnicalRating                     ModelClassType ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus Pointer
    // 028 favoriteSongDic                          Dictionary`2<FavoriteSongSlot, IFavoriteSongStatus> IL2CPP_TYPE_GENERICINST
    // 030 IsReady                                  ModelPrimitiveType bool bool bool Bool
    public partial class SongCache : DataModel
    {
        public ITotalHighScoreRatingStatus?             TotalHighScoreRating                    { get; set; }
        public ITotalTechnicalRatingStatus?             TotalTechnicalRating                    { get; set; }
        public bool                                     IsReady                                 { get; set; }

        public static SongCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SongCache() { Pointer= p0 };

            value.TotalHighScoreRating                      = GetObject<ITotalHighScoreRatingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITotalHighScoreRatingStatus.FromPointer); // 0x18 TotalHighScoreRating        ( ModelClassType ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<ITotalTechnicalRatingStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ITotalTechnicalRatingStatus.FromPointer); // 0x20 TotalTechnicalRating        ( ModelClassType ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus Pointer )
            value.IsReady                                   = GetBool(new IntPtr(p + 0x030)); // 0x30 IsReady                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
