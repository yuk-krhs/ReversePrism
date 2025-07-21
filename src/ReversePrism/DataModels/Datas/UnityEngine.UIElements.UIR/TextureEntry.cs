using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   ModelClassType Texture Texture Texture Pointer
    // 018 Actual                                   ModelEnumType TextureId TextureId TextureId Int32
    // 01C Replaced                                 ModelPrimitiveType bool bool bool Bool
    public partial class TextureEntry : DataModel
    {
        public Texture?                                 Source                                  { get; set; }
        public TextureId                                Actual                                  { get; set; }
        public bool                                     Replaced                                { get; set; }

        public static TextureEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureEntry() { Pointer= p0 };

            value.Source                                    = GetObject<Texture>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture.FromPointer); // 0x10 Source                      ( ModelClassType Texture Texture Texture Pointer )
            value.Actual                                    = (TextureId)GetInt32(new IntPtr(p + 0x018)); // 0x18 Actual                      ( ModelEnumType TextureId TextureId TextureId Int32 )
            value.Replaced                                  = GetBool(new IntPtr(p + 0x01C)); // 0x1C Replaced                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
