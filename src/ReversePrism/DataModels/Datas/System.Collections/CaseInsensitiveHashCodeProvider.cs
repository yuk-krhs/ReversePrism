using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CompareInfo                              ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    public partial class CaseInsensitiveHashCodeProvider : DataModel
    {
        public CompareInfo?                             CompareInfo                             { get; set; }

        public static CaseInsensitiveHashCodeProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CaseInsensitiveHashCodeProvider() { Pointer= p0 };

            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompareInfo.FromPointer); // 0x10 CompareInfo                 ( ModelClassType CompareInfo CompareInfo CompareInfo Pointer )

            return value;
        }
    }
}
