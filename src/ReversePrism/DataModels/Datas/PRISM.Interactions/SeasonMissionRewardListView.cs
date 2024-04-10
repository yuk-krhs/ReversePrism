using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 SpecialReward                            000186706E40 ModelClassType SeasonMissionRewardListViewCell SeasonMissionRewardListViewCell SeasonMissionRewardListViewCell Pointer
    // 098 onScrollSubject                          Subject`1<float> IL2CPP_TYPE_GENERICINST
    public partial class SeasonMissionRewardListView : DataModel
    {
        public SeasonMissionRewardListViewCell?         SpecialReward                           { get; set; }

        public static SeasonMissionRewardListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionRewardListView() { Pointer= p0 };

            value.SpecialReward                             = GetObject<SeasonMissionRewardListViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.SeasonMissionRewardListViewCell.FromPointer); // 02466BDAA088 0x90 SpecialReward               ( 000186706E40 ModelClassType SeasonMissionRewardListViewCell SeasonMissionRewardListViewCell SeasonMissionRewardListViewCell Pointer )

            return value;
        }
    }
}
