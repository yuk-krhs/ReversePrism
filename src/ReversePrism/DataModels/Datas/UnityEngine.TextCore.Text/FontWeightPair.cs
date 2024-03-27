using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RegularTypeface                          0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer
    // 018 ItalicTypeface                           0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer
    public partial class FontWeightPair
    {
        public FontAsset?                               RegularTypeface                         { get; set; }
        public FontAsset?                               ItalicTypeface                          { get; set; }

        public static FontWeightPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontWeightPair();

            value.RegularTypeface                           = GetObject<FontAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.FontAsset.FromPointer); // 0270068E7128 0x10 RegularTypeface             ( 0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.ItalicTypeface                            = GetObject<FontAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.FontAsset.FromPointer); // 0270068E7148 0x18 ItalicTypeface              ( 0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer )

            return value;
        }
    }
}
