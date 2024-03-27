using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Song                                     000186649480 ModelClassType ISongStatus ISongStatus ISongStatus Pointer
    // 018 TotalHighScoreRating                     0001866781F0 ModelClassType ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus Pointer
    // 020 TotalTechnicalRating                     000186678B90 ModelClassType ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus Pointer
    // 028 RankRewardList                           000185D08C08 ModelClassListType IReadOnlyList`1<IRankRewardStatus> IReadOnlyList`1<IRankRewardStatus> List<IRankRewardStatus> Pointer
    public partial class SongCacheForResult
    {
        public ISongStatus?                             Song                                    { get; set; }
        public ITotalHighScoreRatingStatus?             TotalHighScoreRating                    { get; set; }
        public ITotalTechnicalRatingStatus?             TotalTechnicalRating                    { get; set; }
        public List<IRankRewardStatus>?                 RankRewardList                          { get; set; }

        public static SongCacheForResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SongCacheForResult();

            value.Song                                      = GetObject<ISongStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISongStatus.FromPointer); // 0270D5249920 0x10 Song                        ( 000186649480 ModelClassType ISongStatus ISongStatus ISongStatus Pointer )
            value.TotalHighScoreRating                      = GetObject<ITotalHighScoreRatingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITotalHighScoreRatingStatus.FromPointer); // 0270D5249940 0x18 TotalHighScoreRating        ( 0001866781F0 ModelClassType ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<ITotalTechnicalRatingStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ITotalTechnicalRatingStatus.FromPointer); // 0270D5249960 0x20 TotalTechnicalRating        ( 000186678B90 ModelClassType ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus Pointer )
            value.RankRewardList                            = GetObjectList<IRankRewardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IRankRewardStatus.FromPointer); // 0270D5249980 0x28 RankRewardList              ( 000185D08C08 ModelClassListType IReadOnlyList`1<IRankRewardStatus> IReadOnlyList`1<IRankRewardStatus> List<IRankRewardStatus> Pointer )

            return value;
        }
    }
}
