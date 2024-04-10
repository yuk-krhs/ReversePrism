using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardListView                           0001865ECF10 ModelClassType MedalGashaRewardListView MedalGashaRewardListView MedalGashaRewardListView Pointer
    // 028 EventId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class MedalGashaRewardTabView : DataModel
    {
        public MedalGashaRewardListView?                RewardListView                          { get; set; }
        public int                                      EventId                                 { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static MedalGashaRewardTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardTabView() { Pointer= p0 };

            value.RewardListView                            = GetObject<MedalGashaRewardListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MedalGashaRewardListView.FromPointer); // 02466B997260 0x20 RewardListView              ( 0001865ECF10 ModelClassType MedalGashaRewardListView MedalGashaRewardListView MedalGashaRewardListView Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x028)); // 02466B997280 0x28 EventId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466B9972A0 0x30 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
