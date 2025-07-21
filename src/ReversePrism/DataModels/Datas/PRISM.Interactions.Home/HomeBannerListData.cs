using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Banner                                   ModelClassType IBannerStatus IBannerStatus IBannerStatus Pointer
    // 018 TagSprite                                ModelClassType Sprite Sprite Sprite Pointer
    public partial class HomeBannerListData : DataModel
    {
        public IBannerStatus?                           Banner                                  { get; set; }
        public Sprite?                                  TagSprite                               { get; set; }

        public static HomeBannerListData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBannerListData() { Pointer= p0 };

            value.Banner                                    = GetObject<IBannerStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IBannerStatus.FromPointer); // 0x10 Banner                      ( ModelClassType IBannerStatus IBannerStatus IBannerStatus Pointer )
            value.TagSprite                                 = GetObject<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0x18 TagSprite                   ( ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
