using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 TextureLoader                            000186551C10 ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer
    public partial class HomeBannerListContext : DataModel
    {
        public WebTextureLoader?                        TextureLoader                           { get; set; }

        public static HomeBannerListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBannerListContext() { Pointer= p0 };

            value.TextureLoader                             = GetObject<WebTextureLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.WebTextureLoader.FromPointer); // 0245A4F6B7C8 0x38 TextureLoader               ( 000186551C10 ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer )

            return value;
        }
    }
}
