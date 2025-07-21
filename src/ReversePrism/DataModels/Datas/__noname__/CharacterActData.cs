using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 Character                                ModelClassType Character Character Character Pointer
    // 020 OverrideController                       ModelClassType AnimatorOverrideController AnimatorOverrideController AnimatorOverrideController Pointer
    // 028 State                                    ModelEnumType ActState ActState ActState Int32
    // 02C AnimationFrame                           ModelPrimitiveType float float float Single
    // 030 OffsetFrame                              ModelPrimitiveType float float float Single
    // 034 TransitionFrame                          ModelPrimitiveType float float float Single
    // 038 TotalFrame                               ModelPrimitiveType float float float Single
    // 040 CurrentAct                               ModelPrimitiveType string string string String
    // 048 NextAct                                  ModelPrimitiveType string string string String
    // 050 WrapMode                                 ModelEnumType WrapMode WrapMode WrapMode Int32
    // 054 DeltaFrame                               ModelPrimitiveType float float float Single
    // 058 LoopTime                                 ModelPrimitiveType int int int Int32
    // 05C NeckIK                                   ModelEnumType NeckIKMode NeckIKMode NeckIKMode Int32
    // 060 NeckRate                                 ModelPrimitiveType float float float Single
    // 064 NeckTarget                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 070 NeckLastTarget                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 07C NeckChestRate                            ModelPrimitiveType float float float Single
    // 080 NeckDelta                                ModelPrimitiveType float float float Single
    // 084 NeckDelay                                ModelPrimitiveType float float float Single
    // 088 HandLeftTarget                           ModelPrimitiveType int int int Int32
    // 08C HandRightTarget                          ModelPrimitiveType int int int Int32
    // 090 FlagEnd                                  ModelPrimitiveType bool bool bool Bool
    // 091 FlagLipsync                              ModelPrimitiveType bool bool bool Bool
    // 092 FlagGenerateLipsync                      ModelPrimitiveType bool bool bool Bool
    // 094 FlipState                                ModelPrimitiveType int int int Int32
    // 098 DefaultWait                              ModelPrimitiveType string string string String
    // 0A0 ExpEvent                                 ModelClassType ExpressionEvent ExpressionEvent ExpressionEvent Pointer
    // 0A8 FaceParam                                ModelClassType FaceAnimParam FaceAnimParam FaceAnimParam Pointer
    // 0B0 HeadBone                                 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 HipsBone                                 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 SequenceData                             ModelClassType SequenceData SequenceData SequenceData Pointer
    // 0C8 CurrentBody                              ModelClassType ActData ActData ActData Pointer
    // 0D0 CurrentFace                              ModelClassType ActData ActData ActData Pointer
    // 0D8 CurrentFaceAnim                          ModelClassType FaceAnimData FaceAnimData FaceAnimData Pointer
    // 0E0 CurrentNeckIK                            ModelClassType NeckIKData NeckIKData NeckIKData Pointer
    // 0E8 CurrentEyeTarget                         ModelClassType EyeTargetData EyeTargetData EyeTargetData Pointer
    // 0F0 CurrentHandIK                            ModelClassType HandIKData HandIKData HandIKData Pointer
    // 0F8 FaceReset                                ModelPrimitiveType bool bool bool Bool
    // 100 FaceActValue                             ModelClassType FaceActValue FaceActValue FaceActValue Pointer
    // 108 BlinkCount                               ModelPrimitiveType float float float Single
    // 110 AutoNeckParam                            ModelClassType AutoNeckParam AutoNeckParam AutoNeckParam Pointer
    // 118 LastAnimHead                             ModelEnumType Quaternion Quaternion Quaternion Int32
    // 128 MoveData                                 ModelClassType MoveData MoveData MoveData Pointer
    // 130 InterpolateCurve                         ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class CharacterActData : DataModel
    {
        public int                                      Id                                      { get; set; }
        public Character?                               Character                               { get; set; }
        public AnimatorOverrideController?              OverrideController                      { get; set; }
        public ActState                                 State                                   { get; set; }
        public float                                    AnimationFrame                          { get; set; }
        public float                                    OffsetFrame                             { get; set; }
        public float                                    TransitionFrame                         { get; set; }
        public float                                    TotalFrame                              { get; set; }
        public string                                   CurrentAct                              { get; set; }
        public string                                   NextAct                                 { get; set; }
        public WrapMode                                 WrapMode                                { get; set; }
        public float                                    DeltaFrame                              { get; set; }
        public int                                      LoopTime                                { get; set; }
        public NeckIKMode                               NeckIK                                  { get; set; }
        public float                                    NeckRate                                { get; set; }
        public Vector3                                  NeckTarget                              { get; set; }
        public Vector3                                  NeckLastTarget                          { get; set; }
        public float                                    NeckChestRate                           { get; set; }
        public float                                    NeckDelta                               { get; set; }
        public float                                    NeckDelay                               { get; set; }
        public int                                      HandLeftTarget                          { get; set; }
        public int                                      HandRightTarget                         { get; set; }
        public bool                                     FlagEnd                                 { get; set; }
        public bool                                     FlagLipsync                             { get; set; }
        public bool                                     FlagGenerateLipsync                     { get; set; }
        public int                                      FlipState                               { get; set; }
        public string                                   DefaultWait                             { get; set; }
        public ExpressionEvent?                         ExpEvent                                { get; set; }
        public FaceAnimParam?                           FaceParam                               { get; set; }
        public GameObject?                              HeadBone                                { get; set; }
        public GameObject?                              HipsBone                                { get; set; }
        public SequenceData?                            SequenceData                            { get; set; }
        public ActData?                                 CurrentBody                             { get; set; }
        public ActData?                                 CurrentFace                             { get; set; }
        public FaceAnimData?                            CurrentFaceAnim                         { get; set; }
        public NeckIKData?                              CurrentNeckIK                           { get; set; }
        public EyeTargetData?                           CurrentEyeTarget                        { get; set; }
        public HandIKData?                              CurrentHandIK                           { get; set; }
        public bool                                     FaceReset                               { get; set; }
        public FaceActValue?                            FaceActValue                            { get; set; }
        public float                                    BlinkCount                              { get; set; }
        public AutoNeckParam?                           AutoNeckParam                           { get; set; }
        public Quaternion                               LastAnimHead                            { get; set; }
        public MoveData?                                MoveData                                { get; set; }
        public AnimationCurve?                          InterpolateCurve                        { get; set; }

        public static CharacterActData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterActData() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x018), ReversePrism.DataModels.Character.FromPointer); // 0x18 Character                   ( ModelClassType Character Character Character Pointer )
            value.OverrideController                        = GetObject<AnimatorOverrideController>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimatorOverrideController.FromPointer); // 0x20 OverrideController          ( ModelClassType AnimatorOverrideController AnimatorOverrideController AnimatorOverrideController Pointer )
            value.State                                     = (ActState)GetInt32(new IntPtr(p + 0x028)); // 0x28 State                       ( ModelEnumType ActState ActState ActState Int32 )
            value.AnimationFrame                            = GetSingle(new IntPtr(p + 0x02C)); // 0x2C AnimationFrame              ( ModelPrimitiveType float float float Single )
            value.OffsetFrame                               = GetSingle(new IntPtr(p + 0x030)); // 0x30 OffsetFrame                 ( ModelPrimitiveType float float float Single )
            value.TransitionFrame                           = GetSingle(new IntPtr(p + 0x034)); // 0x34 TransitionFrame             ( ModelPrimitiveType float float float Single )
            value.TotalFrame                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 TotalFrame                  ( ModelPrimitiveType float float float Single )
            value.CurrentAct                                = GetString(new IntPtr(p + 0x040)); // 0x40 CurrentAct                  ( ModelPrimitiveType string string string String )
            value.NextAct                                   = GetString(new IntPtr(p + 0x048)); // 0x48 NextAct                     ( ModelPrimitiveType string string string String )
            value.WrapMode                                  = (WrapMode)GetInt32(new IntPtr(p + 0x050)); // 0x50 WrapMode                    ( ModelEnumType WrapMode WrapMode WrapMode Int32 )
            value.DeltaFrame                                = GetSingle(new IntPtr(p + 0x054)); // 0x54 DeltaFrame                  ( ModelPrimitiveType float float float Single )
            value.LoopTime                                  = GetInt32(new IntPtr(p + 0x058)); // 0x58 LoopTime                    ( ModelPrimitiveType int int int Int32 )
            value.NeckIK                                    = (NeckIKMode)GetInt32(new IntPtr(p + 0x05C)); // 0x5C NeckIK                      ( ModelEnumType NeckIKMode NeckIKMode NeckIKMode Int32 )
            value.NeckRate                                  = GetSingle(new IntPtr(p + 0x060)); // 0x60 NeckRate                    ( ModelPrimitiveType float float float Single )
            value.NeckTarget                                = (Vector3)GetInt32(new IntPtr(p + 0x064)); // 0x64 NeckTarget                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.NeckLastTarget                            = (Vector3)GetInt32(new IntPtr(p + 0x070)); // 0x70 NeckLastTarget              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.NeckChestRate                             = GetSingle(new IntPtr(p + 0x07C)); // 0x7C NeckChestRate               ( ModelPrimitiveType float float float Single )
            value.NeckDelta                                 = GetSingle(new IntPtr(p + 0x080)); // 0x80 NeckDelta                   ( ModelPrimitiveType float float float Single )
            value.NeckDelay                                 = GetSingle(new IntPtr(p + 0x084)); // 0x84 NeckDelay                   ( ModelPrimitiveType float float float Single )
            value.HandLeftTarget                            = GetInt32(new IntPtr(p + 0x088)); // 0x88 HandLeftTarget              ( ModelPrimitiveType int int int Int32 )
            value.HandRightTarget                           = GetInt32(new IntPtr(p + 0x08C)); // 0x8C HandRightTarget             ( ModelPrimitiveType int int int Int32 )
            value.FlagEnd                                   = GetBool(new IntPtr(p + 0x090)); // 0x90 FlagEnd                     ( ModelPrimitiveType bool bool bool Bool )
            value.FlagLipsync                               = GetBool(new IntPtr(p + 0x091)); // 0x91 FlagLipsync                 ( ModelPrimitiveType bool bool bool Bool )
            value.FlagGenerateLipsync                       = GetBool(new IntPtr(p + 0x092)); // 0x92 FlagGenerateLipsync         ( ModelPrimitiveType bool bool bool Bool )
            value.FlipState                                 = GetInt32(new IntPtr(p + 0x094)); // 0x94 FlipState                   ( ModelPrimitiveType int int int Int32 )
            value.DefaultWait                               = GetString(new IntPtr(p + 0x098)); // 0x98 DefaultWait                 ( ModelPrimitiveType string string string String )
            value.ExpEvent                                  = GetObject<ExpressionEvent>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ExpressionEvent.FromPointer); // 0xA0 ExpEvent                    ( ModelClassType ExpressionEvent ExpressionEvent ExpressionEvent Pointer )
            value.FaceParam                                 = GetObject<FaceAnimParam>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FaceAnimParam.FromPointer); // 0xA8 FaceParam                   ( ModelClassType FaceAnimParam FaceAnimParam FaceAnimParam Pointer )
            value.HeadBone                                  = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0xB0 HeadBone                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.HipsBone                                  = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0xB8 HipsBone                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SequenceData                              = GetObject<SequenceData>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.SequenceData.FromPointer); // 0xC0 SequenceData                ( ModelClassType SequenceData SequenceData SequenceData Pointer )
            value.CurrentBody                               = GetObject<ActData>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ActData.FromPointer); // 0xC8 CurrentBody                 ( ModelClassType ActData ActData ActData Pointer )
            value.CurrentFace                               = GetObject<ActData>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ActData.FromPointer); // 0xD0 CurrentFace                 ( ModelClassType ActData ActData ActData Pointer )
            value.CurrentFaceAnim                           = GetObject<FaceAnimData>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.FaceAnimData.FromPointer); // 0xD8 CurrentFaceAnim             ( ModelClassType FaceAnimData FaceAnimData FaceAnimData Pointer )
            value.CurrentNeckIK                             = GetObject<NeckIKData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.NeckIKData.FromPointer); // 0xE0 CurrentNeckIK               ( ModelClassType NeckIKData NeckIKData NeckIKData Pointer )
            value.CurrentEyeTarget                          = GetObject<EyeTargetData>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.EyeTargetData.FromPointer); // 0xE8 CurrentEyeTarget            ( ModelClassType EyeTargetData EyeTargetData EyeTargetData Pointer )
            value.CurrentHandIK                             = GetObject<HandIKData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.HandIKData.FromPointer); // 0xF0 CurrentHandIK               ( ModelClassType HandIKData HandIKData HandIKData Pointer )
            value.FaceReset                                 = GetBool(new IntPtr(p + 0x0F8)); // 0xF8 FaceReset                   ( ModelPrimitiveType bool bool bool Bool )
            value.FaceActValue                              = GetObject<FaceActValue>(new IntPtr(p + 0x100), ReversePrism.DataModels.FaceActValue.FromPointer); // 0x100 FaceActValue                ( ModelClassType FaceActValue FaceActValue FaceActValue Pointer )
            value.BlinkCount                                = GetSingle(new IntPtr(p + 0x108)); // 0x108 BlinkCount                  ( ModelPrimitiveType float float float Single )
            value.AutoNeckParam                             = GetObject<AutoNeckParam>(new IntPtr(p + 0x110), ReversePrism.DataModels.AutoNeckParam.FromPointer); // 0x110 AutoNeckParam               ( ModelClassType AutoNeckParam AutoNeckParam AutoNeckParam Pointer )
            value.LastAnimHead                              = (Quaternion)GetInt32(new IntPtr(p + 0x118)); // 0x118 LastAnimHead                ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.MoveData                                  = GetObject<MoveData>(new IntPtr(p + 0x128), ReversePrism.DataModels.MoveData.FromPointer); // 0x128 MoveData                    ( ModelClassType MoveData MoveData MoveData Pointer )
            value.InterpolateCurve                          = GetObject<AnimationCurve>(new IntPtr(p + 0x130), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x130 InterpolateCurve            ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
