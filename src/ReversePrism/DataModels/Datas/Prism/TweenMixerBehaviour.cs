using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_DefaultCurve                           AnimationCurve IL2CPP_TYPE_CLASS
    // 010 M_ShouldInitializeTransform              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 M_InitialPosition                        0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 020 M_InitialRotation                        000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class TweenMixerBehaviour
    {
        public bool                                     M_ShouldInitializeTransform             { get; set; }
        public Vector3                                  M_InitialPosition                       { get; set; }
        public Quaternion                               M_InitialRotation                       { get; set; }

        public static TweenMixerBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenMixerBehaviour();

            value.M_ShouldInitializeTransform               = GetBool(new IntPtr(p + 0x010)); // 0270D4E16F40 0x10 M_ShouldInitializeTransform ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InitialPosition                         = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 0270D4E16F60 0x14 M_InitialPosition           ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_InitialRotation                         = (Quaternion)GetInt32(new IntPtr(p + 0x020)); // 0270D4E16F80 0x20 M_InitialRotation           ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
