using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProcessDictionaryKeys                    ModelPrimitiveType bool bool bool Bool
    // 011 ProcessExtensionDataNames                ModelPrimitiveType bool bool bool Bool
    // 012 OverrideSpecifiedNames                   ModelPrimitiveType bool bool bool Bool
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

            value.ProcessDictionaryKeys                     = GetBool(new IntPtr(p + 0x010)); // 0x10 ProcessDictionaryKeys       ( ModelPrimitiveType bool bool bool Bool )
            value.ProcessExtensionDataNames                 = GetBool(new IntPtr(p + 0x011)); // 0x11 ProcessExtensionDataNames   ( ModelPrimitiveType bool bool bool Bool )
            value.OverrideSpecifiedNames                    = GetBool(new IntPtr(p + 0x012)); // 0x12 OverrideSpecifiedNames      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
