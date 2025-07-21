using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_invariantCulture                       CultureAwareComparer IL2CPP_TYPE_CLASS
    // 008 s_invariantCultureIgnoreCase             CultureAwareComparer IL2CPP_TYPE_CLASS
    // 010 S_ordinal                                ModelClassType OrdinalCaseSensitiveComparer OrdinalCaseSensitiveComparer OrdinalCaseSensitiveComparer Pointer
    // 018 S_ordinalIgnoreCase                      ModelClassType OrdinalIgnoreCaseComparer OrdinalIgnoreCaseComparer OrdinalIgnoreCaseComparer Pointer
    public partial class StringComparer : DataModel
    {
        public OrdinalCaseSensitiveComparer?            S_ordinal                               { get; set; }
        public OrdinalIgnoreCaseComparer?               S_ordinalIgnoreCase                     { get; set; }

        public static StringComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringComparer() { Pointer= p0 };

            value.S_ordinal                                 = GetObject<OrdinalCaseSensitiveComparer>(new IntPtr(p + 0x010), ReversePrism.DataModels.OrdinalCaseSensitiveComparer.FromPointer); // 0x10 S_ordinal                   ( ModelClassType OrdinalCaseSensitiveComparer OrdinalCaseSensitiveComparer OrdinalCaseSensitiveComparer Pointer )
            value.S_ordinalIgnoreCase                       = GetObject<OrdinalIgnoreCaseComparer>(new IntPtr(p + 0x018), ReversePrism.DataModels.OrdinalIgnoreCaseComparer.FromPointer); // 0x18 S_ordinalIgnoreCase         ( ModelClassType OrdinalIgnoreCaseComparer OrdinalIgnoreCaseComparer OrdinalIgnoreCaseComparer Pointer )

            return value;
        }
    }
}
