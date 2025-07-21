using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SelfRankingView                          ModelClassType UserRankingView UserRankingView UserRankingView Pointer
    // 028 AchievementIcons                         ModelClassListType SimpleAchievementIcon[] SimpleAchievementIcon[] List<SimpleAchievementIcon> Pointer
    // 030 IdolIcon                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    public partial class LiveEventAllSongSelfRankingView : DataModel
    {
        public UserRankingView?                         SelfRankingView                         { get; set; }
        public List<SimpleAchievementIcon>?             AchievementIcons                        { get; set; }
        public PFIdolIconView?                          IdolIcon                                { get; set; }

        public static LiveEventAllSongSelfRankingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAllSongSelfRankingView() { Pointer= p0 };

            value.SelfRankingView                           = GetObject<UserRankingView>(new IntPtr(p + 0x020), ReversePrism.DataModels.UserRankingView.FromPointer); // 0x20 SelfRankingView             ( ModelClassType UserRankingView UserRankingView UserRankingView Pointer )
            value.AchievementIcons                          = GetObjectList<SimpleAchievementIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.SimpleAchievementIcon.FromPointer); // 0x28 AchievementIcons            ( ModelClassListType SimpleAchievementIcon[] SimpleAchievementIcon[] List<SimpleAchievementIcon> Pointer )
            value.IdolIcon                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x30 IdolIcon                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )

            return value;
        }
    }
}
