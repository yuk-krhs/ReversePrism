using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186569420 ModelClassType ProducePreparationEpisodeSelectBannerView ProducePreparationEpisodeSelectBannerView ProducePreparationEpisodeSelectBannerView Pointer
    public partial class ProducePreparationEpisodeSelectBannerBuilder
    {
        public ProducePreparationEpisodeSelectBannerView? View                                    { get; set; }

        public static ProducePreparationEpisodeSelectBannerBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectBannerBuilder();

            value.View                                      = GetObject<ProducePreparationEpisodeSelectBannerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProducePreparationEpisodeSelectBannerView.FromPointer); // 0270D59DC448 0x20 View                        ( 000186569420 ModelClassType ProducePreparationEpisodeSelectBannerView ProducePreparationEpisodeSelectBannerView ProducePreparationEpisodeSelectBannerView Pointer )

            return value;
        }
    }
}
