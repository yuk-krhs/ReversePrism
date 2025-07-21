using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 TagImage                                 ModelClassType Image Image Image Pointer
    // 068 BannerImage                              ModelClassType RawImage RawImage RawImage Pointer
    // 070 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class HomeBannerListViewCell : DataModel
    {
        public Image?                                   TagImage                                { get; set; }
        public RawImage?                                BannerImage                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static HomeBannerListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBannerListViewCell() { Pointer= p0 };

            value.TagImage                                  = GetObject<Image>(new IntPtr(p + 0x060), ReversePrism.DataModels.Image.FromPointer); // 0x60 TagImage                    ( ModelClassType Image Image Image Pointer )
            value.BannerImage                               = GetObject<RawImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.RawImage.FromPointer); // 0x68 BannerImage                 ( ModelClassType RawImage RawImage RawImage Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x70 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
