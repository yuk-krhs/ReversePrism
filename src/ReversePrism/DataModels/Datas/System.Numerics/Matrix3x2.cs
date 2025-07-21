using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M11                                      ModelPrimitiveType float float float Single
    // 014 M12                                      ModelPrimitiveType float float float Single
    // 018 M21                                      ModelPrimitiveType float float float Single
    // 01C M22                                      ModelPrimitiveType float float float Single
    // 020 M31                                      ModelPrimitiveType float float float Single
    // 024 M32                                      ModelPrimitiveType float float float Single
    // 000 _identity                                Matrix3x2 IL2CPP_TYPE_VALUETYPE
    public partial class Matrix3x2 : DataModel
    {
        public float                                    M11                                     { get; set; }
        public float                                    M12                                     { get; set; }
        public float                                    M21                                     { get; set; }
        public float                                    M22                                     { get; set; }
        public float                                    M31                                     { get; set; }
        public float                                    M32                                     { get; set; }

        public static Matrix3x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Matrix3x2() { Pointer= p0 };

            value.M11                                       = GetSingle(new IntPtr(p + 0x010)); // 0x10 M11                         ( ModelPrimitiveType float float float Single )
            value.M12                                       = GetSingle(new IntPtr(p + 0x014)); // 0x14 M12                         ( ModelPrimitiveType float float float Single )
            value.M21                                       = GetSingle(new IntPtr(p + 0x018)); // 0x18 M21                         ( ModelPrimitiveType float float float Single )
            value.M22                                       = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M22                         ( ModelPrimitiveType float float float Single )
            value.M31                                       = GetSingle(new IntPtr(p + 0x020)); // 0x20 M31                         ( ModelPrimitiveType float float float Single )
            value.M32                                       = GetSingle(new IntPtr(p + 0x024)); // 0x24 M32                         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
