using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Max                                      000186667B80 ModelPrimitiveType float float float Single
    public partial class MaxFloatParameter
    {
        public float                                    Max                                     { get; set; }

        public static MaxFloatParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaxFloatParameter();

            value.Max                                       = GetSingle(new IntPtr(p + 0x020)); // 0270D92EFAB8 0x20 Max                         ( 000186667B80 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
