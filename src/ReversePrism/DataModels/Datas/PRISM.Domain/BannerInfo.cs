using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BannerGenre                              00018670E1D0 ModelClassType IBannerGenreStatus IBannerGenreStatus IBannerGenreStatus Pointer
    // 018 Banner                                   00018670E980 ModelClassType IBannerStatus IBannerStatus IBannerStatus Pointer
    public partial class BannerInfo
    {
        public IBannerGenreStatus?                      BannerGenre                             { get; set; }
        public IBannerStatus?                           Banner                                  { get; set; }

        public static BannerInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BannerInfo();

            value.BannerGenre                               = GetObject<IBannerGenreStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IBannerGenreStatus.FromPointer); // 0270D326AF88 0x10 BannerGenre                 ( 00018670E1D0 ModelClassType IBannerGenreStatus IBannerGenreStatus IBannerGenreStatus Pointer )
            value.Banner                                    = GetObject<IBannerStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IBannerStatus.FromPointer); // 0270D326AFA8 0x18 Banner                      ( 00018670E980 ModelClassType IBannerStatus IBannerStatus IBannerStatus Pointer )

            return value;
        }
    }
}
