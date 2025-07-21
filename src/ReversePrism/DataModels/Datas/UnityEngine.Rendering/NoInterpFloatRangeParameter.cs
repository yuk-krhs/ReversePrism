using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Min                                      ModelPrimitiveType float float float Single
    // 024 Max                                      ModelPrimitiveType float float float Single
    public partial class NoInterpFloatRangeParameter : DataModel
    {
        public float                                    Min                                     { get; set; }
        public float                                    Max                                     { get; set; }

        public static NoInterpFloatRangeParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoInterpFloatRangeParameter() { Pointer= p0 };

            value.Min                                       = GetSingle(new IntPtr(p + 0x020)); // 0x20 Min                         ( ModelPrimitiveType float float float Single )
            value.Max                                       = GetSingle(new IntPtr(p + 0x024)); // 0x24 Max                         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
