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
    public partial class Vector2 : DataModel
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }

        public static Vector2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector2() { Pointer= p0 };

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 0245A44FD2B8 0x10 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 0245A44FD2D8 0x14 Y                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
