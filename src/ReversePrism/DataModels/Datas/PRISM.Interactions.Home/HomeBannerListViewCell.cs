using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 TagImage                                 0001866CCDB0 ModelClassType Image Image Image Pointer
    // 068 BannerImage                              000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 070 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class HomeBannerListViewCell
    {
        public Image?                                   TagImage                                { get; set; }
        public RawImage?                                BannerImage                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static HomeBannerListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBannerListViewCell();

            value.TagImage                                  = GetObject<Image>(new IntPtr(p + 0x060), ReversePrism.DataModels.Image.FromPointer); // 027004F749A0 0x60 TagImage                    ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.BannerImage                               = GetObject<RawImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.RawImage.FromPointer); // 027004F749C0 0x68 BannerImage                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 027004F749E0 0x70 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
