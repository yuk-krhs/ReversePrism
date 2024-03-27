using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001865EFBA0 ModelClassType MedalGashaView MedalGashaView MedalGashaView Pointer
    // 028 RankingFactory                           000186551470 ModelClassType LiveEventRankingOverlayViewFactory LiveEventRankingOverlayViewFactory LiveEventRankingOverlayViewFactory Pointer
    // 030 ResultViewFactory                        0001865EA2D0 ModelClassType MedalGashaResultViewFactory MedalGashaResultViewFactory MedalGashaResultViewFactory Pointer
    public partial class MedalGashaBuilder
    {
        public MedalGashaView?                          View                                    { get; set; }
        public LiveEventRankingOverlayViewFactory?      RankingFactory                          { get; set; }
        public MedalGashaResultViewFactory?             ResultViewFactory                       { get; set; }

        public static MedalGashaBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaBuilder();

            value.View                                      = GetObject<MedalGashaView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MedalGashaView.FromPointer); // 0270DB61AD10 0x20 View                        ( 0001865EFBA0 ModelClassType MedalGashaView MedalGashaView MedalGashaView Pointer )
            value.RankingFactory                            = GetObject<LiveEventRankingOverlayViewFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveEventRankingOverlayViewFactory.FromPointer); // 0270DB61AD30 0x28 RankingFactory              ( 000186551470 ModelClassType LiveEventRankingOverlayViewFactory LiveEventRankingOverlayViewFactory LiveEventRankingOverlayViewFactory Pointer )
            value.ResultViewFactory                         = GetObject<MedalGashaResultViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.MedalGashaResultViewFactory.FromPointer); // 0270DB61AD50 0x30 ResultViewFactory           ( 0001865EA2D0 ModelClassType MedalGashaResultViewFactory MedalGashaResultViewFactory MedalGashaResultViewFactory Pointer )

            return value;
        }
    }
}
