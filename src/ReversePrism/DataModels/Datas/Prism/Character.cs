using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EmptyId                                  int IL2CPP_TYPE_I4
    // 000 ProducerId                               int IL2CPP_TYPE_I4
    // 000 UnknownId                                int IL2CPP_TYPE_I4
    // 020 MyAnimator                               ModelClassType Animator Animator Animator Pointer
    // 028 FaceAnimator                             ModelClassType Animator Animator Animator Pointer
    // 030 BasePosition                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C IsStreamingCharacter                     ModelPrimitiveType bool bool bool Bool
    // 03D IsStopUpdate                             ModelPrimitiveType bool bool bool Bool
    // 03E IsRecordedAnimation                      ModelPrimitiveType bool bool bool Bool
    // 03F AnimationOverwrite                       ModelPrimitiveType bool bool bool Bool
    // 040 Renderers                                ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer
    // 048 IsNoPersonalLight                        ModelPrimitiveType bool bool bool Bool
    // 050 OutlineController                        ModelClassType OutlineController OutlineController OutlineController Pointer
    // 058 HairZBiasController                      ModelClassType HairZBiasController HairZBiasController HairZBiasController Pointer
    // 060 LipSyncController                        ModelClassType LipSyncController LipSyncController LipSyncController Pointer
    // 068 AngelRingController                      ModelClassType AngelRingController AngelRingController AngelRingController Pointer
    // 070 RecordedAnimPlayer                       ModelClassType RecordedAnimPlayer RecordedAnimPlayer RecordedAnimPlayer Pointer
    // 078 ExpressionEvent                          ModelClassType ExpressionEvent ExpressionEvent ExpressionEvent Pointer
    // 080 FaceAnimParam                            ModelClassType FaceAnimParam FaceAnimParam FaceAnimParam Pointer
    // 088 MasterCharaData                          ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 090 PlaneDropShadow                          ModelClassType PlaneDropShadow PlaneDropShadow PlaneDropShadow Pointer
    // 098 Timeline                                 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 0A0 CharacterIndex                           ModelPrimitiveType int int int Int32
    // 0A4 LipSyncOffsetTime                        ModelPrimitiveType float float float Single
    // 0A8 _myMaterials                             Material[][] IL2CPP_TYPE_SZARRAY
    // 000 NearBorder                               float IL2CPP_TYPE_R4
    // 000 IntermediateBorder                       float IL2CPP_TYPE_R4
    // 0B0 HandBaseRotL                             ModelEnumType Quaternion Quaternion Quaternion Int32
    // 0C0 HandBaseRotR                             ModelEnumType Quaternion Quaternion Quaternion Int32
    // 0D0 FlagNeckControl                          ModelPrimitiveType bool bool bool Bool
    // 0D4 NeckRate                                 ModelPrimitiveType float float float Single
    // 0D8 NeckWeight                               ModelPrimitiveType float float float Single
    // 0DC NeckTarget                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0E8 FlagHandControl                          ModelPrimitiveType bool bool bool Bool
    // 0F0 ClipInfoCache                            ModelEnumListType List`1<AnimatorClipInfo> List`1<AnimatorClipInfo> List<AnimatorClipInfo> Pointer
    // 0F8 AnimDelaySeed                            ModelPrimitiveType int int int Int32
    // 0FC AnimDelayPower                           ModelPrimitiveType float float float Single
    // 100 OverrideController                       ModelClassType AnimatorOverrideController AnimatorOverrideController AnimatorOverrideController Pointer
    public partial class Character : DataModel
    {
        public Animator?                                MyAnimator                              { get; set; }
        public Animator?                                FaceAnimator                            { get; set; }
        public Vector3                                  BasePosition                            { get; set; }
        public bool                                     IsStreamingCharacter                    { get; set; }
        public bool                                     IsStopUpdate                            { get; set; }
        public bool                                     IsRecordedAnimation                     { get; set; }
        public bool                                     AnimationOverwrite                      { get; set; }
        public List<Renderer>?                          Renderers                               { get; set; }
        public bool                                     IsNoPersonalLight                       { get; set; }
        public OutlineController?                       OutlineController                       { get; set; }
        public HairZBiasController?                     HairZBiasController                     { get; set; }
        public LipSyncController?                       LipSyncController                       { get; set; }
        public AngelRingController?                     AngelRingController                     { get; set; }
        public RecordedAnimPlayer?                      RecordedAnimPlayer                      { get; set; }
        public ExpressionEvent?                         ExpressionEvent                         { get; set; }
        public FaceAnimParam?                           FaceAnimParam                           { get; set; }
        public MstCharacterInfo?                        MasterCharaData                         { get; set; }
        public PlaneDropShadow?                         PlaneDropShadow                         { get; set; }
        public PlayableDirector?                        Timeline                                { get; set; }
        public int                                      CharacterIndex                          { get; set; }
        public float                                    LipSyncOffsetTime                       { get; set; }
        public Quaternion                               HandBaseRotL                            { get; set; }
        public Quaternion                               HandBaseRotR                            { get; set; }
        public bool                                     FlagNeckControl                         { get; set; }
        public float                                    NeckRate                                { get; set; }
        public float                                    NeckWeight                              { get; set; }
        public Vector3                                  NeckTarget                              { get; set; }
        public bool                                     FlagHandControl                         { get; set; }
        public List<AnimatorClipInfo>?                  ClipInfoCache                           { get; set; }
        public int                                      AnimDelaySeed                           { get; set; }
        public float                                    AnimDelayPower                          { get; set; }
        public AnimatorOverrideController?              OverrideController                      { get; set; }

        public static Character? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Character() { Pointer= p0 };

            value.MyAnimator                                = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0x20 MyAnimator                  ( ModelClassType Animator Animator Animator Pointer )
            value.FaceAnimator                              = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0x28 FaceAnimator                ( ModelClassType Animator Animator Animator Pointer )
            value.BasePosition                              = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0x30 BasePosition                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.IsStreamingCharacter                      = GetBool(new IntPtr(p + 0x03C)); // 0x3C IsStreamingCharacter        ( ModelPrimitiveType bool bool bool Bool )
            value.IsStopUpdate                              = GetBool(new IntPtr(p + 0x03D)); // 0x3D IsStopUpdate                ( ModelPrimitiveType bool bool bool Bool )
            value.IsRecordedAnimation                       = GetBool(new IntPtr(p + 0x03E)); // 0x3E IsRecordedAnimation         ( ModelPrimitiveType bool bool bool Bool )
            value.AnimationOverwrite                        = GetBool(new IntPtr(p + 0x03F)); // 0x3F AnimationOverwrite          ( ModelPrimitiveType bool bool bool Bool )
            value.Renderers                                 = GetObjectList<Renderer>(new IntPtr(p + 0x040), ReversePrism.DataModels.Renderer.FromPointer); // 0x40 Renderers                   ( ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer )
            value.IsNoPersonalLight                         = GetBool(new IntPtr(p + 0x048)); // 0x48 IsNoPersonalLight           ( ModelPrimitiveType bool bool bool Bool )
            value.OutlineController                         = GetObject<OutlineController>(new IntPtr(p + 0x050), ReversePrism.DataModels.OutlineController.FromPointer); // 0x50 OutlineController           ( ModelClassType OutlineController OutlineController OutlineController Pointer )
            value.HairZBiasController                       = GetObject<HairZBiasController>(new IntPtr(p + 0x058), ReversePrism.DataModels.HairZBiasController.FromPointer); // 0x58 HairZBiasController         ( ModelClassType HairZBiasController HairZBiasController HairZBiasController Pointer )
            value.LipSyncController                         = GetObject<LipSyncController>(new IntPtr(p + 0x060), ReversePrism.DataModels.LipSyncController.FromPointer); // 0x60 LipSyncController           ( ModelClassType LipSyncController LipSyncController LipSyncController Pointer )
            value.AngelRingController                       = GetObject<AngelRingController>(new IntPtr(p + 0x068), ReversePrism.DataModels.AngelRingController.FromPointer); // 0x68 AngelRingController         ( ModelClassType AngelRingController AngelRingController AngelRingController Pointer )
            value.RecordedAnimPlayer                        = GetObject<RecordedAnimPlayer>(new IntPtr(p + 0x070), ReversePrism.DataModels.RecordedAnimPlayer.FromPointer); // 0x70 RecordedAnimPlayer          ( ModelClassType RecordedAnimPlayer RecordedAnimPlayer RecordedAnimPlayer Pointer )
            value.ExpressionEvent                           = GetObject<ExpressionEvent>(new IntPtr(p + 0x078), ReversePrism.DataModels.ExpressionEvent.FromPointer); // 0x78 ExpressionEvent             ( ModelClassType ExpressionEvent ExpressionEvent ExpressionEvent Pointer )
            value.FaceAnimParam                             = GetObject<FaceAnimParam>(new IntPtr(p + 0x080), ReversePrism.DataModels.FaceAnimParam.FromPointer); // 0x80 FaceAnimParam               ( ModelClassType FaceAnimParam FaceAnimParam FaceAnimParam Pointer )
            value.MasterCharaData                           = GetObject<MstCharacterInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0x88 MasterCharaData             ( ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.PlaneDropShadow                           = GetObject<PlaneDropShadow>(new IntPtr(p + 0x090), ReversePrism.DataModels.PlaneDropShadow.FromPointer); // 0x90 PlaneDropShadow             ( ModelClassType PlaneDropShadow PlaneDropShadow PlaneDropShadow Pointer )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x098), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x98 Timeline                    ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.CharacterIndex                            = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 CharacterIndex              ( ModelPrimitiveType int int int Int32 )
            value.LipSyncOffsetTime                         = GetSingle(new IntPtr(p + 0x0A4)); // 0xA4 LipSyncOffsetTime           ( ModelPrimitiveType float float float Single )
            value.HandBaseRotL                              = (Quaternion)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 HandBaseRotL                ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.HandBaseRotR                              = (Quaternion)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 HandBaseRotR                ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.FlagNeckControl                           = GetBool(new IntPtr(p + 0x0D0)); // 0xD0 FlagNeckControl             ( ModelPrimitiveType bool bool bool Bool )
            value.NeckRate                                  = GetSingle(new IntPtr(p + 0x0D4)); // 0xD4 NeckRate                    ( ModelPrimitiveType float float float Single )
            value.NeckWeight                                = GetSingle(new IntPtr(p + 0x0D8)); // 0xD8 NeckWeight                  ( ModelPrimitiveType float float float Single )
            value.NeckTarget                                = (Vector3)GetInt32(new IntPtr(p + 0x0DC)); // 0xDC NeckTarget                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.FlagHandControl                           = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 FlagHandControl             ( ModelPrimitiveType bool bool bool Bool )
            value.ClipInfoCache                             = GetEnumList<AnimatorClipInfo>(new IntPtr(p + 0x0F0)); // 0xF0 ClipInfoCache               ( ModelEnumListType List`1<AnimatorClipInfo> List`1<AnimatorClipInfo> List<AnimatorClipInfo> Pointer )
            value.AnimDelaySeed                             = GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 AnimDelaySeed               ( ModelPrimitiveType int int int Int32 )
            value.AnimDelayPower                            = GetSingle(new IntPtr(p + 0x0FC)); // 0xFC AnimDelayPower              ( ModelPrimitiveType float float float Single )
            value.OverrideController                        = GetObject<AnimatorOverrideController>(new IntPtr(p + 0x100), ReversePrism.DataModels.AnimatorOverrideController.FromPointer); // 0x100 OverrideController          ( ModelClassType AnimatorOverrideController AnimatorOverrideController AnimatorOverrideController Pointer )

            return value;
        }
    }
}
