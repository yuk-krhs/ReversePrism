using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ValidCompareMaskOffFlags                 CompareOptions IL2CPP_TYPE_VALUETYPE
    // 010 CompareInfo                              ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 018 Options                                  ModelEnumType CompareOptions CompareOptions CompareOptions Int32
    public partial class CultureAwareComparer : DataModel
    {
        public CompareInfo?                             CompareInfo                             { get; set; }
        public CompareOptions                           Options                                 { get; set; }

        public static CultureAwareComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CultureAwareComparer() { Pointer= p0 };

            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompareInfo.FromPointer); // 0x10 CompareInfo                 ( ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.Options                                   = (CompareOptions)GetInt32(new IntPtr(p + 0x018)); // 0x18 Options                     ( ModelEnumType CompareOptions CompareOptions CompareOptions Int32 )

            return value;
        }
    }
}
