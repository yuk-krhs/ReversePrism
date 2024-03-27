using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EyeL                                     0001865401E0 ModelClassType EyeController EyeController EyeController Pointer
    // 028 EyeR                                     0001865401E0 ModelClassType EyeController EyeController EyeController Pointer
    // 030 FaceAnimator                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 038 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    // 040 AnimParamCurve                           00018668E8B0 ModelClassType AnimParamCurve AnimParamCurve AnimParamCurve Pointer
    // 048 FramePreset                              0001866656B0 ModelPrimitiveType float float float Single
    // 04C InterFrame                               0001866656B0 ModelPrimitiveType float float float Single
    // 050 dicValue                                 Dictionary`2<int, float> IL2CPP_TYPE_GENERICINST
    // 058 MouthList                                000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 EyeLidList                               000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 EyeBrowList                              000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 070 MouthCurve                               000185B70090 ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer
    // 078 EyeLidCurve                              000185B70090 ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer
    // 080 EyeBrowCurve                             000185B70090 ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer
    // 088 NeckLocalRotY                            0001866656B0 ModelPrimitiveType float float float Single
    // 08C SeriousRate                              000186666050 ModelPrimitiveType float float float Single
    // 090 EyeAnimation                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 091 EyeOverwrite                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class FaceAnimParam
    {
        public EyeController?                           EyeL                                    { get; set; }
        public EyeController?                           EyeR                                    { get; set; }
        public Animator?                                FaceAnimator                            { get; set; }
        public Character?                               Character                               { get; set; }
        public AnimParamCurve?                          AnimParamCurve                          { get; set; }
        public float                                    FramePreset                             { get; set; }
        public float                                    InterFrame                              { get; set; }
        public List<int>?                               MouthList                               { get; set; }
        public List<int>?                               EyeLidList                              { get; set; }
        public List<int>?                               EyeBrowList                             { get; set; }
        public List<AnimationCurve>?                    MouthCurve                              { get; set; }
        public List<AnimationCurve>?                    EyeLidCurve                             { get; set; }
        public List<AnimationCurve>?                    EyeBrowCurve                            { get; set; }
        public float                                    NeckLocalRotY                           { get; set; }
        public float                                    SeriousRate                             { get; set; }
        public bool                                     EyeAnimation                            { get; set; }
        public bool                                     EyeOverwrite                            { get; set; }

        public static FaceAnimParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceAnimParam();

            value.EyeL                                      = GetObject<EyeController>(new IntPtr(p + 0x020), ReversePrism.DataModels.EyeController.FromPointer); // 027006AAB258 0x20 EyeL                        ( 0001865401E0 ModelClassType EyeController EyeController EyeController Pointer )
            value.EyeR                                      = GetObject<EyeController>(new IntPtr(p + 0x028), ReversePrism.DataModels.EyeController.FromPointer); // 027006AAB278 0x28 EyeR                        ( 0001865401E0 ModelClassType EyeController EyeController EyeController Pointer )
            value.FaceAnimator                              = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 027006AAB298 0x30 FaceAnimator                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x038), ReversePrism.DataModels.Character.FromPointer); // 027006AAB2B8 0x38 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )
            value.AnimParamCurve                            = GetObject<AnimParamCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimParamCurve.FromPointer); // 027006AAB2D8 0x40 AnimParamCurve              ( 00018668E8B0 ModelClassType AnimParamCurve AnimParamCurve AnimParamCurve Pointer )
            value.FramePreset                               = GetSingle(new IntPtr(p + 0x048)); // 027006AAB2F8 0x48 FramePreset                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InterFrame                                = GetSingle(new IntPtr(p + 0x04C)); // 027006AAB318 0x4C InterFrame                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MouthList                                 = GetInt32List(new IntPtr(p + 0x058)); // 027006AAB358 0x58 MouthList                   ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EyeLidList                                = GetInt32List(new IntPtr(p + 0x060)); // 027006AAB378 0x60 EyeLidList                  ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EyeBrowList                               = GetInt32List(new IntPtr(p + 0x068)); // 027006AAB398 0x68 EyeBrowList                 ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MouthCurve                                = GetObjectList<AnimationCurve>(new IntPtr(p + 0x070), ReversePrism.DataModels.AnimationCurve.FromPointer); // 027006AAB3B8 0x70 MouthCurve                  ( 000185B70090 ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer )
            value.EyeLidCurve                               = GetObjectList<AnimationCurve>(new IntPtr(p + 0x078), ReversePrism.DataModels.AnimationCurve.FromPointer); // 027006AAB3D8 0x78 EyeLidCurve                 ( 000185B70090 ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer )
            value.EyeBrowCurve                              = GetObjectList<AnimationCurve>(new IntPtr(p + 0x080), ReversePrism.DataModels.AnimationCurve.FromPointer); // 027006AAB3F8 0x80 EyeBrowCurve                ( 000185B70090 ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer )
            value.NeckLocalRotY                             = GetSingle(new IntPtr(p + 0x088)); // 027006AAB418 0x88 NeckLocalRotY               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SeriousRate                               = GetSingle(new IntPtr(p + 0x08C)); // 027006AAB438 0x8C SeriousRate                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.EyeAnimation                              = GetBool(new IntPtr(p + 0x090)); // 027006AAB458 0x90 EyeAnimation                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EyeOverwrite                              = GetBool(new IntPtr(p + 0x091)); // 027006AAB478 0x91 EyeOverwrite                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
