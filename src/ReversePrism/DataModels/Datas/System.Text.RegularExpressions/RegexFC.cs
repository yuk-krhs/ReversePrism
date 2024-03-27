using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cc                                       00018663C700 ModelClassType RegexCharClass RegexCharClass RegexCharClass Pointer
    // 018 Nullable                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 019 CaseInsensitive                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RegexFC
    {
        public RegexCharClass?                          Cc                                      { get; set; }
        public bool                                     Nullable                                { get; set; }
        public bool                                     CaseInsensitive                         { get; set; }

        public static RegexFC? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexFC();

            value.Cc                                        = GetObject<RegexCharClass>(new IntPtr(p + 0x010), ReversePrism.DataModels.RegexCharClass.FromPointer); // 027003428F38 0x10 Cc                          ( 00018663C700 ModelClassType RegexCharClass RegexCharClass RegexCharClass Pointer )
            value.Nullable                                  = GetBool(new IntPtr(p + 0x018)); // 027003428F58 0x18 Nullable                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CaseInsensitive                           = GetBool(new IntPtr(p + 0x019)); // 027003428F78 0x19 CaseInsensitive             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
