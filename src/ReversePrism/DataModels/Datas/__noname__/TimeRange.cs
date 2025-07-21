using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    ModelPrimitiveType float float float Single
    // 014 End                                      ModelPrimitiveType float float float Single
    public partial class TimeRange : DataModel
    {
        public float                                    Start                                   { get; set; }
        public float                                    End                                     { get; set; }

        public static TimeRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeRange() { Pointer= p0 };

            value.Start                                     = GetSingle(new IntPtr(p + 0x010)); // 0x10 Start                       ( ModelPrimitiveType float float float Single )
            value.End                                       = GetSingle(new IntPtr(p + 0x014)); // 0x14 End                         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
