using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 C0                                       0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C R0                                       000186666050 ModelPrimitiveType float float float Single
    // 030 C1                                       0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C R1                                       000186666050 ModelPrimitiveType float float float Single
    public partial class SwayBoneCollider
    {
        public Vector3                                  C0                                      { get; set; }
        public float                                    R0                                      { get; set; }
        public Vector3                                  C1                                      { get; set; }
        public float                                    R1                                      { get; set; }

        public static SwayBoneCollider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayBoneCollider();

            value.C0                                        = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0270069EF0B8 0x20 C0                          ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.R0                                        = GetSingle(new IntPtr(p + 0x02C)); // 0270069EF0D8 0x2C R0                          ( 000186666050 ModelPrimitiveType float float float Single )
            value.C1                                        = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0270069EF0F8 0x30 C1                          ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.R1                                        = GetSingle(new IntPtr(p + 0x03C)); // 0270069EF118 0x3C R1                          ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
