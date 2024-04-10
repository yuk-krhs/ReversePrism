using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Character                                0001865974D0 ModelClassType Character Character Character Pointer
    // 020 OverrideController                       0001866BB6D0 ModelClassType AnimatorOverrideController AnimatorOverrideController AnimatorOverrideController Pointer
    // 028 State                                    00018675F070 ModelEnumType ActState ActState ActState Int32
    // 02C AnimationFrame                           000186666050 ModelPrimitiveType float float float Single
    // 030 OffsetFrame                              000186666050 ModelPrimitiveType float float float Single
    // 034 TransitionFrame                          000186666050 ModelPrimitiveType float float float Single
    // 038 TotalFrame                               000186666050 ModelPrimitiveType float float float Single
    // 040 CurrentAct                               0001866722E0 ModelPrimitiveType string string string String
    // 048 NextAct                                  0001866722E0 ModelPrimitiveType string string string String
    // 050 WrapMode                                 00018655EE70 ModelEnumType WrapMode WrapMode WrapMode Int32
    // 054 DeltaFrame                               000186666050 ModelPrimitiveType float float float Single
    // 058 LoopTime                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 05C NeckIK                                   0001867606E0 ModelEnumType NeckIKMode NeckIKMode NeckIKMode Int32
    // 060 NeckRate                                 000186666050 ModelPrimitiveType float float float Single
    // 064 NeckTarget                               0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 070 NeckLastTarget                           0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 07C NeckChestRate                            000186666050 ModelPrimitiveType float float float Single
    // 080 NeckDelta                                000186666050 ModelPrimitiveType float float float Single
    // 084 NeckDelay                                000186666050 ModelPrimitiveType float float float Single
    // 088 HandLeftTarget                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 08C HandRightTarget                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 090 FlagEnd                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 091 FlagLipsync                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 094 FlipState                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 098 DefaultWait                              0001866722E0 ModelPrimitiveType string string string String
    // 0A0 ExpEvent                                 00018652C1C0 ModelClassType ExpressionEvent ExpressionEvent ExpressionEvent Pointer
    // 0A8 FaceParam                                00018654E490 ModelClassType FaceAnimParam FaceAnimParam FaceAnimParam Pointer
    // 0B0 HeadBone                                 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 HipsBone                                 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 SequenceData                             000186746070 ModelClassType SequenceData SequenceData SequenceData Pointer
    // 0C8 CurrentBody                              000186744390 ModelClassType ActData ActData ActData Pointer
    // 0D0 CurrentFace                              000186744390 ModelClassType ActData ActData ActData Pointer
    // 0D8 CurrentFaceAnim                          0001867455C0 ModelClassType FaceAnimData FaceAnimData FaceAnimData Pointer
    // 0E0 CurrentNeckIK                            000186745D30 ModelClassType NeckIKData NeckIKData NeckIKData Pointer
    // 0E8 CurrentEyeTarget                         000186744C30 ModelClassType EyeTargetData EyeTargetData EyeTargetData Pointer
    // 0F0 CurrentHandIK                            000186745990 ModelClassType HandIKData HandIKData HandIKData Pointer
    // 0F8 FaceReset                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 100 FaceActValue                             00018675FD90 ModelClassType FaceActValue FaceActValue FaceActValue Pointer
    // 108 BlinkCount                               000186666050 ModelPrimitiveType float float float Single
    // 110 AutoNeckParam                            00018675F7E0 ModelClassType AutoNeckParam AutoNeckParam AutoNeckParam Pointer
    // 118 LastAnimHead                             00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 128 MoveData                                 000186760220 ModelClassType MoveData MoveData MoveData Pointer
    // 130 InterpolateCurve                         000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A695F390 0x10 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x018), ReversePrism.DataModels.Character.FromPointer); // 0245A695F3B0 0x18 Character                   ( 0001865974D0 ModelClassType Character Character Character Pointer )
            value.OverrideController                        = GetObject<AnimatorOverrideController>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimatorOverrideController.FromPointer); // 0245A695F3D0 0x20 OverrideController          ( 0001866BB6D0 ModelClassType AnimatorOverrideController AnimatorOverrideController AnimatorOverrideController Pointer )
            value.State                                     = (ActState)GetInt32(new IntPtr(p + 0x028)); // 0245A695F3F0 0x28 State                       ( 00018675F070 ModelEnumType ActState ActState ActState Int32 )
            value.AnimationFrame                            = GetSingle(new IntPtr(p + 0x02C)); // 0245A695F410 0x2C AnimationFrame              ( 000186666050 ModelPrimitiveType float float float Single )
            value.OffsetFrame                               = GetSingle(new IntPtr(p + 0x030)); // 0245A695F430 0x30 OffsetFrame                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.TransitionFrame                           = GetSingle(new IntPtr(p + 0x034)); // 0245A695F450 0x34 TransitionFrame             ( 000186666050 ModelPrimitiveType float float float Single )
            value.TotalFrame                                = GetSingle(new IntPtr(p + 0x038)); // 0245A695F470 0x38 TotalFrame                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.CurrentAct                                = GetString(new IntPtr(p + 0x040)); // 0245A695F490 0x40 CurrentAct                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NextAct                                   = GetString(new IntPtr(p + 0x048)); // 0245A695F4B0 0x48 NextAct                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.WrapMode                                  = (WrapMode)GetInt32(new IntPtr(p + 0x050)); // 0245A695F4D0 0x50 WrapMode                    ( 00018655EE70 ModelEnumType WrapMode WrapMode WrapMode Int32 )
            value.DeltaFrame                                = GetSingle(new IntPtr(p + 0x054)); // 0245A695F4F0 0x54 DeltaFrame                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.LoopTime                                  = GetInt32(new IntPtr(p + 0x058)); // 0245A695F510 0x58 LoopTime                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NeckIK                                    = (NeckIKMode)GetInt32(new IntPtr(p + 0x05C)); // 0245A695F530 0x5C NeckIK                      ( 0001867606E0 ModelEnumType NeckIKMode NeckIKMode NeckIKMode Int32 )
            value.NeckRate                                  = GetSingle(new IntPtr(p + 0x060)); // 0245A695F550 0x60 NeckRate                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.NeckTarget                                = (Vector3)GetInt32(new IntPtr(p + 0x064)); // 0245A695F570 0x64 NeckTarget                  ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.NeckLastTarget                            = (Vector3)GetInt32(new IntPtr(p + 0x070)); // 0245A695F590 0x70 NeckLastTarget              ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.NeckChestRate                             = GetSingle(new IntPtr(p + 0x07C)); // 0245A695F5B0 0x7C NeckChestRate               ( 000186666050 ModelPrimitiveType float float float Single )
            value.NeckDelta                                 = GetSingle(new IntPtr(p + 0x080)); // 0245A695F5D0 0x80 NeckDelta                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.NeckDelay                                 = GetSingle(new IntPtr(p + 0x084)); // 0245A695F5F0 0x84 NeckDelay                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.HandLeftTarget                            = GetInt32(new IntPtr(p + 0x088)); // 0245A695F610 0x88 HandLeftTarget              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HandRightTarget                           = GetInt32(new IntPtr(p + 0x08C)); // 0245A695F630 0x8C HandRightTarget             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FlagEnd                                   = GetBool(new IntPtr(p + 0x090)); // 0245A695F650 0x90 FlagEnd                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FlagLipsync                               = GetBool(new IntPtr(p + 0x091)); // 0245A695F670 0x91 FlagLipsync                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FlipState                                 = GetInt32(new IntPtr(p + 0x094)); // 0245A695F690 0x94 FlipState                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DefaultWait                               = GetString(new IntPtr(p + 0x098)); // 0245A695F6B0 0x98 DefaultWait                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ExpEvent                                  = GetObject<ExpressionEvent>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ExpressionEvent.FromPointer); // 0245A695F6D0 0xA0 ExpEvent                    ( 00018652C1C0 ModelClassType ExpressionEvent ExpressionEvent ExpressionEvent Pointer )
            value.FaceParam                                 = GetObject<FaceAnimParam>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FaceAnimParam.FromPointer); // 0245A695F6F0 0xA8 FaceParam                   ( 00018654E490 ModelClassType FaceAnimParam FaceAnimParam FaceAnimParam Pointer )
            value.HeadBone                                  = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0245A695F710 0xB0 HeadBone                    ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.HipsBone                                  = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0245A695F730 0xB8 HipsBone                    ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.SequenceData                              = GetObject<SequenceData>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.SequenceData.FromPointer); // 0245A695F750 0xC0 SequenceData                ( 000186746070 ModelClassType SequenceData SequenceData SequenceData Pointer )
            value.CurrentBody                               = GetObject<ActData>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ActData.FromPointer); // 0245A695F770 0xC8 CurrentBody                 ( 000186744390 ModelClassType ActData ActData ActData Pointer )
            value.CurrentFace                               = GetObject<ActData>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ActData.FromPointer); // 0245A695F790 0xD0 CurrentFace                 ( 000186744390 ModelClassType ActData ActData ActData Pointer )
            value.CurrentFaceAnim                           = GetObject<FaceAnimData>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.FaceAnimData.FromPointer); // 0245A695F7B0 0xD8 CurrentFaceAnim             ( 0001867455C0 ModelClassType FaceAnimData FaceAnimData FaceAnimData Pointer )
            value.CurrentNeckIK                             = GetObject<NeckIKData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.NeckIKData.FromPointer); // 0245A695F7D0 0xE0 CurrentNeckIK               ( 000186745D30 ModelClassType NeckIKData NeckIKData NeckIKData Pointer )
            value.CurrentEyeTarget                          = GetObject<EyeTargetData>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.EyeTargetData.FromPointer); // 0245A695F7F0 0xE8 CurrentEyeTarget            ( 000186744C30 ModelClassType EyeTargetData EyeTargetData EyeTargetData Pointer )
            value.CurrentHandIK                             = GetObject<HandIKData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.HandIKData.FromPointer); // 0245A695F810 0xF0 CurrentHandIK               ( 000186745990 ModelClassType HandIKData HandIKData HandIKData Pointer )
            value.FaceReset                                 = GetBool(new IntPtr(p + 0x0F8)); // 0245A695F830 0xF8 FaceReset                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FaceActValue                              = GetObject<FaceActValue>(new IntPtr(p + 0x100), ReversePrism.DataModels.FaceActValue.FromPointer); // 0245A695F850 0x100 FaceActValue                ( 00018675FD90 ModelClassType FaceActValue FaceActValue FaceActValue Pointer )
            value.BlinkCount                                = GetSingle(new IntPtr(p + 0x108)); // 0245A695F870 0x108 BlinkCount                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.AutoNeckParam                             = GetObject<AutoNeckParam>(new IntPtr(p + 0x110), ReversePrism.DataModels.AutoNeckParam.FromPointer); // 0245A695F890 0x110 AutoNeckParam               ( 00018675F7E0 ModelClassType AutoNeckParam AutoNeckParam AutoNeckParam Pointer )
            value.LastAnimHead                              = (Quaternion)GetInt32(new IntPtr(p + 0x118)); // 0245A695F8B0 0x118 LastAnimHead                ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.MoveData                                  = GetObject<MoveData>(new IntPtr(p + 0x128), ReversePrism.DataModels.MoveData.FromPointer); // 0245A695F8D0 0x128 MoveData                    ( 000186760220 ModelClassType MoveData MoveData MoveData Pointer )
            value.InterpolateCurve                          = GetObject<AnimationCurve>(new IntPtr(p + 0x130), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A695F8F0 0x130 InterpolateCurve            ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
