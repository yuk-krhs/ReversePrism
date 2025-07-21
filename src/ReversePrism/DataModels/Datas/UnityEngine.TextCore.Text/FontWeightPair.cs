using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RegularTypeface                          ModelClassType FontAsset FontAsset FontAsset Pointer
    // 018 ItalicTypeface                           ModelClassType FontAsset FontAsset FontAsset Pointer
    public partial class FontWeightPair : DataModel
    {
        public FontAsset?                               RegularTypeface                         { get; set; }
        public FontAsset?                               ItalicTypeface                          { get; set; }

        public static FontWeightPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontWeightPair() { Pointer= p0 };

            value.RegularTypeface                           = GetObject<FontAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.FontAsset.FromPointer); // 0x10 RegularTypeface             ( ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.ItalicTypeface                            = GetObject<FontAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.FontAsset.FromPointer); // 0x18 ItalicTypeface              ( ModelClassType FontAsset FontAsset FontAsset Pointer )

            return value;
        }
    }
}
