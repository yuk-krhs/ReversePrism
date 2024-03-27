using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextureRegistry                          000186656990 ModelClassType TextureRegistry TextureRegistry TextureRegistry Pointer
    public partial class AtlasBase
    {
        public TextureRegistry?                         TextureRegistry                         { get; set; }

        public static AtlasBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AtlasBase();

            value.TextureRegistry                           = GetObject<TextureRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextureRegistry.FromPointer); // 0270066DF990 0x10 TextureRegistry             ( 000186656990 ModelClassType TextureRegistry TextureRegistry TextureRegistry Pointer )

            return value;
        }
    }
}
