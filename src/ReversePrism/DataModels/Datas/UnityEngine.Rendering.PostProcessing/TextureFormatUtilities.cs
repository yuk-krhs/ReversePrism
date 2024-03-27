using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_FormatAliasMap                         Dictionary`2<int, RenderTextureFormat> IL2CPP_TYPE_GENERICINST
    // 008 s_SupportedRenderTextureFormats          Dictionary`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 010 s_SupportedTextureFormats                Dictionary`2<int, bool> IL2CPP_TYPE_GENERICINST
    public partial class TextureFormatUtilities
    {

        public static TextureFormatUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureFormatUtilities();


            return value;
        }
    }
}
