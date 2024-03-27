using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        000186666050 ModelPrimitiveType float float float Single
    // 014 Y                                        000186666050 ModelPrimitiveType float float float Single
    public partial class ScaleVector2Processor
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }

        public static ScaleVector2Processor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScaleVector2Processor();

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 0270D783C078 0x10 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 0270D783C098 0x14 Y                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
