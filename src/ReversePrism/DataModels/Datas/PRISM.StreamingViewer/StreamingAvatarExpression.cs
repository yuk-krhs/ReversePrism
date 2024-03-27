using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 028 EyeTargetPosition                        0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 EyeControllers                           000185B7E130 ModelClassListType EyeController[] EyeController[] List<EyeController> Pointer
    // 040 MorphTargets                             000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 000 FaceParameterNames                       string[] IL2CPP_TYPE_SZARRAY
    public partial class StreamingAvatarExpression
    {
        public Animator?                                Animator                                { get; set; }
        public Vector3                                  EyeTargetPosition                       { get; set; }
        public List<EyeController>?                     EyeControllers                          { get; set; }
        public List<float>?                             MorphTargets                            { get; set; }

        public static StreamingAvatarExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamingAvatarExpression();

            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0270D4F2DF00 0x20 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.EyeTargetPosition                         = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0270D4F2DF20 0x28 EyeTargetPosition           ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.EyeControllers                            = GetObjectList<EyeController>(new IntPtr(p + 0x038), ReversePrism.DataModels.EyeController.FromPointer); // 0270D4F2DF40 0x38 EyeControllers              ( 000185B7E130 ModelClassListType EyeController[] EyeController[] List<EyeController> Pointer )
            value.MorphTargets                              = GetSingleList(new IntPtr(p + 0x040)); // 0270D4F2DF60 0x40 MorphTargets                ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
