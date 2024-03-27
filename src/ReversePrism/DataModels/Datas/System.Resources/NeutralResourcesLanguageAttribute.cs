using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CultureName                              000186672F10 ModelPrimitiveType string string string String
    // 018 Location                                 00018669F150 ModelEnumType UltimateResourceFallbackLocation UltimateResourceFallbackLocation UltimateResourceFallbackLocation Int32
    public partial class NeutralResourcesLanguageAttribute
    {
        public string                                   CultureName                             { get; set; }
        public UltimateResourceFallbackLocation         Location                                { get; set; }

        public static NeutralResourcesLanguageAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NeutralResourcesLanguageAttribute();

            value.CultureName                               = GetString(new IntPtr(p + 0x010)); // 0270D6CC1950 0x10 CultureName                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.Location                                  = (UltimateResourceFallbackLocation)GetInt32(new IntPtr(p + 0x018)); // 0270D6CC1970 0x18 Location                    ( 00018669F150 ModelEnumType UltimateResourceFallbackLocation UltimateResourceFallbackLocation UltimateResourceFallbackLocation Int32 )

            return value;
        }
    }
}
