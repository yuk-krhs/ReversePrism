using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NormalImage                              ModelClassType Texture2D Texture2D Texture2D Pointer
    // 018 HighResolutionImage                      ModelClassType Texture2D Texture2D Texture2D Pointer
    public partial class ScalableImage : DataModel
    {
        public Texture2D?                               NormalImage                             { get; set; }
        public Texture2D?                               HighResolutionImage                     { get; set; }

        public static ScalableImage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScalableImage() { Pointer= p0 };

            value.NormalImage                               = GetObject<Texture2D>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture2D.FromPointer); // 0x10 NormalImage                 ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.HighResolutionImage                       = GetObject<Texture2D>(new IntPtr(p + 0x018), ReversePrism.DataModels.Texture2D.FromPointer); // 0x18 HighResolutionImage         ( ModelClassType Texture2D Texture2D Texture2D Pointer )

            return value;
        }
    }
}
