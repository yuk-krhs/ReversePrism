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
    // 018 M13                                      ModelPrimitiveType float float float Single
    // 01C M14                                      ModelPrimitiveType float float float Single
    // 020 M21                                      ModelPrimitiveType float float float Single
    // 024 M22                                      ModelPrimitiveType float float float Single
    // 028 M23                                      ModelPrimitiveType float float float Single
    // 02C M24                                      ModelPrimitiveType float float float Single
    // 030 M31                                      ModelPrimitiveType float float float Single
    // 034 M32                                      ModelPrimitiveType float float float Single
    // 038 M33                                      ModelPrimitiveType float float float Single
    // 03C M34                                      ModelPrimitiveType float float float Single
    // 040 M41                                      ModelPrimitiveType float float float Single
    // 044 M42                                      ModelPrimitiveType float float float Single
    // 048 M43                                      ModelPrimitiveType float float float Single
    // 04C M44                                      ModelPrimitiveType float float float Single
    // 000 _identity                                Matrix4x4 IL2CPP_TYPE_VALUETYPE
    public partial class Matrix4x4 : DataModel
    {
        public float                                    M11                                     { get; set; }
        public float                                    M12                                     { get; set; }
        public float                                    M13                                     { get; set; }
        public float                                    M14                                     { get; set; }
        public float                                    M21                                     { get; set; }
        public float                                    M22                                     { get; set; }
        public float                                    M23                                     { get; set; }
        public float                                    M24                                     { get; set; }
        public float                                    M31                                     { get; set; }
        public float                                    M32                                     { get; set; }
        public float                                    M33                                     { get; set; }
        public float                                    M34                                     { get; set; }
        public float                                    M41                                     { get; set; }
        public float                                    M42                                     { get; set; }
        public float                                    M43                                     { get; set; }
        public float                                    M44                                     { get; set; }

        public static Matrix4x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Matrix4x4() { Pointer= p0 };

            value.M11                                       = GetSingle(new IntPtr(p + 0x010)); // 0x10 M11                         ( ModelPrimitiveType float float float Single )
            value.M12                                       = GetSingle(new IntPtr(p + 0x014)); // 0x14 M12                         ( ModelPrimitiveType float float float Single )
            value.M13                                       = GetSingle(new IntPtr(p + 0x018)); // 0x18 M13                         ( ModelPrimitiveType float float float Single )
            value.M14                                       = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M14                         ( ModelPrimitiveType float float float Single )
            value.M21                                       = GetSingle(new IntPtr(p + 0x020)); // 0x20 M21                         ( ModelPrimitiveType float float float Single )
            value.M22                                       = GetSingle(new IntPtr(p + 0x024)); // 0x24 M22                         ( ModelPrimitiveType float float float Single )
            value.M23                                       = GetSingle(new IntPtr(p + 0x028)); // 0x28 M23                         ( ModelPrimitiveType float float float Single )
            value.M24                                       = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M24                         ( ModelPrimitiveType float float float Single )
            value.M31                                       = GetSingle(new IntPtr(p + 0x030)); // 0x30 M31                         ( ModelPrimitiveType float float float Single )
            value.M32                                       = GetSingle(new IntPtr(p + 0x034)); // 0x34 M32                         ( ModelPrimitiveType float float float Single )
            value.M33                                       = GetSingle(new IntPtr(p + 0x038)); // 0x38 M33                         ( ModelPrimitiveType float float float Single )
            value.M34                                       = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M34                         ( ModelPrimitiveType float float float Single )
            value.M41                                       = GetSingle(new IntPtr(p + 0x040)); // 0x40 M41                         ( ModelPrimitiveType float float float Single )
            value.M42                                       = GetSingle(new IntPtr(p + 0x044)); // 0x44 M42                         ( ModelPrimitiveType float float float Single )
            value.M43                                       = GetSingle(new IntPtr(p + 0x048)); // 0x48 M43                         ( ModelPrimitiveType float float float Single )
            value.M44                                       = GetSingle(new IntPtr(p + 0x04C)); // 0x4C M44                         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
