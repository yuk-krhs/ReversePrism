using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CachedService                            000186715730 ModelClassType ICachedCostumeService ICachedCostumeService ICachedCostumeService Pointer
    public partial class CostumeService
    {
        public ICachedCostumeService?                   CachedService                           { get; set; }

        public static CostumeService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeService();

            value.CachedService                             = GetObject<ICachedCostumeService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICachedCostumeService.FromPointer); // 027005D26738 0x10 CachedService               ( 000186715730 ModelClassType ICachedCostumeService ICachedCostumeService ICachedCostumeService Pointer )

            return value;
        }
    }
}
