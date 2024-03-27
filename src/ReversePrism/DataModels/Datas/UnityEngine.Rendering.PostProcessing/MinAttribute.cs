using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      000186666F40 ModelPrimitiveType float float float Single
    public partial class MinAttribute
    {
        public float                                    Min                                     { get; set; }

        public static MinAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MinAttribute();

            value.Min                                       = GetSingle(new IntPtr(p + 0x010)); // 0270DB41EA30 0x10 Min                         ( 000186666F40 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
