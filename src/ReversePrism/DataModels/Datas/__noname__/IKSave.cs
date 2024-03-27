using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 T                                        0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 018 P                                        0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 R                                        00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class IKSave
    {
        public Transform?                               T                                       { get; set; }
        public Vector3                                  P                                       { get; set; }
        public Quaternion                               R                                       { get; set; }

        public static IKSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IKSave();

            value.T                                         = GetObject<Transform>(new IntPtr(p + 0x010), ReversePrism.DataModels.Transform.FromPointer); // 027006A957A0 0x10 T                           ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.P                                         = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 027006A957C0 0x18 P                           ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.R                                         = (Quaternion)GetInt32(new IntPtr(p + 0x024)); // 027006A957E0 0x24 R                           ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
