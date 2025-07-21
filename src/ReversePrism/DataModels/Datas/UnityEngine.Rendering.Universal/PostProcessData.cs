using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Shaders                                  ModelClassType ShaderResources ShaderResources ShaderResources Pointer
    // 020 Textures                                 ModelClassType TextureResources TextureResources TextureResources Pointer
    public partial class PostProcessData : DataModel
    {
        public ShaderResources?                         Shaders                                 { get; set; }
        public TextureResources?                        Textures                                { get; set; }

        public static PostProcessData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessData() { Pointer= p0 };

            value.Shaders                                   = GetObject<ShaderResources>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShaderResources.FromPointer); // 0x18 Shaders                     ( ModelClassType ShaderResources ShaderResources ShaderResources Pointer )
            value.Textures                                  = GetObject<TextureResources>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextureResources.FromPointer); // 0x20 Textures                    ( ModelClassType TextureResources TextureResources TextureResources Pointer )

            return value;
        }
    }
}
