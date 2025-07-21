using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bone                                     ModelPrimitiveType int int int Int32
    // 014 BonePosition                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 020 BoneRotation                             ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class BoneData : DataModel
    {
        public int                                      Bone                                    { get; set; }
        public Vector3                                  BonePosition                            { get; set; }
        public Quaternion                               BoneRotation                            { get; set; }

        public static BoneData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoneData() { Pointer= p0 };

            value.Bone                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Bone                        ( ModelPrimitiveType int int int Int32 )
            value.BonePosition                              = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 0x14 BonePosition                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BoneRotation                              = (Quaternion)GetInt32(new IntPtr(p + 0x020)); // 0x20 BoneRotation                ( ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
