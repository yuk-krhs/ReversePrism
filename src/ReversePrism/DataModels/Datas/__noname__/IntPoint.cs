using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType long long long Int64
    // 018 Y                                        ModelPrimitiveType long long long Int64
    public partial class IntPoint : DataModel
    {
        public long                                     X                                       { get; set; }
        public long                                     Y                                       { get; set; }

        public static IntPoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntPoint() { Pointer= p0 };

            value.X                                         = GetInt64(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType long long long Int64 )
            value.Y                                         = GetInt64(new IntPtr(p + 0x018)); // 0x18 Y                           ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
