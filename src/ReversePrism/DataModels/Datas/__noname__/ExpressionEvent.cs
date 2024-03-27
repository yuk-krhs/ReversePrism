using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    // 028 EyeL                                     0001865401E0 ModelClassType EyeController EyeController EyeController Pointer
    // 030 EyeR                                     0001865401E0 ModelClassType EyeController EyeController EyeController Pointer
    // 038 FaceAnimator                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 040 ExpData                                  000185D238A8 ModelClassListType List`1<ExpressionData> List`1<ExpressionData> List<ExpressionData> Pointer
    // 048 AnimationName                            000186671910 ModelPrimitiveType string string string String
    // 050 Timeline                                 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 058 IkTarget                                 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 060 IkTargetSave                             000185CBA628 ModelClassListType IKSave[] IKSave[] List<IKSave> Pointer
    // 000 LERP_FRAME                               int IL2CPP_TYPE_I4
    // 068 IsDirectFrame                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 06C DirectFrame                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 070 DefaultCharacterID                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 074 IsExpressionCancel                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 075 IsAlwaysSerious                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 dicValue                                 Dictionary`2<string, float> IL2CPP_TYPE_GENERICINST
    // 000 ToIntMargin                              float IL2CPP_TYPE_R4
    // 080 ExLeftHandIK                             00018666ED60 ModelEnumType ExternalIKData ExternalIKData ExternalIKData Int32
    // 088 ExRightHandIK                            00018666ED60 ModelEnumType ExternalIKData ExternalIKData ExternalIKData Int32
    // 090 LastEyelidData                           00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 098 LastTargetData                           00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0A0 NextTargetData                           00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0A8 LastLeftIKData                           00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0B0 LastRightIKData                          00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0B8 LastEyebrowData                          00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0C0 LastEyebrowAddData                       00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0C8 LastMouthData                            00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0D0 LastEyeLimitData                         00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0D8 LastEyebrowRate                          0001866656B0 ModelPrimitiveType float float float Single
    // 0DC LastEyebrowAddRate                       0001866656B0 ModelPrimitiveType float float float Single
    // 0E0 LastMouthRate                            0001866656B0 ModelPrimitiveType float float float Single
    // 0E4 LastTarget                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0E8 ExternalLipFlag                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0EC LastFrame                                0001866656B0 ModelPrimitiveType float float float Single
    // 0F0 LastDataCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0F4 HandOffsetL                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 100 HandOffsetR                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 10C HandBaseRotL                             000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 11C HandBaseRotR                             000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 130 NameTable                                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ExpressionEvent
    {
        public Character?                               Character                               { get; set; }
        public EyeController?                           EyeL                                    { get; set; }
        public EyeController?                           EyeR                                    { get; set; }
        public Animator?                                FaceAnimator                            { get; set; }
        public List<ExpressionData>?                    ExpData                                 { get; set; }
        public string                                   AnimationName                           { get; set; }
        public PlayableDirector?                        Timeline                                { get; set; }
        public List<Transform>?                         IkTarget                                { get; set; }
        public List<IKSave>?                            IkTargetSave                            { get; set; }
        public bool                                     IsDirectFrame                           { get; set; }
        public int                                      DirectFrame                             { get; set; }
        public int                                      DefaultCharacterID                      { get; set; }
        public bool                                     IsExpressionCancel                      { get; set; }
        public bool                                     IsAlwaysSerious                         { get; set; }
        public ExternalIKData                           ExLeftHandIK                            { get; set; }
        public ExternalIKData                           ExRightHandIK                           { get; set; }
        public ExpressionData?                          LastEyelidData                          { get; set; }
        public ExpressionData?                          LastTargetData                          { get; set; }
        public ExpressionData?                          NextTargetData                          { get; set; }
        public ExpressionData?                          LastLeftIKData                          { get; set; }
        public ExpressionData?                          LastRightIKData                         { get; set; }
        public ExpressionData?                          LastEyebrowData                         { get; set; }
        public ExpressionData?                          LastEyebrowAddData                      { get; set; }
        public ExpressionData?                          LastMouthData                           { get; set; }
        public ExpressionData?                          LastEyeLimitData                        { get; set; }
        public float                                    LastEyebrowRate                         { get; set; }
        public float                                    LastEyebrowAddRate                      { get; set; }
        public float                                    LastMouthRate                           { get; set; }
        public int                                      LastTarget                              { get; set; }
        public bool                                     ExternalLipFlag                         { get; set; }
        public float                                    LastFrame                               { get; set; }
        public int                                      LastDataCount                           { get; set; }
        public Vector3                                  HandOffsetL                             { get; set; }
        public Vector3                                  HandOffsetR                             { get; set; }
        public Quaternion                               HandBaseRotL                            { get; set; }
        public Quaternion                               HandBaseRotR                            { get; set; }
        public List<string>?                            NameTable                               { get; set; }

        public static ExpressionEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpressionEvent();

            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x020), ReversePrism.DataModels.Character.FromPointer); // 027006A94D70 0x20 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )
            value.EyeL                                      = GetObject<EyeController>(new IntPtr(p + 0x028), ReversePrism.DataModels.EyeController.FromPointer); // 027006A94D90 0x28 EyeL                        ( 0001865401E0 ModelClassType EyeController EyeController EyeController Pointer )
            value.EyeR                                      = GetObject<EyeController>(new IntPtr(p + 0x030), ReversePrism.DataModels.EyeController.FromPointer); // 027006A94DB0 0x30 EyeR                        ( 0001865401E0 ModelClassType EyeController EyeController EyeController Pointer )
            value.FaceAnimator                              = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 027006A94DD0 0x38 FaceAnimator                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ExpData                                   = GetObjectList<ExpressionData>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExpressionData.FromPointer); // 027006A94DF0 0x40 ExpData                     ( 000185D238A8 ModelClassListType List`1<ExpressionData> List`1<ExpressionData> List<ExpressionData> Pointer )
            value.AnimationName                             = GetString(new IntPtr(p + 0x048)); // 027006A94E10 0x48 AnimationName               ( 000186671910 ModelPrimitiveType string string string String )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x050), ReversePrism.DataModels.PlayableDirector.FromPointer); // 027006A94E30 0x50 Timeline                    ( 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.IkTarget                                  = GetObjectList<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 027006A94E50 0x58 IkTarget                    ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.IkTargetSave                              = GetObjectList<IKSave>(new IntPtr(p + 0x060), ReversePrism.DataModels.IKSave.FromPointer); // 027006A94E70 0x60 IkTargetSave                ( 000185CBA628 ModelClassListType IKSave[] IKSave[] List<IKSave> Pointer )
            value.IsDirectFrame                             = GetBool(new IntPtr(p + 0x068)); // 027006A94EB0 0x68 IsDirectFrame               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DirectFrame                               = GetInt32(new IntPtr(p + 0x06C)); // 027006A94ED0 0x6C DirectFrame                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DefaultCharacterID                        = GetInt32(new IntPtr(p + 0x070)); // 027006A94EF0 0x70 DefaultCharacterID          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsExpressionCancel                        = GetBool(new IntPtr(p + 0x074)); // 027006A94F10 0x74 IsExpressionCancel          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAlwaysSerious                           = GetBool(new IntPtr(p + 0x075)); // 027006A94F30 0x75 IsAlwaysSerious             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ExLeftHandIK                              = (ExternalIKData)GetInt32(new IntPtr(p + 0x080)); // 027006A94F90 0x80 ExLeftHandIK                ( 00018666ED60 ModelEnumType ExternalIKData ExternalIKData ExternalIKData Int32 )
            value.ExRightHandIK                             = (ExternalIKData)GetInt32(new IntPtr(p + 0x088)); // 027006A94FB0 0x88 ExRightHandIK               ( 00018666ED60 ModelEnumType ExternalIKData ExternalIKData ExternalIKData Int32 )
            value.LastEyelidData                            = GetObject<ExpressionData>(new IntPtr(p + 0x090), ReversePrism.DataModels.ExpressionData.FromPointer); // 027006A94FD0 0x90 LastEyelidData              ( 00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastTargetData                            = GetObject<ExpressionData>(new IntPtr(p + 0x098), ReversePrism.DataModels.ExpressionData.FromPointer); // 027006A94FF0 0x98 LastTargetData              ( 00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.NextTargetData                            = GetObject<ExpressionData>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ExpressionData.FromPointer); // 027006A95010 0xA0 NextTargetData              ( 00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastLeftIKData                            = GetObject<ExpressionData>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ExpressionData.FromPointer); // 027006A95030 0xA8 LastLeftIKData              ( 00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastRightIKData                           = GetObject<ExpressionData>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ExpressionData.FromPointer); // 027006A95050 0xB0 LastRightIKData             ( 00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastEyebrowData                           = GetObject<ExpressionData>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ExpressionData.FromPointer); // 027006A95070 0xB8 LastEyebrowData             ( 00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastEyebrowAddData                        = GetObject<ExpressionData>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ExpressionData.FromPointer); // 027006A95090 0xC0 LastEyebrowAddData          ( 00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastMouthData                             = GetObject<ExpressionData>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ExpressionData.FromPointer); // 027006A950B0 0xC8 LastMouthData               ( 00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastEyeLimitData                          = GetObject<ExpressionData>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ExpressionData.FromPointer); // 027006A950D0 0xD0 LastEyeLimitData            ( 00018666E8A0 ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastEyebrowRate                           = GetSingle(new IntPtr(p + 0x0D8)); // 027006A950F0 0xD8 LastEyebrowRate             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LastEyebrowAddRate                        = GetSingle(new IntPtr(p + 0x0DC)); // 027006A95110 0xDC LastEyebrowAddRate          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LastMouthRate                             = GetSingle(new IntPtr(p + 0x0E0)); // 027006A95130 0xE0 LastMouthRate               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LastTarget                                = GetInt32(new IntPtr(p + 0x0E4)); // 027006A95150 0xE4 LastTarget                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ExternalLipFlag                           = GetBool(new IntPtr(p + 0x0E8)); // 027006A95170 0xE8 ExternalLipFlag             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastFrame                                 = GetSingle(new IntPtr(p + 0x0EC)); // 027006A95190 0xEC LastFrame                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LastDataCount                             = GetInt32(new IntPtr(p + 0x0F0)); // 027006A951B0 0xF0 LastDataCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HandOffsetL                               = (Vector3)GetInt32(new IntPtr(p + 0x0F4)); // 027006A951D0 0xF4 HandOffsetL                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandOffsetR                               = (Vector3)GetInt32(new IntPtr(p + 0x100)); // 027006A951F0 0x100 HandOffsetR                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandBaseRotL                              = (Quaternion)GetInt32(new IntPtr(p + 0x10C)); // 027006A95210 0x10C HandBaseRotL                ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.HandBaseRotR                              = (Quaternion)GetInt32(new IntPtr(p + 0x11C)); // 027006A95230 0x11C HandBaseRotR                ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.NameTable                                 = GetStringList(new IntPtr(p + 0x130)); // 027006A95250 0x130 NameTable                   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
