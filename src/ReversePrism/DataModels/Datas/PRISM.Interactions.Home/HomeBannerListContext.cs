using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 TextureLoader                            ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer
    public partial class HomeBannerListContext : DataModel
    {
        public WebTextureLoader?                        TextureLoader                           { get; set; }

        public static HomeBannerListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBannerListContext() { Pointer= p0 };

            value.TextureLoader                             = GetObject<WebTextureLoader>(new IntPtr(p + 0x040), ReversePrism.DataModels.WebTextureLoader.FromPointer); // 0x40 TextureLoader               ( ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer )

            return value;
        }
    }
}
