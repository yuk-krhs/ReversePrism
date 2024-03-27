using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BannerButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 BannerImage                              0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class ProducePreparationEpisodeSelectBannerView
    {
        public UIButton?                                BannerButton                            { get; set; }
        public UIImage?                                 BannerImage                             { get; set; }

        public static ProducePreparationEpisodeSelectBannerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectBannerView();

            value.BannerButton                              = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270D59DC478 0x20 BannerButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BannerImage                               = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270D59DC498 0x28 BannerImage                 ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
