using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Texture                                  ModelClassType Texture2D Texture2D Texture2D Pointer
    public partial class SecondarySpriteTexture : DataModel
    {
        public string                                   Name                                    { get; set; }
        public Texture2D?                               Texture                                 { get; set; }

        public static SecondarySpriteTexture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SecondarySpriteTexture() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Texture                                   = GetObject<Texture2D>(new IntPtr(p + 0x018), ReversePrism.DataModels.Texture2D.FromPointer); // 0x18 Texture                     ( ModelClassType Texture2D Texture2D Texture2D Pointer )

            return value;
        }
    }
}
