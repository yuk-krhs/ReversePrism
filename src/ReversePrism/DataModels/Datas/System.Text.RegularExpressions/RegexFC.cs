using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cc                                       ModelClassType RegexCharClass RegexCharClass RegexCharClass Pointer
    // 018 Nullable                                 ModelPrimitiveType bool bool bool Bool
    // 019 CaseInsensitive                          ModelPrimitiveType bool bool bool Bool
    public partial class RegexFC : DataModel
    {
        public RegexCharClass?                          Cc                                      { get; set; }
        public bool                                     Nullable                                { get; set; }
        public bool                                     CaseInsensitive                         { get; set; }

        public static RegexFC? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexFC() { Pointer= p0 };

            value.Cc                                        = GetObject<RegexCharClass>(new IntPtr(p + 0x010), ReversePrism.DataModels.RegexCharClass.FromPointer); // 0x10 Cc                          ( ModelClassType RegexCharClass RegexCharClass RegexCharClass Pointer )
            value.Nullable                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 Nullable                    ( ModelPrimitiveType bool bool bool Bool )
            value.CaseInsensitive                           = GetBool(new IntPtr(p + 0x019)); // 0x19 CaseInsensitive             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
