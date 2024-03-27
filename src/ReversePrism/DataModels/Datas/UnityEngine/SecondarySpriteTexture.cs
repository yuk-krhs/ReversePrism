using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Texture                                  000186685F20 ModelClassType Texture2D Texture2D Texture2D Pointer
    public partial class SecondarySpriteTexture
    {
        public string                                   Name                                    { get; set; }
        public Texture2D?                               Texture                                 { get; set; }

        public static SecondarySpriteTexture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SecondarySpriteTexture();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270068BFD98 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Texture                                   = GetObject<Texture2D>(new IntPtr(p + 0x018), ReversePrism.DataModels.Texture2D.FromPointer); // 0270068BFDB8 0x18 Texture                     ( 000186685F20 ModelClassType Texture2D Texture2D Texture2D Pointer )

            return value;
        }
    }
}
