using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Font                                     ModelClassType Font Font Font Pointer
    // 018 FontAsset                                ModelClassType FontAsset FontAsset FontAsset Pointer
    public partial class FontReferenceMap : DataModel
    {
        public Font?                                    Font                                    { get; set; }
        public FontAsset?                               FontAsset                               { get; set; }

        public static FontReferenceMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontReferenceMap() { Pointer= p0 };

            value.Font                                      = GetObject<Font>(new IntPtr(p + 0x010), ReversePrism.DataModels.Font.FromPointer); // 0x10 Font                        ( ModelClassType Font Font Font Pointer )
            value.FontAsset                                 = GetObject<FontAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.FontAsset.FromPointer); // 0x18 FontAsset                   ( ModelClassType FontAsset FontAsset FontAsset Pointer )

            return value;
        }
    }
}
