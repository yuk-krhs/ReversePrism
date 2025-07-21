using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Character                                ModelClassType Character Character Character Pointer
    // 028 EyeL                                     ModelClassType EyeController EyeController EyeController Pointer
    // 030 EyeR                                     ModelClassType EyeController EyeController EyeController Pointer
    // 038 FaceAnimator                             ModelClassType Animator Animator Animator Pointer
    // 040 ExpData                                  ModelClassListType List`1<ExpressionData> List`1<ExpressionData> List<ExpressionData> Pointer
    // 048 AnimationName                            ModelPrimitiveType string string string String
    // 050 Timeline                                 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 058 IkTarget                                 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 060 IkTargetSave                             ModelClassListType IKSave[] IKSave[] List<IKSave> Pointer
    // 000 LERP_FRAME                               int IL2CPP_TYPE_I4
    // 068 IsDirectFrame                            ModelPrimitiveType bool bool bool Bool
    // 06C DirectFrame                              ModelPrimitiveType int int int Int32
    // 070 DefaultCharacterID                       ModelPrimitiveType int int int Int32
    // 074 IsExpressionCancel                       ModelPrimitiveType bool bool bool Bool
    // 075 IsAlwaysSerious                          ModelPrimitiveType bool bool bool Bool
    // 078 dicValue                                 Dictionary`2<string, float> IL2CPP_TYPE_GENERICINST
    // 000 ToIntMargin                              float IL2CPP_TYPE_R4
    // 080 ExLeftHandIK                             ModelEnumType ExternalIKData ExternalIKData ExternalIKData Int32
    // 088 ExRightHandIK                            ModelEnumType ExternalIKData ExternalIKData ExternalIKData Int32
    // 090 LastEyelidData                           ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 098 LastTargetData                           ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0A0 NextTargetData                           ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0A8 LastLeftIKData                           ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0B0 LastRightIKData                          ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0B8 LastEyebrowData                          ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0C0 LastEyebrowAddData                       ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0C8 LastMouthData                            ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0D0 LastEyeLimitData                         ModelClassType ExpressionData ExpressionData ExpressionData Pointer
    // 0D8 LastEyebrowRate                          ModelPrimitiveType float float float Single
    // 0DC LastEyebrowAddRate                       ModelPrimitiveType float float float Single
    // 0E0 LastMouthRate                            ModelPrimitiveType float float float Single
    // 0E4 LastTarget                               ModelPrimitiveType int int int Int32
    // 0E8 ExternalLipFlag                          ModelPrimitiveType bool bool bool Bool
    // 0EC LastFrame                                ModelPrimitiveType float float float Single
    // 0F0 LastDataCount                            ModelPrimitiveType int int int Int32
    // 0F4 HandOffsetL                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 100 HandOffsetR                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 10C HandBaseRotL                             ModelEnumType Quaternion Quaternion Quaternion Int32
    // 11C HandBaseRotR                             ModelEnumType Quaternion Quaternion Quaternion Int32
    // 130 NameTable                                ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ExpressionEvent : DataModel
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
            var value   = new ExpressionEvent() { Pointer= p0 };

            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x020), ReversePrism.DataModels.Character.FromPointer); // 0x20 Character                   ( ModelClassType Character Character Character Pointer )
            value.EyeL                                      = GetObject<EyeController>(new IntPtr(p + 0x028), ReversePrism.DataModels.EyeController.FromPointer); // 0x28 EyeL                        ( ModelClassType EyeController EyeController EyeController Pointer )
            value.EyeR                                      = GetObject<EyeController>(new IntPtr(p + 0x030), ReversePrism.DataModels.EyeController.FromPointer); // 0x30 EyeR                        ( ModelClassType EyeController EyeController EyeController Pointer )
            value.FaceAnimator                              = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 FaceAnimator                ( ModelClassType Animator Animator Animator Pointer )
            value.ExpData                                   = GetObjectList<ExpressionData>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExpressionData.FromPointer); // 0x40 ExpData                     ( ModelClassListType List`1<ExpressionData> List`1<ExpressionData> List<ExpressionData> Pointer )
            value.AnimationName                             = GetString(new IntPtr(p + 0x048)); // 0x48 AnimationName               ( ModelPrimitiveType string string string String )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x050), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x50 Timeline                    ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.IkTarget                                  = GetObjectList<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0x58 IkTarget                    ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.IkTargetSave                              = GetObjectList<IKSave>(new IntPtr(p + 0x060), ReversePrism.DataModels.IKSave.FromPointer); // 0x60 IkTargetSave                ( ModelClassListType IKSave[] IKSave[] List<IKSave> Pointer )
            value.IsDirectFrame                             = GetBool(new IntPtr(p + 0x068)); // 0x68 IsDirectFrame               ( ModelPrimitiveType bool bool bool Bool )
            value.DirectFrame                               = GetInt32(new IntPtr(p + 0x06C)); // 0x6C DirectFrame                 ( ModelPrimitiveType int int int Int32 )
            value.DefaultCharacterID                        = GetInt32(new IntPtr(p + 0x070)); // 0x70 DefaultCharacterID          ( ModelPrimitiveType int int int Int32 )
            value.IsExpressionCancel                        = GetBool(new IntPtr(p + 0x074)); // 0x74 IsExpressionCancel          ( ModelPrimitiveType bool bool bool Bool )
            value.IsAlwaysSerious                           = GetBool(new IntPtr(p + 0x075)); // 0x75 IsAlwaysSerious             ( ModelPrimitiveType bool bool bool Bool )
            value.ExLeftHandIK                              = (ExternalIKData)GetInt32(new IntPtr(p + 0x080)); // 0x80 ExLeftHandIK                ( ModelEnumType ExternalIKData ExternalIKData ExternalIKData Int32 )
            value.ExRightHandIK                             = (ExternalIKData)GetInt32(new IntPtr(p + 0x088)); // 0x88 ExRightHandIK               ( ModelEnumType ExternalIKData ExternalIKData ExternalIKData Int32 )
            value.LastEyelidData                            = GetObject<ExpressionData>(new IntPtr(p + 0x090), ReversePrism.DataModels.ExpressionData.FromPointer); // 0x90 LastEyelidData              ( ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastTargetData                            = GetObject<ExpressionData>(new IntPtr(p + 0x098), ReversePrism.DataModels.ExpressionData.FromPointer); // 0x98 LastTargetData              ( ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.NextTargetData                            = GetObject<ExpressionData>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ExpressionData.FromPointer); // 0xA0 NextTargetData              ( ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastLeftIKData                            = GetObject<ExpressionData>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ExpressionData.FromPointer); // 0xA8 LastLeftIKData              ( ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastRightIKData                           = GetObject<ExpressionData>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ExpressionData.FromPointer); // 0xB0 LastRightIKData             ( ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastEyebrowData                           = GetObject<ExpressionData>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ExpressionData.FromPointer); // 0xB8 LastEyebrowData             ( ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastEyebrowAddData                        = GetObject<ExpressionData>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ExpressionData.FromPointer); // 0xC0 LastEyebrowAddData          ( ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastMouthData                             = GetObject<ExpressionData>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ExpressionData.FromPointer); // 0xC8 LastMouthData               ( ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastEyeLimitData                          = GetObject<ExpressionData>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ExpressionData.FromPointer); // 0xD0 LastEyeLimitData            ( ModelClassType ExpressionData ExpressionData ExpressionData Pointer )
            value.LastEyebrowRate                           = GetSingle(new IntPtr(p + 0x0D8)); // 0xD8 LastEyebrowRate             ( ModelPrimitiveType float float float Single )
            value.LastEyebrowAddRate                        = GetSingle(new IntPtr(p + 0x0DC)); // 0xDC LastEyebrowAddRate          ( ModelPrimitiveType float float float Single )
            value.LastMouthRate                             = GetSingle(new IntPtr(p + 0x0E0)); // 0xE0 LastMouthRate               ( ModelPrimitiveType float float float Single )
            value.LastTarget                                = GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 LastTarget                  ( ModelPrimitiveType int int int Int32 )
            value.ExternalLipFlag                           = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 ExternalLipFlag             ( ModelPrimitiveType bool bool bool Bool )
            value.LastFrame                                 = GetSingle(new IntPtr(p + 0x0EC)); // 0xEC LastFrame                   ( ModelPrimitiveType float float float Single )
            value.LastDataCount                             = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 LastDataCount               ( ModelPrimitiveType int int int Int32 )
            value.HandOffsetL                               = (Vector3)GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 HandOffsetL                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandOffsetR                               = (Vector3)GetInt32(new IntPtr(p + 0x100)); // 0x100 HandOffsetR                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandBaseRotL                              = (Quaternion)GetInt32(new IntPtr(p + 0x10C)); // 0x10C HandBaseRotL                ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.HandBaseRotR                              = (Quaternion)GetInt32(new IntPtr(p + 0x11C)); // 0x11C HandBaseRotR                ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.NameTable                                 = GetStringList(new IntPtr(p + 0x130)); // 0x130 NameTable                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
