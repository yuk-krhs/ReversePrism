using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_Texture                                ModelClassType Texture Texture Texture Pointer
    // 0E8 M_UVRect                                 ModelEnumType Rect Rect Rect Int32
    public partial class RawImage : DataModel
    {
        public Texture?                                 M_Texture                               { get; set; }
        public Rect                                     M_UVRect                                { get; set; }

        public static RawImage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RawImage() { Pointer= p0 };

            value.M_Texture                                 = GetObject<Texture>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Texture.FromPointer); // 0xE0 M_Texture                   ( ModelClassType Texture Texture Texture Pointer )
            value.M_UVRect                                  = (Rect)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 M_UVRect                    ( ModelEnumType Rect Rect Rect Int32 )

            return value;
        }
    }
}
