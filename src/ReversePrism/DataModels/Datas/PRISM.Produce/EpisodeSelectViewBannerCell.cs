using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 BannerImage                              ModelClassType UIImage UIImage UIImage Pointer
    // 068 SpriteForChallengeTour                   ModelClassType Sprite Sprite Sprite Pointer
    // 070 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class EpisodeSelectViewBannerCell : DataModel
    {
        public UIImage?                                 BannerImage                             { get; set; }
        public Sprite?                                  SpriteForChallengeTour                  { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static EpisodeSelectViewBannerCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EpisodeSelectViewBannerCell() { Pointer= p0 };

            value.BannerImage                               = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 0x60 BannerImage                 ( ModelClassType UIImage UIImage UIImage Pointer )
            value.SpriteForChallengeTour                    = GetObject<Sprite>(new IntPtr(p + 0x068), ReversePrism.DataModels.Sprite.FromPointer); // 0x68 SpriteForChallengeTour      ( ModelClassType Sprite Sprite Sprite Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x70 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
