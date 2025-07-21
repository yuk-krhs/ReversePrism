using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType EpisodeSelectViewBannerGroup EpisodeSelectViewBannerGroup EpisodeSelectViewBannerGroup Pointer
    public partial class EpisodeSelectViewBannerGroupReferenceForLegacyImplement : DataModel
    {
        public EpisodeSelectViewBannerGroup?            View                                    { get; set; }

        public static EpisodeSelectViewBannerGroupReferenceForLegacyImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EpisodeSelectViewBannerGroupReferenceForLegacyImplement() { Pointer= p0 };

            value.View                                      = GetObject<EpisodeSelectViewBannerGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.EpisodeSelectViewBannerGroup.FromPointer); // 0x20 View                        ( ModelClassType EpisodeSelectViewBannerGroup EpisodeSelectViewBannerGroup EpisodeSelectViewBannerGroup Pointer )

            return value;
        }
    }
}
