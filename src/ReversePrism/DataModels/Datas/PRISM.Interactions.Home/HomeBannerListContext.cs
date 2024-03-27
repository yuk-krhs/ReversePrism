using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 TextureLoader                            000186551C10 ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer
    public partial class HomeBannerListContext
    {
        public WebTextureLoader?                        TextureLoader                           { get; set; }

        public static HomeBannerListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBannerListContext();

            value.TextureLoader                             = GetObject<WebTextureLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.WebTextureLoader.FromPointer); // 027004F74940 0x38 TextureLoader               ( 000186551C10 ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer )

            return value;
        }
    }
}
