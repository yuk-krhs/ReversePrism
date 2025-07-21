using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 M_moviePath                              ModelPrimitiveType string string string String
    // 0B0 M_movieData                              ModelClassType TextAsset TextAsset TextAsset Pointer
    public partial class CriManaClip : DataModel
    {
        public string                                   M_moviePath                             { get; set; }
        public TextAsset?                               M_movieData                             { get; set; }

        public static CriManaClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaClip() { Pointer= p0 };

            value.M_moviePath                               = GetString(new IntPtr(p + 0x0A8)); // 0xA8 M_moviePath                 ( ModelPrimitiveType string string string String )
            value.M_movieData                               = GetObject<TextAsset>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.TextAsset.FromPointer); // 0xB0 M_movieData                 ( ModelClassType TextAsset TextAsset TextAsset Pointer )

            return value;
        }
    }
}
