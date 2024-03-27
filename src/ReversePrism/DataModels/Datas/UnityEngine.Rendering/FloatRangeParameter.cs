using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Min                                      000186667B80 ModelPrimitiveType float float float Single
    // 024 Max                                      000186667B80 ModelPrimitiveType float float float Single
    public partial class FloatRangeParameter
    {
        public float                                    Min                                     { get; set; }
        public float                                    Max                                     { get; set; }

        public static FloatRangeParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FloatRangeParameter();

            value.Min                                       = GetSingle(new IntPtr(p + 0x020)); // 0270D92F0158 0x20 Min                         ( 000186667B80 ModelPrimitiveType float float float Single )
            value.Max                                       = GetSingle(new IntPtr(p + 0x024)); // 0270D92F0178 0x24 Max                         ( 000186667B80 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
