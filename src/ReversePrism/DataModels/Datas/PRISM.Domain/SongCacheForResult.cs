using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Song                                     ModelClassType ISongStatus ISongStatus ISongStatus Pointer
    // 018 TotalHighScoreRating                     ModelClassType ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus Pointer
    // 020 TotalTechnicalRating                     ModelClassType ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus Pointer
    // 028 IsShinyEnabled                           ModelPrimitiveType bool bool bool Bool
    public partial class SongCacheForResult : DataModel
    {
        public ISongStatus?                             Song                                    { get; set; }
        public ITotalHighScoreRatingStatus?             TotalHighScoreRating                    { get; set; }
        public ITotalTechnicalRatingStatus?             TotalTechnicalRating                    { get; set; }
        public bool                                     IsShinyEnabled                          { get; set; }

        public static SongCacheForResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SongCacheForResult() { Pointer= p0 };

            value.Song                                      = GetObject<ISongStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISongStatus.FromPointer); // 0x10 Song                        ( ModelClassType ISongStatus ISongStatus ISongStatus Pointer )
            value.TotalHighScoreRating                      = GetObject<ITotalHighScoreRatingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITotalHighScoreRatingStatus.FromPointer); // 0x18 TotalHighScoreRating        ( ModelClassType ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<ITotalTechnicalRatingStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ITotalTechnicalRatingStatus.FromPointer); // 0x20 TotalTechnicalRating        ( ModelClassType ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus Pointer )
            value.IsShinyEnabled                            = GetBool(new IntPtr(p + 0x028)); // 0x28 IsShinyEnabled              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
