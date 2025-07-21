using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_LowerBound                             ModelPrimitiveType int int int Int32
    // 014 M_UpperBound                             ModelPrimitiveType int int int Int32
    // 000 k_MinimumBound                           int IL2CPP_TYPE_I4
    // 000 minimumBound                             int IL2CPP_TYPE_I4
    // 000 k_MaximumBound                           int IL2CPP_TYPE_I4
    // 004 maximumBound                             int IL2CPP_TYPE_I4
    public partial class RenderQueueRange : DataModel
    {
        public int                                      M_LowerBound                            { get; set; }
        public int                                      M_UpperBound                            { get; set; }

        public static RenderQueueRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderQueueRange() { Pointer= p0 };

            value.M_LowerBound                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_LowerBound                ( ModelPrimitiveType int int int Int32 )
            value.M_UpperBound                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_UpperBound                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
