using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    ModelPrimitiveType int int int Int32
    // 014 Length                                   ModelPrimitiveType int int int Int32
    public partial class RangeInt : DataModel
    {
        public int                                      Start                                   { get; set; }
        public int                                      Length                                  { get; set; }

        public static RangeInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangeInt() { Pointer= p0 };

            value.Start                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Start                       ( ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Length                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
