using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Speed                                    ModelPrimitiveType int int int Int32
    // 014 Delay                                    ModelPrimitiveType int int int Int32
    // 018 Sense                                    ModelPrimitiveType int int int Int32
    public partial class AutoNeckParam : DataModel
    {
        public int                                      Speed                                   { get; set; }
        public int                                      Delay                                   { get; set; }
        public int                                      Sense                                   { get; set; }

        public static AutoNeckParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoNeckParam() { Pointer= p0 };

            value.Speed                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Speed                       ( ModelPrimitiveType int int int Int32 )
            value.Delay                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Delay                       ( ModelPrimitiveType int int int Int32 )
            value.Sense                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Sense                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
