using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Loader                                   000186551710 ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer
    public partial class AnnounceBannerLoader
    {
        public WebTextureLoader?                        Loader                                  { get; set; }

        public static AnnounceBannerLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceBannerLoader();

            value.Loader                                    = GetObject<WebTextureLoader>(new IntPtr(p + 0x010), ReversePrism.DataModels.WebTextureLoader.FromPointer); // 0270DBDD96C8 0x10 Loader                      ( 000186551710 ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer )

            return value;
        }
    }
}
