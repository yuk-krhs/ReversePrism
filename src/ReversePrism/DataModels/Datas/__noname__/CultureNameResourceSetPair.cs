using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastCultureName                          ModelPrimitiveType string string string String
    // 018 LastResourceSet                          ModelClassType ResourceSet ResourceSet ResourceSet Pointer
    public partial class CultureNameResourceSetPair : DataModel
    {
        public string                                   LastCultureName                         { get; set; }
        public ResourceSet?                             LastResourceSet                         { get; set; }

        public static CultureNameResourceSetPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CultureNameResourceSetPair() { Pointer= p0 };

            value.LastCultureName                           = GetString(new IntPtr(p + 0x010)); // 0x10 LastCultureName             ( ModelPrimitiveType string string string String )
            value.LastResourceSet                           = GetObject<ResourceSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.ResourceSet.FromPointer); // 0x18 LastResourceSet             ( ModelClassType ResourceSet ResourceSet ResourceSet Pointer )

            return value;
        }
    }
}
