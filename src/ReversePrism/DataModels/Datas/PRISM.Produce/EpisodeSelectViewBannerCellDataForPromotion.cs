using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortId                                   ModelPrimitiveType int int int Int32
    // 018 BannerPath                               ModelPrimitiveType string string string String
    // 020 PromotionUrl                             ModelPrimitiveType string string string String
    public partial class EpisodeSelectViewBannerCellDataForPromotion : DataModel
    {
        public int                                      SortId                                  { get; set; }
        public string                                   BannerPath                              { get; set; }
        public string                                   PromotionUrl                            { get; set; }

        public static EpisodeSelectViewBannerCellDataForPromotion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EpisodeSelectViewBannerCellDataForPromotion() { Pointer= p0 };

            value.SortId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.BannerPath                                = GetString(new IntPtr(p + 0x018)); // 0x18 BannerPath                  ( ModelPrimitiveType string string string String )
            value.PromotionUrl                              = GetString(new IntPtr(p + 0x020)); // 0x20 PromotionUrl                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
