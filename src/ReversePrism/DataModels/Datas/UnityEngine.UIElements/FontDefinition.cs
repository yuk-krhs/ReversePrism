using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Font                                   ModelClassType Font Font Font Pointer
    // 018 M_FontAsset                              ModelClassType FontAsset FontAsset FontAsset Pointer
    public partial class FontDefinition : DataModel
    {
        public Font?                                    M_Font                                  { get; set; }
        public FontAsset?                               M_FontAsset                             { get; set; }

        public static FontDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontDefinition() { Pointer= p0 };

            value.M_Font                                    = GetObject<Font>(new IntPtr(p + 0x010), ReversePrism.DataModels.Font.FromPointer); // 0x10 M_Font                      ( ModelClassType Font Font Font Pointer )
            value.M_FontAsset                               = GetObject<FontAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.FontAsset.FromPointer); // 0x18 M_FontAsset                 ( ModelClassType FontAsset FontAsset FontAsset Pointer )

            return value;
        }
    }
}
