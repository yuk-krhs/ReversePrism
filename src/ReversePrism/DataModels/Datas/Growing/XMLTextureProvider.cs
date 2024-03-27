using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _textures                                Dictionary`2<string, Texture2D> IL2CPP_TYPE_GENERICINST
    // 018 RequestingUrlHashes                      000185D313A8 ModelClassListType List`1<TextureRequest> List`1<TextureRequest> List<TextureRequest> Pointer
    public partial class XMLTextureProvider
    {
        public List<TextureRequest>?                    RequestingUrlHashes                     { get; set; }

        public static XMLTextureProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLTextureProvider();

            value.RequestingUrlHashes                       = GetObjectList<TextureRequest>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextureRequest.FromPointer); // 0270D4B5DA40 0x18 RequestingUrlHashes         ( 000185D313A8 ModelClassListType List`1<TextureRequest> List`1<TextureRequest> List<TextureRequest> Pointer )

            return value;
        }
    }
}
