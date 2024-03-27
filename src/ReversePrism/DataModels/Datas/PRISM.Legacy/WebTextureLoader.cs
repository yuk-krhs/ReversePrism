using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CacheDirectoryName                       string IL2CPP_TYPE_STRING
    // 010 downloadings                             HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 018 loadedTextures                           Dictionary`2<string, Texture2D> IL2CPP_TYPE_GENERICINST
    // 020 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class WebTextureLoader
    {
        public bool                                     Disposed                                { get; set; }

        public static WebTextureLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebTextureLoader();

            value.Disposed                                  = GetBool(new IntPtr(p + 0x020)); // 027005AB8EC0 0x20 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
