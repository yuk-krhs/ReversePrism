using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Min                                      0001865F59B0 ModelPrimitiveType int int int Int32
    // 024 Max                                      0001865F59B0 ModelPrimitiveType int int int Int32
    public partial class NoInterpClampedIntParameter
    {
        public int                                      Min                                     { get; set; }
        public int                                      Max                                     { get; set; }

        public static NoInterpClampedIntParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoInterpClampedIntParameter();

            value.Min                                       = GetInt32(new IntPtr(p + 0x020)); // 0270D92EF470 0x20 Min                         ( 0001865F59B0 ModelPrimitiveType int int int Int32 )
            value.Max                                       = GetInt32(new IntPtr(p + 0x024)); // 0270D92EF490 0x24 Max                         ( 0001865F59B0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
