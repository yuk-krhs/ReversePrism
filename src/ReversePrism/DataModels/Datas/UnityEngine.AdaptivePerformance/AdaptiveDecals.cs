using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultDecalsDistance                  0001866656B0 ModelPrimitiveType float float float Single
    public partial class AdaptiveDecals
    {
        public float                                    M_DefaultDecalsDistance                 { get; set; }

        public static AdaptiveDecals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveDecals();

            value.M_DefaultDecalsDistance                   = GetSingle(new IntPtr(p + 0x040)); // 0270DB6899F8 0x40 M_DefaultDecalsDistance     ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
