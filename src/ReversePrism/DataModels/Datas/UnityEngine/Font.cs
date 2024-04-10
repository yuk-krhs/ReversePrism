using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 textureRebuilt                           Action`1<Font> IL2CPP_TYPE_GENERICINST
    // 018 M_FontTextureRebuildCallback             0001866C7470 ModelClassType FontTextureRebuildCallback FontTextureRebuildCallback FontTextureRebuildCallback Pointer
    public partial class Font : DataModel
    {
        public FontTextureRebuildCallback?              M_FontTextureRebuildCallback            { get; set; }

        public static Font? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Font() { Pointer= p0 };

            value.M_FontTextureRebuildCallback              = GetObject<FontTextureRebuildCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.FontTextureRebuildCallback.FromPointer); // 0245A2178058 0x18 M_FontTextureRebuildCallback ( 0001866C7470 ModelClassType FontTextureRebuildCallback FontTextureRebuildCallback FontTextureRebuildCallback Pointer )

            return value;
        }
    }
}
