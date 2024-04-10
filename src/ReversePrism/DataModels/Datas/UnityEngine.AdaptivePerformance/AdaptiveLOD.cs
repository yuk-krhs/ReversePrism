using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultLodBias                         0001866656B0 ModelPrimitiveType float float float Single
    public partial class AdaptiveLOD : DataModel
    {
        public float                                    M_DefaultLodBias                        { get; set; }

        public static AdaptiveLOD? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveLOD() { Pointer= p0 };

            value.M_DefaultLodBias                          = GetSingle(new IntPtr(p + 0x040)); // 02466B715D78 0x40 M_DefaultLodBias            ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
