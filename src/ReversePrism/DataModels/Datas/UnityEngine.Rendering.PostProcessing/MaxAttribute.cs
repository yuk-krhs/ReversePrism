using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Max                                      000186666F40 ModelPrimitiveType float float float Single
    public partial class MaxAttribute
    {
        public float                                    Max                                     { get; set; }

        public static MaxAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaxAttribute();

            value.Max                                       = GetSingle(new IntPtr(p + 0x010)); // 0270DB41E9A8 0x10 Max                         ( 000186666F40 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
