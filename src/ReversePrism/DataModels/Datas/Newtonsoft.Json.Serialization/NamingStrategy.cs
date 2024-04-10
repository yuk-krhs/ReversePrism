using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProcessDictionaryKeys                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 ProcessExtensionDataNames                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 012 OverrideSpecifiedNames                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NamingStrategy : DataModel
    {
        public bool                                     ProcessDictionaryKeys                   { get; set; }
        public bool                                     ProcessExtensionDataNames               { get; set; }
        public bool                                     OverrideSpecifiedNames                  { get; set; }

        public static NamingStrategy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamingStrategy() { Pointer= p0 };

            value.ProcessDictionaryKeys                     = GetBool(new IntPtr(p + 0x010)); // 0245A665E718 0x10 ProcessDictionaryKeys       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProcessExtensionDataNames                 = GetBool(new IntPtr(p + 0x011)); // 0245A665E738 0x11 ProcessExtensionDataNames   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverrideSpecifiedNames                    = GetBool(new IntPtr(p + 0x012)); // 0245A665E758 0x12 OverrideSpecifiedNames      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
