using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 On                                       ModelPrimitiveType bool bool bool Bool
    // 014 C0                                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 020 C1                                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C R0                                       ModelPrimitiveType float float float Single
    // 030 R1                                       ModelPrimitiveType float float float Single
    public partial class ColliderParam : DataModel
    {
        public bool                                     On                                      { get; set; }
        public Vector3                                  C0                                      { get; set; }
        public Vector3                                  C1                                      { get; set; }
        public float                                    R0                                      { get; set; }
        public float                                    R1                                      { get; set; }

        public static ColliderParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColliderParam() { Pointer= p0 };

            value.On                                        = GetBool(new IntPtr(p + 0x010)); // 0x10 On                          ( ModelPrimitiveType bool bool bool Bool )
            value.C0                                        = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 0x14 C0                          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.C1                                        = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 C1                          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.R0                                        = GetSingle(new IntPtr(p + 0x02C)); // 0x2C R0                          ( ModelPrimitiveType float float float Single )
            value.R1                                        = GetSingle(new IntPtr(p + 0x030)); // 0x30 R1                          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
