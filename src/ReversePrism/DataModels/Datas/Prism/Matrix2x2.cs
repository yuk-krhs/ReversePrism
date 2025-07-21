using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 A                                        ModelPrimitiveType float float float Single
    // 014 B                                        ModelPrimitiveType float float float Single
    // 018 C                                        ModelPrimitiveType float float float Single
    // 01C D                                        ModelPrimitiveType float float float Single
    public partial class Matrix2x2 : DataModel
    {
        public float                                    A                                       { get; set; }
        public float                                    B                                       { get; set; }
        public float                                    C                                       { get; set; }
        public float                                    D                                       { get; set; }

        public static Matrix2x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Matrix2x2() { Pointer= p0 };

            value.A                                         = GetSingle(new IntPtr(p + 0x010)); // 0x10 A                           ( ModelPrimitiveType float float float Single )
            value.B                                         = GetSingle(new IntPtr(p + 0x014)); // 0x14 B                           ( ModelPrimitiveType float float float Single )
            value.C                                         = GetSingle(new IntPtr(p + 0x018)); // 0x18 C                           ( ModelPrimitiveType float float float Single )
            value.D                                         = GetSingle(new IntPtr(p + 0x01C)); // 0x1C D                           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
