using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 songDic                                  Dictionary`2<int, ISongStatus> IL2CPP_TYPE_GENERICINST
    // 018 TotalHighScoreRating                     000186677D10 ModelClassType ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus Pointer
    // 020 TotalTechnicalRating                     0001866786C0 ModelClassType ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus Pointer
    // 028 RankRewardList                           000185B89530 ModelClassListType IRankRewardStatus[] IRankRewardStatus[] List<IRankRewardStatus> Pointer
    // 030 favoriteSongDic                          Dictionary`2<FavoriteSongSlot, IFavoriteSongStatus> IL2CPP_TYPE_GENERICINST
    // 038 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SongCache
    {
        public ITotalHighScoreRatingStatus?             TotalHighScoreRating                    { get; set; }
        public ITotalTechnicalRatingStatus?             TotalTechnicalRating                    { get; set; }
        public List<IRankRewardStatus>?                 RankRewardList                          { get; set; }
        public bool                                     IsReady                                 { get; set; }

        public static SongCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SongCache();

            value.TotalHighScoreRating                      = GetObject<ITotalHighScoreRatingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITotalHighScoreRatingStatus.FromPointer); // 027004A8AAD0 0x18 TotalHighScoreRating        ( 000186677D10 ModelClassType ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus ITotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<ITotalTechnicalRatingStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ITotalTechnicalRatingStatus.FromPointer); // 027004A8AAF0 0x20 TotalTechnicalRating        ( 0001866786C0 ModelClassType ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus ITotalTechnicalRatingStatus Pointer )
            value.RankRewardList                            = GetObjectList<IRankRewardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IRankRewardStatus.FromPointer); // 027004A8AB10 0x28 RankRewardList              ( 000185B89530 ModelClassListType IRankRewardStatus[] IRankRewardStatus[] List<IRankRewardStatus> Pointer )
            value.IsReady                                   = GetBool(new IntPtr(p + 0x038)); // 027004A8AB50 0x38 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
