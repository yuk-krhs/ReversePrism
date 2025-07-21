using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Texture                                  ModelClassType Texture Texture Texture Pointer
    // 018 Dynamic                                  ModelPrimitiveType bool bool bool Bool
    // 01C RefCount                                 ModelPrimitiveType int int int Int32
    public partial class TextureInfo : DataModel
    {
        public Texture?                                 Texture                                 { get; set; }
        public bool                                     Dynamic                                 { get; set; }
        public int                                      RefCount                                { get; set; }

        public static TextureInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureInfo() { Pointer= p0 };

            value.Texture                                   = GetObject<Texture>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture.FromPointer); // 0x10 Texture                     ( ModelClassType Texture Texture Texture Pointer )
            value.Dynamic                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 Dynamic                     ( ModelPrimitiveType bool bool bool Bool )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C RefCount                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
