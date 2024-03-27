using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CompareInfo                              0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    public partial class CaseInsensitiveComparer
    {
        public CompareInfo?                             CompareInfo                             { get; set; }

        public static CaseInsensitiveComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CaseInsensitiveComparer();

            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompareInfo.FromPointer); // 0270D6D3E970 0x10 CompareInfo                 ( 0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer )

            return value;
        }
    }
}
