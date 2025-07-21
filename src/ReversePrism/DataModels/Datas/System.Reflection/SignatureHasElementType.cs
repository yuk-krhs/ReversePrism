using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ElementType                              ModelClassType SignatureType SignatureType SignatureType Pointer
    public partial class SignatureHasElementType : DataModel
    {
        public SignatureType?                           ElementType                             { get; set; }

        public static SignatureHasElementType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SignatureHasElementType() { Pointer= p0 };

            value.ElementType                               = GetObject<SignatureType>(new IntPtr(p + 0x018), ReversePrism.DataModels.SignatureType.FromPointer); // 0x18 ElementType                 ( ModelClassType SignatureType SignatureType SignatureType Pointer )

            return value;
        }
    }
}
