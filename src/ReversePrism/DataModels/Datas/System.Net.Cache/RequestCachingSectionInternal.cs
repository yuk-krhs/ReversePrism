using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisableAllCaching                        000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class RequestCachingSectionInternal : DataModel
    {
        public bool                                     DisableAllCaching                       { get; set; }

        public static RequestCachingSectionInternal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestCachingSectionInternal() { Pointer= p0 };

            value.DisableAllCaching                         = GetBool(new IntPtr(p + 0x010)); // 024667B4C228 0x10 DisableAllCaching           ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
