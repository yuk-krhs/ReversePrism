using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BlueNoise64LTex                          ModelClassType Texture2D Texture2D Texture2D Pointer
    // 018 BayerMatrixTex                           ModelClassType Texture2D Texture2D Texture2D Pointer
    public partial class TextureResources : DataModel
    {
        public Texture2D?                               BlueNoise64LTex                         { get; set; }
        public Texture2D?                               BayerMatrixTex                          { get; set; }

        public static TextureResources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureResources() { Pointer= p0 };

            value.BlueNoise64LTex                           = GetObject<Texture2D>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture2D.FromPointer); // 0x10 BlueNoise64LTex             ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.BayerMatrixTex                            = GetObject<Texture2D>(new IntPtr(p + 0x018), ReversePrism.DataModels.Texture2D.FromPointer); // 0x18 BayerMatrixTex              ( ModelClassType Texture2D Texture2D Texture2D Pointer )

            return value;
        }
    }
}
