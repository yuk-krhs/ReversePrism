using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultState                           ModelPrimitiveType bool bool bool Bool
    public partial class AdaptiveBatching : DataModel
    {
        public bool                                     M_DefaultState                          { get; set; }

        public static AdaptiveBatching? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveBatching() { Pointer= p0 };

            value.M_DefaultState                            = GetBool(new IntPtr(p + 0x040)); // 0x40 M_DefaultState              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
