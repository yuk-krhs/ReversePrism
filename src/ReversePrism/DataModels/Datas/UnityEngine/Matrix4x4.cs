using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M00                                      000186666050 ModelPrimitiveType float float float Single
    // 014 M10                                      000186666050 ModelPrimitiveType float float float Single
    // 018 M20                                      000186666050 ModelPrimitiveType float float float Single
    // 01C M30                                      000186666050 ModelPrimitiveType float float float Single
    // 020 M01                                      000186666050 ModelPrimitiveType float float float Single
    // 024 M11                                      000186666050 ModelPrimitiveType float float float Single
    // 028 M21                                      000186666050 ModelPrimitiveType float float float Single
    // 02C M31                                      000186666050 ModelPrimitiveType float float float Single
    // 030 M02                                      000186666050 ModelPrimitiveType float float float Single
    // 034 M12                                      000186666050 ModelPrimitiveType float float float Single
    // 038 M22                                      000186666050 ModelPrimitiveType float float float Single
    // 03C M32                                      000186666050 ModelPrimitiveType float float float Single
    // 040 M03                                      000186666050 ModelPrimitiveType float float float Single
    // 044 M13                                      000186666050 ModelPrimitiveType float float float Single
    // 048 M23                                      000186666050 ModelPrimitiveType float float float Single
    // 04C M33                                      000186666050 ModelPrimitiveType float float float Single
    // 000 zeroMatrix                               Matrix4x4 IL2CPP_TYPE_VALUETYPE
    // 040 IdentityMatrix                           00018660E700 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    public partial class Matrix4x4 : DataModel
    {
        public float                                    M00                                     { get; set; }
        public float                                    M10                                     { get; set; }
        public float                                    M20                                     { get; set; }
        public float                                    M30                                     { get; set; }
        public float                                    M01                                     { get; set; }
        public float                                    M11                                     { get; set; }
        public float                                    M21                                     { get; set; }
        public float                                    M31                                     { get; set; }
        public float                                    M02                                     { get; set; }
        public float                                    M12                                     { get; set; }
        public float                                    M22                                     { get; set; }
        public float                                    M32                                     { get; set; }
        public float                                    M03                                     { get; set; }
        public float                                    M13                                     { get; set; }
        public float                                    M23                                     { get; set; }
        public float                                    M33                                     { get; set; }
        public Matrix4x4                                IdentityMatrix                          { get; set; }

        public static Matrix4x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Matrix4x4() { Pointer= p0 };

            value.M00                                       = GetSingle(new IntPtr(p + 0x010)); // 0245A15EEB20 0x10 M00                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M10                                       = GetSingle(new IntPtr(p + 0x014)); // 0245A15EEB40 0x14 M10                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M20                                       = GetSingle(new IntPtr(p + 0x018)); // 0245A15EEB60 0x18 M20                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M30                                       = GetSingle(new IntPtr(p + 0x01C)); // 0245A15EEB80 0x1C M30                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M01                                       = GetSingle(new IntPtr(p + 0x020)); // 0245A15EEBA0 0x20 M01                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M11                                       = GetSingle(new IntPtr(p + 0x024)); // 0245A15EEBC0 0x24 M11                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M21                                       = GetSingle(new IntPtr(p + 0x028)); // 0245A15EEBE0 0x28 M21                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M31                                       = GetSingle(new IntPtr(p + 0x02C)); // 0245A15EEC00 0x2C M31                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M02                                       = GetSingle(new IntPtr(p + 0x030)); // 0245A15EEC20 0x30 M02                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M12                                       = GetSingle(new IntPtr(p + 0x034)); // 0245A15EEC40 0x34 M12                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M22                                       = GetSingle(new IntPtr(p + 0x038)); // 0245A15EEC60 0x38 M22                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M32                                       = GetSingle(new IntPtr(p + 0x03C)); // 0245A15EEC80 0x3C M32                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M03                                       = GetSingle(new IntPtr(p + 0x040)); // 0245A15EECA0 0x40 M03                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M13                                       = GetSingle(new IntPtr(p + 0x044)); // 0245A15EECC0 0x44 M13                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M23                                       = GetSingle(new IntPtr(p + 0x048)); // 0245A15EECE0 0x48 M23                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.M33                                       = GetSingle(new IntPtr(p + 0x04C)); // 0245A15EED00 0x4C M33                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.IdentityMatrix                            = (Matrix4x4)GetInt32(new IntPtr(p + 0x040)); // 0245A15EED40 0x40 IdentityMatrix              ( 00018660E700 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )

            return value;
        }
    }
}
