using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardViewCells                          ModelClassListType ChallengeTourResultRewardViewCell[] ChallengeTourResultRewardViewCell[] List<ChallengeTourResultRewardViewCell> Pointer
    public partial class ChallengeTourResultRewardPanelView : DataModel
    {
        public List<ChallengeTourResultRewardViewCell>? RewardViewCells                         { get; set; }

        public static ChallengeTourResultRewardPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourResultRewardPanelView() { Pointer= p0 };

            value.RewardViewCells                           = GetObjectList<ChallengeTourResultRewardViewCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourResultRewardViewCell.FromPointer); // 0x20 RewardViewCells             ( ModelClassListType ChallengeTourResultRewardViewCell[] ChallengeTourResultRewardViewCell[] List<ChallengeTourResultRewardViewCell> Pointer )

            return value;
        }
    }
}
