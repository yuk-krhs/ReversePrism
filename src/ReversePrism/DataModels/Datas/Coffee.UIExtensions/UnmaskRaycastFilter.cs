using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_TargetUnmask                           000186735050 ModelClassType Unmask Unmask Unmask Pointer
    public partial class UnmaskRaycastFilter
    {
        public Unmask?                                  M_TargetUnmask                          { get; set; }

        public static UnmaskRaycastFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnmaskRaycastFilter();

            value.M_TargetUnmask                            = GetObject<Unmask>(new IntPtr(p + 0x020), ReversePrism.DataModels.Unmask.FromPointer); // 0270DBF1E438 0x20 M_TargetUnmask              ( 000186735050 ModelClassType Unmask Unmask Unmask Pointer )

            return value;
        }
    }
}
