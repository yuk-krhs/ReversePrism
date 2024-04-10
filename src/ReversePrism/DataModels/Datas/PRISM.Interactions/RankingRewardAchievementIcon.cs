using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     000186675B10 ModelClassType AchievementIconView AchievementIconView AchievementIconView Pointer
    // 028 IconDisposable                           0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class RankingRewardAchievementIcon : DataModel
    {
        public AchievementIconView?                     Icon                                    { get; set; }
        public IDisposable?                             IconDisposable                          { get; set; }

        public static RankingRewardAchievementIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankingRewardAchievementIcon() { Pointer= p0 };

            value.Icon                                      = GetObject<AchievementIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.AchievementIconView.FromPointer); // 02466B5FF430 0x20 Icon                        ( 000186675B10 ModelClassType AchievementIconView AchievementIconView AchievementIconView Pointer )
            value.IconDisposable                            = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B5FF450 0x28 IconDisposable              ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
