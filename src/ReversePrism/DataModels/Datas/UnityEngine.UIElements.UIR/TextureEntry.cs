using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   00018664D720 ModelClassType Texture Texture Texture Pointer
    // 018 Actual                                   000186688130 ModelEnumType TextureId TextureId TextureId Int32
    // 01C Replaced                                 000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class TextureEntry
    {
        public Texture?                                 Source                                  { get; set; }
        public TextureId                                Actual                                  { get; set; }
        public bool                                     Replaced                                { get; set; }

        public static TextureEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureEntry();

            value.Source                                    = GetObject<Texture>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture.FromPointer); // 027006873560 0x10 Source                      ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.Actual                                    = (TextureId)GetInt32(new IntPtr(p + 0x018)); // 027006873580 0x18 Actual                      ( 000186688130 ModelEnumType TextureId TextureId TextureId Int32 )
            value.Replaced                                  = GetBool(new IntPtr(p + 0x01C)); // 0270068735A0 0x1C Replaced                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
