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
    // 020 Disposed                                 ModelPrimitiveType bool bool bool Bool
    public partial class WebTextureLoader : DataModel
    {
        public bool                                     Disposed                                { get; set; }

        public static WebTextureLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebTextureLoader() { Pointer= p0 };

            value.Disposed                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
