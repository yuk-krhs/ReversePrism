using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 A                                        ModelPrimitiveType int int int Int32
    // 014 B                                        ModelPrimitiveType float float float Single
    public partial class Pair : DataModel
    {
        public int                                      A                                       { get; set; }
        public float                                    B                                       { get; set; }

        public static Pair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Pair() { Pointer= p0 };

            value.A                                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 A                           ( ModelPrimitiveType int int int Int32 )
            value.B                                         = GetSingle(new IntPtr(p + 0x014)); // 0x14 B                           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
