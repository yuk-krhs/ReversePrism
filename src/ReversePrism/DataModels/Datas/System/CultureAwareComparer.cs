using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CompareInfo                              0001865EB660 ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 018 Options                                  0001865EBFA0 ModelEnumType CompareOptions CompareOptions CompareOptions Int32
    public partial class CultureAwareComparer
    {
        public CompareInfo?                             CompareInfo                             { get; set; }
        public CompareOptions                           Options                                 { get; set; }

        public static CultureAwareComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CultureAwareComparer();

            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompareInfo.FromPointer); // 027003CC85D0 0x10 CompareInfo                 ( 0001865EB660 ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.Options                                   = (CompareOptions)GetInt32(new IntPtr(p + 0x018)); // 027003CC85F0 0x18 Options                     ( 0001865EBFA0 ModelEnumType CompareOptions CompareOptions CompareOptions Int32 )

            return value;
        }
    }
}
