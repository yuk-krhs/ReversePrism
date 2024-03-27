using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastCultureName                          0001866722E0 ModelPrimitiveType string string string String
    // 018 LastResourceSet                          00018665B2B0 ModelClassType ResourceSet ResourceSet ResourceSet Pointer
    public partial class CultureNameResourceSetPair
    {
        public string                                   LastCultureName                         { get; set; }
        public ResourceSet?                             LastResourceSet                         { get; set; }

        public static CultureNameResourceSetPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CultureNameResourceSetPair();

            value.LastCultureName                           = GetString(new IntPtr(p + 0x010)); // 0270D6CCFF48 0x10 LastCultureName             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.LastResourceSet                           = GetObject<ResourceSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.ResourceSet.FromPointer); // 0270D6CCFF68 0x18 LastResourceSet             ( 00018665B2B0 ModelClassType ResourceSet ResourceSet ResourceSet Pointer )

            return value;
        }
    }
}
