using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EyeL                                     ModelClassType EyeController EyeController EyeController Pointer
    // 028 EyeR                                     ModelClassType EyeController EyeController EyeController Pointer
    // 030 FaceAnimator                             ModelClassType Animator Animator Animator Pointer
    // 038 Character                                ModelClassType Character Character Character Pointer
    // 040 AnimParamCurve                           ModelClassType AnimParamCurve AnimParamCurve AnimParamCurve Pointer
    // 048 FramePreset                              ModelPrimitiveType float float float Single
    // 04C InterFrame                               ModelPrimitiveType float float float Single
    // 050 dicValue                                 Dictionary`2<int, float> IL2CPP_TYPE_GENERICINST
    // 058 MouthList                                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 EyeLidList                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 EyeBrowList                              ModelPrimitiveListType int[] int[] List<int> Pointer
    // 070 MouthCurve                               ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer
    // 078 EyeLidCurve                              ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer
    // 080 EyeBrowCurve                             ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer
    // 088 NeckLocalRotY                            ModelPrimitiveType float float float Single
    // 08C IsDirectFrame                            ModelPrimitiveType bool bool bool Bool
    // 090 DirectFrame                              ModelPrimitiveType int int int Int32
    // 094 SeriousRate                              ModelPrimitiveType float float float Single
    // 098 EyeAnimation                             ModelPrimitiveType bool bool bool Bool
    // 099 EyeOverwrite                             ModelPrimitiveType bool bool bool Bool
    public partial class FaceAnimParam : DataModel
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
        public bool                                     IsDirectFrame                           { get; set; }
        public int                                      DirectFrame                             { get; set; }
        public float                                    SeriousRate                             { get; set; }
        public bool                                     EyeAnimation                            { get; set; }
        public bool                                     EyeOverwrite                            { get; set; }

        public static FaceAnimParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceAnimParam() { Pointer= p0 };

            value.EyeL                                      = GetObject<EyeController>(new IntPtr(p + 0x020), ReversePrism.DataModels.EyeController.FromPointer); // 0x20 EyeL                        ( ModelClassType EyeController EyeController EyeController Pointer )
            value.EyeR                                      = GetObject<EyeController>(new IntPtr(p + 0x028), ReversePrism.DataModels.EyeController.FromPointer); // 0x28 EyeR                        ( ModelClassType EyeController EyeController EyeController Pointer )
            value.FaceAnimator                              = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 FaceAnimator                ( ModelClassType Animator Animator Animator Pointer )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x038), ReversePrism.DataModels.Character.FromPointer); // 0x38 Character                   ( ModelClassType Character Character Character Pointer )
            value.AnimParamCurve                            = GetObject<AnimParamCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimParamCurve.FromPointer); // 0x40 AnimParamCurve              ( ModelClassType AnimParamCurve AnimParamCurve AnimParamCurve Pointer )
            value.FramePreset                               = GetSingle(new IntPtr(p + 0x048)); // 0x48 FramePreset                 ( ModelPrimitiveType float float float Single )
            value.InterFrame                                = GetSingle(new IntPtr(p + 0x04C)); // 0x4C InterFrame                  ( ModelPrimitiveType float float float Single )
            value.MouthList                                 = GetInt32List(new IntPtr(p + 0x058)); // 0x58 MouthList                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EyeLidList                                = GetInt32List(new IntPtr(p + 0x060)); // 0x60 EyeLidList                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EyeBrowList                               = GetInt32List(new IntPtr(p + 0x068)); // 0x68 EyeBrowList                 ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MouthCurve                                = GetObjectList<AnimationCurve>(new IntPtr(p + 0x070), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x70 MouthCurve                  ( ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer )
            value.EyeLidCurve                               = GetObjectList<AnimationCurve>(new IntPtr(p + 0x078), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x78 EyeLidCurve                 ( ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer )
            value.EyeBrowCurve                              = GetObjectList<AnimationCurve>(new IntPtr(p + 0x080), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x80 EyeBrowCurve                ( ModelClassListType AnimationCurve[] AnimationCurve[] List<AnimationCurve> Pointer )
            value.NeckLocalRotY                             = GetSingle(new IntPtr(p + 0x088)); // 0x88 NeckLocalRotY               ( ModelPrimitiveType float float float Single )
            value.IsDirectFrame                             = GetBool(new IntPtr(p + 0x08C)); // 0x8C IsDirectFrame               ( ModelPrimitiveType bool bool bool Bool )
            value.DirectFrame                               = GetInt32(new IntPtr(p + 0x090)); // 0x90 DirectFrame                 ( ModelPrimitiveType int int int Int32 )
            value.SeriousRate                               = GetSingle(new IntPtr(p + 0x094)); // 0x94 SeriousRate                 ( ModelPrimitiveType float float float Single )
            value.EyeAnimation                              = GetBool(new IntPtr(p + 0x098)); // 0x98 EyeAnimation                ( ModelPrimitiveType bool bool bool Bool )
            value.EyeOverwrite                              = GetBool(new IntPtr(p + 0x099)); // 0x99 EyeOverwrite                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
