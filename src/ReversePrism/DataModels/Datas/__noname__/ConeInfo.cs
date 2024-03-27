using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseBone                                 0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 018 Summit                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 Downward                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 Spread                                   000186666050 ModelPrimitiveType float float float Single
    // 034 From                                     000186666050 ModelPrimitiveType float float float Single
    // 038 To                                       000186666050 ModelPrimitiveType float float float Single
    public partial class ConeInfo
    {
        public Transform?                               BaseBone                                { get; set; }
        public Vector3                                  Summit                                  { get; set; }
        public Vector3                                  Downward                                { get; set; }
        public float                                    Spread                                  { get; set; }
        public float                                    From                                    { get; set; }
        public float                                    To                                      { get; set; }

        public static ConeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConeInfo();

            value.BaseBone                                  = GetObject<Transform>(new IntPtr(p + 0x010), ReversePrism.DataModels.Transform.FromPointer); // 027006A1D020 0x10 BaseBone                    ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.Summit                                    = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 027006A1D040 0x18 Summit                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Downward                                  = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 027006A1D060 0x24 Downward                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Spread                                    = GetSingle(new IntPtr(p + 0x030)); // 027006A1D080 0x30 Spread                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.From                                      = GetSingle(new IntPtr(p + 0x034)); // 027006A1D0A0 0x34 From                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.To                                        = GetSingle(new IntPtr(p + 0x038)); // 027006A1D0C0 0x38 To                          ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
