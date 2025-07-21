using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 initProfiler                             ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 preBuildProfiler                         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 PreBuildDeserializationProfiler          ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 PreBuildRegistrationProfiler             ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 010 Cloth                                    ModelClassType MagicaCloth MagicaCloth MagicaCloth Pointer
    // 018 SyncCloth                                ModelClassType MagicaCloth MagicaCloth MagicaCloth Pointer
    // 000 State_Valid                              int IL2CPP_TYPE_I4
    // 000 State_Enable                             int IL2CPP_TYPE_I4
    // 000 State_ParameterDirty                     int IL2CPP_TYPE_I4
    // 000 State_InitSuccess                        int IL2CPP_TYPE_I4
    // 000 State_InitComplete                       int IL2CPP_TYPE_I4
    // 000 State_Build                              int IL2CPP_TYPE_I4
    // 000 State_Running                            int IL2CPP_TYPE_I4
    // 000 State_DisableAutoBuild                   int IL2CPP_TYPE_I4
    // 000 State_CullingInvisible                   int IL2CPP_TYPE_I4
    // 000 State_CullingKeep                        int IL2CPP_TYPE_I4
    // 000 State_SkipWriting                        int IL2CPP_TYPE_I4
    // 000 State_SkipWritingDirty                   int IL2CPP_TYPE_I4
    // 000 State_UsePreBuild                        int IL2CPP_TYPE_I4
    // 020 StateFlag                                ModelEnumType BitField32 BitField32 BitField32 Int32
    // 028 ClothTransformRecord                     ModelClassType TransformRecord TransformRecord TransformRecord Pointer
    // 030 RenderHandleList                         ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 038 BoneClothSetupData                       ModelClassType RenderSetupData RenderSetupData RenderSetupData Pointer
    // 040 RenderMeshInfoList                       ModelClassListType List`1<RenderMeshInfo> List`1<RenderMeshInfo> List<RenderMeshInfo> Pointer
    // 048 CustomSkinningBoneRecords                ModelClassListType List`1<TransformRecord> List`1<TransformRecord> List<TransformRecord> Pointer
    // 050 NormalAdjustmentTransformRecord          ModelClassType TransformRecord TransformRecord TransformRecord Pointer
    // 058 Result                                   ModelEnumType ResultCode ResultCode ResultCode Int32
    // 060 ClothType                                ModelEnumType ClothType ClothType ClothType Int32
    // 068 ReductionSettings                        ModelClassType ReductionSettings ReductionSettings ReductionSettings Pointer
    // 070 Parameters                               ModelEnumType ClothParameters ClothParameters ClothParameters Int32
    // 390 ProxyMeshContainer                       ModelClassType VirtualMeshContainer VirtualMeshContainer VirtualMeshContainer Pointer
    // 398 ColliderList                             ModelClassListType List`1<ColliderComponent> List`1<ColliderComponent> List<ColliderComponent> Pointer
    // 3A0 TeamId                                   ModelPrimitiveType int int int Int32
    // 3A8 InertiaConstraintData                    ModelClassType ConstraintData ConstraintData ConstraintData Pointer
    // 3B0 DistanceConstraintData                   ModelClassType ConstraintData ConstraintData ConstraintData Pointer
    // 3B8 BendingConstraintData                    ModelClassType ConstraintData ConstraintData ConstraintData Pointer
    // 3C0 InterlockingAnimator                     ModelClassType Animator Animator Animator Pointer
    // 3C8 InterlockingAnimatorRenderers            ModelClassListType List`1<Renderer> List`1<Renderer> List<Renderer> Pointer
    // 3D0 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 3D8 lockObject                               <object> IL2CPP_TYPE_OBJECT
    // 3E0 lockState                                <object> IL2CPP_TYPE_OBJECT
    // 3E8 SuspendCounter                           ModelPrimitiveType int int int Int32
    // 3EC IsDestory                                ModelPrimitiveType bool bool bool Bool
    // 3ED IsDestoryInternal                        ModelPrimitiveType bool bool bool Bool
    // 3EE IsBuild                                  ModelPrimitiveType bool bool bool Bool
    public partial class ClothProcess : DataModel
    {
        public ProfilerMarker                           PreBuildDeserializationProfiler         { get; set; }
        public ProfilerMarker                           PreBuildRegistrationProfiler            { get; set; }
        public MagicaCloth?                             Cloth                                   { get; set; }
        public MagicaCloth?                             SyncCloth                               { get; set; }
        public BitField32                               StateFlag                               { get; set; }
        public TransformRecord?                         ClothTransformRecord                    { get; set; }
        public List<int>?                               RenderHandleList                        { get; set; }
        public RenderSetupData?                         BoneClothSetupData                      { get; set; }
        public List<RenderMeshInfo>?                    RenderMeshInfoList                      { get; set; }
        public List<TransformRecord>?                   CustomSkinningBoneRecords               { get; set; }
        public TransformRecord?                         NormalAdjustmentTransformRecord         { get; set; }
        public ResultCode                               Result                                  { get; set; }
        public ClothType                                ClothType                               { get; set; }
        public ReductionSettings?                       ReductionSettings                       { get; set; }
        public ClothParameters                          Parameters                              { get; set; }
        public VirtualMeshContainer?                    ProxyMeshContainer                      { get; set; }
        public List<ColliderComponent>?                 ColliderList                            { get; set; }
        public int                                      TeamId                                  { get; set; }
        public ConstraintData?                          InertiaConstraintData                   { get; set; }
        public ConstraintData?                          DistanceConstraintData                  { get; set; }
        public ConstraintData?                          BendingConstraintData                   { get; set; }
        public Animator?                                InterlockingAnimator                    { get; set; }
        public List<Renderer>?                          InterlockingAnimatorRenderers           { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public int                                      SuspendCounter                          { get; set; }
        public bool                                     IsDestory                               { get; set; }
        public bool                                     IsDestoryInternal                       { get; set; }
        public bool                                     IsBuild                                 { get; set; }

        public static ClothProcess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClothProcess() { Pointer= p0 };

            value.PreBuildDeserializationProfiler           = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0x10 PreBuildDeserializationProfiler ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.PreBuildRegistrationProfiler              = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0x18 PreBuildRegistrationProfiler ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.Cloth                                     = GetObject<MagicaCloth>(new IntPtr(p + 0x010), ReversePrism.DataModels.MagicaCloth.FromPointer); // 0x10 Cloth                       ( ModelClassType MagicaCloth MagicaCloth MagicaCloth Pointer )
            value.SyncCloth                                 = GetObject<MagicaCloth>(new IntPtr(p + 0x018), ReversePrism.DataModels.MagicaCloth.FromPointer); // 0x18 SyncCloth                   ( ModelClassType MagicaCloth MagicaCloth MagicaCloth Pointer )
            value.StateFlag                                 = (BitField32)GetInt32(new IntPtr(p + 0x020)); // 0x20 StateFlag                   ( ModelEnumType BitField32 BitField32 BitField32 Int32 )
            value.ClothTransformRecord                      = GetObject<TransformRecord>(new IntPtr(p + 0x028), ReversePrism.DataModels.TransformRecord.FromPointer); // 0x28 ClothTransformRecord        ( ModelClassType TransformRecord TransformRecord TransformRecord Pointer )
            value.RenderHandleList                          = GetInt32List(new IntPtr(p + 0x030)); // 0x30 RenderHandleList            ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.BoneClothSetupData                        = GetObject<RenderSetupData>(new IntPtr(p + 0x038), ReversePrism.DataModels.RenderSetupData.FromPointer); // 0x38 BoneClothSetupData          ( ModelClassType RenderSetupData RenderSetupData RenderSetupData Pointer )
            value.RenderMeshInfoList                        = GetObjectList<RenderMeshInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.RenderMeshInfo.FromPointer); // 0x40 RenderMeshInfoList          ( ModelClassListType List`1<RenderMeshInfo> List`1<RenderMeshInfo> List<RenderMeshInfo> Pointer )
            value.CustomSkinningBoneRecords                 = GetObjectList<TransformRecord>(new IntPtr(p + 0x048), ReversePrism.DataModels.TransformRecord.FromPointer); // 0x48 CustomSkinningBoneRecords   ( ModelClassListType List`1<TransformRecord> List`1<TransformRecord> List<TransformRecord> Pointer )
            value.NormalAdjustmentTransformRecord           = GetObject<TransformRecord>(new IntPtr(p + 0x050), ReversePrism.DataModels.TransformRecord.FromPointer); // 0x50 NormalAdjustmentTransformRecord ( ModelClassType TransformRecord TransformRecord TransformRecord Pointer )
            value.Result                                    = (ResultCode)GetInt32(new IntPtr(p + 0x058)); // 0x58 Result                      ( ModelEnumType ResultCode ResultCode ResultCode Int32 )
            value.ClothType                                 = (ClothType)GetInt32(new IntPtr(p + 0x060)); // 0x60 ClothType                   ( ModelEnumType ClothType ClothType ClothType Int32 )
            value.ReductionSettings                         = GetObject<ReductionSettings>(new IntPtr(p + 0x068), ReversePrism.DataModels.ReductionSettings.FromPointer); // 0x68 ReductionSettings           ( ModelClassType ReductionSettings ReductionSettings ReductionSettings Pointer )
            value.Parameters                                = (ClothParameters)GetInt32(new IntPtr(p + 0x070)); // 0x70 Parameters                  ( ModelEnumType ClothParameters ClothParameters ClothParameters Int32 )
            value.ProxyMeshContainer                        = GetObject<VirtualMeshContainer>(new IntPtr(p + 0x390), ReversePrism.DataModels.VirtualMeshContainer.FromPointer); // 0x390 ProxyMeshContainer          ( ModelClassType VirtualMeshContainer VirtualMeshContainer VirtualMeshContainer Pointer )
            value.ColliderList                              = GetObjectList<ColliderComponent>(new IntPtr(p + 0x398), ReversePrism.DataModels.ColliderComponent.FromPointer); // 0x398 ColliderList                ( ModelClassListType List`1<ColliderComponent> List`1<ColliderComponent> List<ColliderComponent> Pointer )
            value.TeamId                                    = GetInt32(new IntPtr(p + 0x3A0)); // 0x3A0 TeamId                      ( ModelPrimitiveType int int int Int32 )
            value.InertiaConstraintData                     = GetObject<ConstraintData>(new IntPtr(p + 0x3A8), ReversePrism.DataModels.ConstraintData.FromPointer); // 0x3A8 InertiaConstraintData       ( ModelClassType ConstraintData ConstraintData ConstraintData Pointer )
            value.DistanceConstraintData                    = GetObject<ConstraintData>(new IntPtr(p + 0x3B0), ReversePrism.DataModels.ConstraintData.FromPointer); // 0x3B0 DistanceConstraintData      ( ModelClassType ConstraintData ConstraintData ConstraintData Pointer )
            value.BendingConstraintData                     = GetObject<ConstraintData>(new IntPtr(p + 0x3B8), ReversePrism.DataModels.ConstraintData.FromPointer); // 0x3B8 BendingConstraintData       ( ModelClassType ConstraintData ConstraintData ConstraintData Pointer )
            value.InterlockingAnimator                      = GetObject<Animator>(new IntPtr(p + 0x3C0), ReversePrism.DataModels.Animator.FromPointer); // 0x3C0 InterlockingAnimator        ( ModelClassType Animator Animator Animator Pointer )
            value.InterlockingAnimatorRenderers             = GetObjectList<Renderer>(new IntPtr(p + 0x3C8), ReversePrism.DataModels.Renderer.FromPointer); // 0x3C8 InterlockingAnimatorRenderers ( ModelClassListType List`1<Renderer> List`1<Renderer> List<Renderer> Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x3D0 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.SuspendCounter                            = GetInt32(new IntPtr(p + 0x3E8)); // 0x3E8 SuspendCounter              ( ModelPrimitiveType int int int Int32 )
            value.IsDestory                                 = GetBool(new IntPtr(p + 0x3EC)); // 0x3EC IsDestory                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsDestoryInternal                         = GetBool(new IntPtr(p + 0x3ED)); // 0x3ED IsDestoryInternal           ( ModelPrimitiveType bool bool bool Bool )
            value.IsBuild                                   = GetBool(new IntPtr(p + 0x3EE)); // 0x3EE IsBuild                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
