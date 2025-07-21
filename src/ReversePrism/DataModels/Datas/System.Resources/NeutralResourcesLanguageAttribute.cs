using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CultureName                              ModelPrimitiveType string string string String
    // 018 Location                                 ModelEnumType UltimateResourceFallbackLocation UltimateResourceFallbackLocation UltimateResourceFallbackLocation Int32
    public partial class NeutralResourcesLanguageAttribute : DataModel
    {
        public string                                   CultureName                             { get; set; }
        public UltimateResourceFallbackLocation         Location                                { get; set; }

        public static NeutralResourcesLanguageAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NeutralResourcesLanguageAttribute() { Pointer= p0 };

            value.CultureName                               = GetString(new IntPtr(p + 0x010)); // 0x10 CultureName                 ( ModelPrimitiveType string string string String )
            value.Location                                  = (UltimateResourceFallbackLocation)GetInt32(new IntPtr(p + 0x018)); // 0x18 Location                    ( ModelEnumType UltimateResourceFallbackLocation UltimateResourceFallbackLocation UltimateResourceFallbackLocation Int32 )

            return value;
        }
    }
}
