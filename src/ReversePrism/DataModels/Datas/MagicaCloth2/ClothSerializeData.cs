using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClothType                                ModelEnumType ClothType ClothType ClothType Int32
    // 018 SourceRenderers                          ModelClassListType List`1<Renderer> List`1<Renderer> List<Renderer> Pointer
    // 020 PaintMode                                ModelEnumType PaintMode PaintMode PaintMode Int32
    // 028 PaintMaps                                ModelClassListType List`1<Texture2D> List`1<Texture2D> List<Texture2D> Pointer
    // 030 RootBones                                ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 038 ConnectionMode                           ModelEnumType BoneConnectionMode BoneConnectionMode BoneConnectionMode Int32
    // 03C RotationalInterpolation                  ModelPrimitiveType float float float Single
    // 040 RootRotation                             ModelPrimitiveType float float float Single
    // 044 UpdateMode                               ModelEnumType ClothUpdateMode ClothUpdateMode ClothUpdateMode Int32
    // 048 AnimationPoseRatio                       ModelPrimitiveType float float float Single
    // 050 ReductionSetting                         ModelClassType ReductionSettings ReductionSettings ReductionSettings Pointer
    // 058 CustomSkinningSetting                    ModelClassType CustomSkinningSettings CustomSkinningSettings CustomSkinningSettings Pointer
    // 060 NormalAlignmentSetting                   ModelClassType NormalAlignmentSettings NormalAlignmentSettings NormalAlignmentSettings Pointer
    // 068 CullingSettings                          ModelClassType CullingSettings CullingSettings CullingSettings Pointer
    // 070 NormalAxis                               ModelEnumType ClothNormalAxis ClothNormalAxis ClothNormalAxis Int32
    // 074 Gravity                                  ModelPrimitiveType float float float Single
    // 078 GravityDirection                         ModelEnumType float3 float3 float3 Int32
    // 084 GravityFalloff                           ModelPrimitiveType float float float Single
    // 088 StablizationTimeAfterReset               ModelPrimitiveType float float float Single
    // 08C BlendWeight                              ModelPrimitiveType float float float Single
    // 090 Damping                                  ModelClassType CurveSerializeData CurveSerializeData CurveSerializeData Pointer
    // 098 Radius                                   ModelClassType CurveSerializeData CurveSerializeData CurveSerializeData Pointer
    // 0A0 InertiaConstraint                        ModelClassType SerializeData SerializeData SerializeData Pointer
    // 0A8 TetherConstraint                         ModelClassType SerializeData SerializeData SerializeData Pointer
    // 0B0 DistanceConstraint                       ModelClassType SerializeData SerializeData SerializeData Pointer
    // 0B8 TriangleBendingConstraint                ModelClassType SerializeData SerializeData SerializeData Pointer
    // 0C0 AngleRestorationConstraint               ModelClassType RestorationSerializeData RestorationSerializeData RestorationSerializeData Pointer
    // 0C8 AngleLimitConstraint                     ModelClassType LimitSerializeData LimitSerializeData LimitSerializeData Pointer
    // 0D0 MotionConstraint                         ModelClassType SerializeData SerializeData SerializeData Pointer
    // 0D8 ColliderCollisionConstraint              ModelClassType SerializeData SerializeData SerializeData Pointer
    // 0E0 SelfCollisionConstraint                  ModelClassType SerializeData SerializeData SerializeData Pointer
    // 0E8 Wind                                     ModelClassType WindSettings WindSettings WindSettings Pointer
    // 0F0 SpringConstraint                         ModelClassType SerializeData SerializeData SerializeData Pointer
    // 0F8 VerificationResult                       ModelEnumType ResultCode ResultCode ResultCode Int32
    public partial class ClothSerializeData : DataModel
    {
        public ClothType                                ClothType                               { get; set; }
        public List<Renderer>?                          SourceRenderers                         { get; set; }
        public PaintMode                                PaintMode                               { get; set; }
        public List<Texture2D>?                         PaintMaps                               { get; set; }
        public List<Transform>?                         RootBones                               { get; set; }
        public BoneConnectionMode                       ConnectionMode                          { get; set; }
        public float                                    RotationalInterpolation                 { get; set; }
        public float                                    RootRotation                            { get; set; }
        public ClothUpdateMode                          UpdateMode                              { get; set; }
        public float                                    AnimationPoseRatio                      { get; set; }
        public ReductionSettings?                       ReductionSetting                        { get; set; }
        public CustomSkinningSettings?                  CustomSkinningSetting                   { get; set; }
        public NormalAlignmentSettings?                 NormalAlignmentSetting                  { get; set; }
        public CullingSettings?                         CullingSettings                         { get; set; }
        public ClothNormalAxis                          NormalAxis                              { get; set; }
        public float                                    Gravity                                 { get; set; }
        public float3                                   GravityDirection                        { get; set; }
        public float                                    GravityFalloff                          { get; set; }
        public float                                    StablizationTimeAfterReset              { get; set; }
        public float                                    BlendWeight                             { get; set; }
        public CurveSerializeData?                      Damping                                 { get; set; }
        public CurveSerializeData?                      Radius                                  { get; set; }
        public SerializeData?                           InertiaConstraint                       { get; set; }
        public SerializeData?                           TetherConstraint                        { get; set; }
        public SerializeData?                           DistanceConstraint                      { get; set; }
        public SerializeData?                           TriangleBendingConstraint               { get; set; }
        public RestorationSerializeData?                AngleRestorationConstraint              { get; set; }
        public LimitSerializeData?                      AngleLimitConstraint                    { get; set; }
        public SerializeData?                           MotionConstraint                        { get; set; }
        public SerializeData?                           ColliderCollisionConstraint             { get; set; }
        public SerializeData?                           SelfCollisionConstraint                 { get; set; }
        public WindSettings?                            Wind                                    { get; set; }
        public SerializeData?                           SpringConstraint                        { get; set; }
        public ResultCode                               VerificationResult                      { get; set; }

        public static ClothSerializeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClothSerializeData() { Pointer= p0 };

            value.ClothType                                 = (ClothType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ClothType                   ( ModelEnumType ClothType ClothType ClothType Int32 )
            value.SourceRenderers                           = GetObjectList<Renderer>(new IntPtr(p + 0x018), ReversePrism.DataModels.Renderer.FromPointer); // 0x18 SourceRenderers             ( ModelClassListType List`1<Renderer> List`1<Renderer> List<Renderer> Pointer )
            value.PaintMode                                 = (PaintMode)GetInt32(new IntPtr(p + 0x020)); // 0x20 PaintMode                   ( ModelEnumType PaintMode PaintMode PaintMode Int32 )
            value.PaintMaps                                 = GetObjectList<Texture2D>(new IntPtr(p + 0x028), ReversePrism.DataModels.Texture2D.FromPointer); // 0x28 PaintMaps                   ( ModelClassListType List`1<Texture2D> List`1<Texture2D> List<Texture2D> Pointer )
            value.RootBones                                 = GetObjectList<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 RootBones                   ( ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.ConnectionMode                            = (BoneConnectionMode)GetInt32(new IntPtr(p + 0x038)); // 0x38 ConnectionMode              ( ModelEnumType BoneConnectionMode BoneConnectionMode BoneConnectionMode Int32 )
            value.RotationalInterpolation                   = GetSingle(new IntPtr(p + 0x03C)); // 0x3C RotationalInterpolation     ( ModelPrimitiveType float float float Single )
            value.RootRotation                              = GetSingle(new IntPtr(p + 0x040)); // 0x40 RootRotation                ( ModelPrimitiveType float float float Single )
            value.UpdateMode                                = (ClothUpdateMode)GetInt32(new IntPtr(p + 0x044)); // 0x44 UpdateMode                  ( ModelEnumType ClothUpdateMode ClothUpdateMode ClothUpdateMode Int32 )
            value.AnimationPoseRatio                        = GetSingle(new IntPtr(p + 0x048)); // 0x48 AnimationPoseRatio          ( ModelPrimitiveType float float float Single )
            value.ReductionSetting                          = GetObject<ReductionSettings>(new IntPtr(p + 0x050), ReversePrism.DataModels.ReductionSettings.FromPointer); // 0x50 ReductionSetting            ( ModelClassType ReductionSettings ReductionSettings ReductionSettings Pointer )
            value.CustomSkinningSetting                     = GetObject<CustomSkinningSettings>(new IntPtr(p + 0x058), ReversePrism.DataModels.CustomSkinningSettings.FromPointer); // 0x58 CustomSkinningSetting       ( ModelClassType CustomSkinningSettings CustomSkinningSettings CustomSkinningSettings Pointer )
            value.NormalAlignmentSetting                    = GetObject<NormalAlignmentSettings>(new IntPtr(p + 0x060), ReversePrism.DataModels.NormalAlignmentSettings.FromPointer); // 0x60 NormalAlignmentSetting      ( ModelClassType NormalAlignmentSettings NormalAlignmentSettings NormalAlignmentSettings Pointer )
            value.CullingSettings                           = GetObject<CullingSettings>(new IntPtr(p + 0x068), ReversePrism.DataModels.CullingSettings.FromPointer); // 0x68 CullingSettings             ( ModelClassType CullingSettings CullingSettings CullingSettings Pointer )
            value.NormalAxis                                = (ClothNormalAxis)GetInt32(new IntPtr(p + 0x070)); // 0x70 NormalAxis                  ( ModelEnumType ClothNormalAxis ClothNormalAxis ClothNormalAxis Int32 )
            value.Gravity                                   = GetSingle(new IntPtr(p + 0x074)); // 0x74 Gravity                     ( ModelPrimitiveType float float float Single )
            value.GravityDirection                          = (float3)GetInt32(new IntPtr(p + 0x078)); // 0x78 GravityDirection            ( ModelEnumType float3 float3 float3 Int32 )
            value.GravityFalloff                            = GetSingle(new IntPtr(p + 0x084)); // 0x84 GravityFalloff              ( ModelPrimitiveType float float float Single )
            value.StablizationTimeAfterReset                = GetSingle(new IntPtr(p + 0x088)); // 0x88 StablizationTimeAfterReset  ( ModelPrimitiveType float float float Single )
            value.BlendWeight                               = GetSingle(new IntPtr(p + 0x08C)); // 0x8C BlendWeight                 ( ModelPrimitiveType float float float Single )
            value.Damping                                   = GetObject<CurveSerializeData>(new IntPtr(p + 0x090), ReversePrism.DataModels.CurveSerializeData.FromPointer); // 0x90 Damping                     ( ModelClassType CurveSerializeData CurveSerializeData CurveSerializeData Pointer )
            value.Radius                                    = GetObject<CurveSerializeData>(new IntPtr(p + 0x098), ReversePrism.DataModels.CurveSerializeData.FromPointer); // 0x98 Radius                      ( ModelClassType CurveSerializeData CurveSerializeData CurveSerializeData Pointer )
            value.InertiaConstraint                         = GetObject<SerializeData>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SerializeData.FromPointer); // 0xA0 InertiaConstraint           ( ModelClassType SerializeData SerializeData SerializeData Pointer )
            value.TetherConstraint                          = GetObject<SerializeData>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SerializeData.FromPointer); // 0xA8 TetherConstraint            ( ModelClassType SerializeData SerializeData SerializeData Pointer )
            value.DistanceConstraint                        = GetObject<SerializeData>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SerializeData.FromPointer); // 0xB0 DistanceConstraint          ( ModelClassType SerializeData SerializeData SerializeData Pointer )
            value.TriangleBendingConstraint                 = GetObject<SerializeData>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.SerializeData.FromPointer); // 0xB8 TriangleBendingConstraint   ( ModelClassType SerializeData SerializeData SerializeData Pointer )
            value.AngleRestorationConstraint                = GetObject<RestorationSerializeData>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.RestorationSerializeData.FromPointer); // 0xC0 AngleRestorationConstraint  ( ModelClassType RestorationSerializeData RestorationSerializeData RestorationSerializeData Pointer )
            value.AngleLimitConstraint                      = GetObject<LimitSerializeData>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.LimitSerializeData.FromPointer); // 0xC8 AngleLimitConstraint        ( ModelClassType LimitSerializeData LimitSerializeData LimitSerializeData Pointer )
            value.MotionConstraint                          = GetObject<SerializeData>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SerializeData.FromPointer); // 0xD0 MotionConstraint            ( ModelClassType SerializeData SerializeData SerializeData Pointer )
            value.ColliderCollisionConstraint               = GetObject<SerializeData>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.SerializeData.FromPointer); // 0xD8 ColliderCollisionConstraint ( ModelClassType SerializeData SerializeData SerializeData Pointer )
            value.SelfCollisionConstraint                   = GetObject<SerializeData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.SerializeData.FromPointer); // 0xE0 SelfCollisionConstraint     ( ModelClassType SerializeData SerializeData SerializeData Pointer )
            value.Wind                                      = GetObject<WindSettings>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.WindSettings.FromPointer); // 0xE8 Wind                        ( ModelClassType WindSettings WindSettings WindSettings Pointer )
            value.SpringConstraint                          = GetObject<SerializeData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.SerializeData.FromPointer); // 0xF0 SpringConstraint            ( ModelClassType SerializeData SerializeData SerializeData Pointer )
            value.VerificationResult                        = (ResultCode)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 VerificationResult          ( ModelEnumType ResultCode ResultCode ResultCode Int32 )

            return value;
        }
    }
}
