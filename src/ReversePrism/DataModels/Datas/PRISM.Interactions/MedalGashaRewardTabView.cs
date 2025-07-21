using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardListView                           ModelClassType MedalGashaRewardListView MedalGashaRewardListView MedalGashaRewardListView Pointer
    // 028 EventId                                  ModelPrimitiveType int int int Int32
    public partial class MedalGashaRewardTabView : DataModel
    {
        public MedalGashaRewardListView?                RewardListView                          { get; set; }
        public int                                      EventId                                 { get; set; }

        public static MedalGashaRewardTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardTabView() { Pointer= p0 };

            value.RewardListView                            = GetObject<MedalGashaRewardListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MedalGashaRewardListView.FromPointer); // 0x20 RewardListView              ( ModelClassType MedalGashaRewardListView MedalGashaRewardListView MedalGashaRewardListView Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 EventId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
