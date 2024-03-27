using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Max                                      0001865F59B0 ModelPrimitiveType int int int Int32
    public partial class MaxIntParameter
    {
        public int                                      Max                                     { get; set; }

        public static MaxIntParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaxIntParameter();

            value.Max                                       = GetInt32(new IntPtr(p + 0x020)); // 0270D92EEFB0 0x20 Max                         ( 0001865F59B0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
