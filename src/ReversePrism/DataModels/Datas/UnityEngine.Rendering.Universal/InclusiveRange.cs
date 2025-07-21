using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    ModelPrimitiveType short short short Int16
    // 012 End                                      ModelPrimitiveType short short short Int16
    public partial class InclusiveRange : DataModel
    {
        public short                                    Start                                   { get; set; }
        public short                                    End                                     { get; set; }

        public static InclusiveRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InclusiveRange() { Pointer= p0 };

            value.Start                                     = GetInt16(new IntPtr(p + 0x010)); // 0x10 Start                       ( ModelPrimitiveType short short short Int16 )
            value.End                                       = GetInt16(new IntPtr(p + 0x012)); // 0x12 End                         ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
