using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RegularTypeface                          ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 018 ItalicTypeface                           ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    public partial class TMP_FontWeightPair : DataModel
    {
        public TMP_FontAsset?                           RegularTypeface                         { get; set; }
        public TMP_FontAsset?                           ItalicTypeface                          { get; set; }

        public static TMP_FontWeightPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_FontWeightPair() { Pointer= p0 };

            value.RegularTypeface                           = GetObject<TMP_FontAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0x10 RegularTypeface             ( ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.ItalicTypeface                            = GetObject<TMP_FontAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0x18 ItalicTypeface              ( ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )

            return value;
        }
    }
}
