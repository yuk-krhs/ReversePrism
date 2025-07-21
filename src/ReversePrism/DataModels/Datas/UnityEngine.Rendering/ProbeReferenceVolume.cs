using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_IsInitialized                          ModelPrimitiveType bool bool bool Bool
    // 011 M_SupportStreaming                       ModelPrimitiveType bool bool bool Bool
    // 014 M_Transform                              ModelEnumType RefVolTransform RefVolTransform RefVolTransform Int32
    // 034 M_MaxSubdivision                         ModelPrimitiveType int int int Int32
    // 038 M_Pool                                   ModelClassType ProbeBrickPool ProbeBrickPool ProbeBrickPool Pointer
    // 040 M_Index                                  ModelClassType ProbeBrickIndex ProbeBrickIndex ProbeBrickIndex Pointer
    // 048 M_CellIndices                            ModelClassType ProbeCellIndices ProbeCellIndices ProbeCellIndices Pointer
    // 050 M_BlendingPool                           ModelClassType ProbeBrickBlendingPool ProbeBrickBlendingPool ProbeBrickBlendingPool Pointer
    // 058 M_TmpSrcChunks                           ModelEnumListType List`1<BrickChunkAlloc> List`1<BrickChunkAlloc> List<BrickChunkAlloc> Pointer
    // 060 M_PositionOffsets                        ModelPrimitiveListType float[] float[] List<float> Pointer
    // 068 M_CurrGlobalBounds                       ModelEnumType Bounds Bounds Bounds Int32
    // 080 cells                                    Dictionary`2<int, CellInfo> IL2CPP_TYPE_GENERICINST
    // 088 m_CellInfoPool                           ObjectPool`1<CellInfo> IL2CPP_TYPE_GENERICINST
    // 090 m_BlendingCellInfoPool                   ObjectPool`1<BlendingCellInfo> IL2CPP_TYPE_GENERICINST
    // 098 M_TemporaryDataLocation                  ModelEnumType DataLocation DataLocation DataLocation Int32
    // 0E8 M_TemporaryDataLocationMemCost           ModelPrimitiveType int int int Int32
    // 0EC M_CurrentProbeVolumeChunkSizeInBricks    ModelPrimitiveType int int int Int32
    // 0F0 SceneData                                ModelClassType ProbeVolumeSceneData ProbeVolumeSceneData ProbeVolumeSceneData Pointer
    // 0F8 MinLoadedCellPos                         ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 104 MaxLoadedCellPos                         ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 110 retrieveExtraDataAction                  Action`1<ExtraDataActionInput> IL2CPP_TYPE_GENERICINST
    // 118 ChecksDuringBakeAction                   ModelClassType Action Action Action Pointer
    // 120 M_BricksLoaded                           ModelPrimitiveType bool bool bool Bool
    // 128 m_PendingAssetsToBeLoaded                Dictionary`2<string, ProbeVolumeAsset> IL2CPP_TYPE_GENERICINST
    // 130 m_PendingAssetsToBeUnloaded              Dictionary`2<string, ProbeVolumeAsset> IL2CPP_TYPE_GENERICINST
    // 138 m_ActiveAssets                           Dictionary`2<string, ProbeVolumeAsset> IL2CPP_TYPE_GENERICINST
    // 140 M_NeedLoadAsset                          ModelPrimitiveType bool bool bool Bool
    // 141 M_ProbeReferenceVolumeInit               ModelPrimitiveType bool bool bool Bool
    // 142 M_EnabledBySRP                           ModelPrimitiveType bool bool bool Bool
    // 144 M_PendingInitInfo                        ModelEnumType InitInfo InitInfo InitInfo Int32
    // 15C M_NeedsIndexRebuild                      ModelPrimitiveType bool bool bool Bool
    // 15D M_HasChangedIndex                        ModelPrimitiveType bool bool bool Bool
    // 160 M_CBShaderID                             ModelPrimitiveType int int int Int32
    // 164 M_NumberOfCellsLoadedPerFrame            ModelPrimitiveType int int int Int32
    // 168 M_NumberOfCellsBlendedPerFrame           ModelPrimitiveType int int int Int32
    // 16C M_TurnoverRate                           ModelPrimitiveType float float float Single
    // 170 M_MemoryBudget                           ModelEnumType ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget Int32
    // 174 M_BlendingMemoryBudget                   ModelEnumType ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget Int32
    // 178 M_SHBands                                ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32
    // 17C M_ProbeVolumesWeight                     ModelPrimitiveType float float float Single
    // 180 ClearAssetsOnVolumeClear                 ModelPrimitiveType bool bool bool Bool
    // 000 defaultLightingScenario                  string IL2CPP_TYPE_STRING
    // 008 _instance                                ProbeReferenceVolume IL2CPP_TYPE_CLASS
    // 188 PerSceneDataList                         ModelClassListType List`1<ProbeVolumePerSceneData> List`1<ProbeVolumePerSceneData> List<ProbeVolumePerSceneData> Pointer
    // 000 kProbesPerBatch                          int IL2CPP_TYPE_I4
    // 010 K_DebugPanelName                         ModelPrimitiveType string string string String
    // 190 ProbeVolumeDebug                         ModelClassType ProbeVolumeDebug ProbeVolumeDebug ProbeVolumeDebug Pointer
    // 198 SubdivisionDebugColors                   ModelEnumListType Color[] Color[] List<Color> Pointer
    // 1A0 M_DebugItems                             ModelClassListType Widget[] Widget[] List<Widget> Pointer
    // 1A8 M_DebugMesh                              ModelClassType Mesh Mesh Mesh Pointer
    // 1B0 M_DebugMaterial                          ModelClassType Material Material Material Pointer
    // 1B8 M_DebugOffsetMesh                        ModelClassType Mesh Mesh Mesh Pointer
    // 1C0 M_DebugOffsetMaterial                    ModelClassType Material Material Material Pointer
    // 1C8 M_DebugFrustumPlanes                     ModelEnumListType Plane[] Plane[] List<Plane> Pointer
    // 1D0 M_DebugScenarioNames                     ModelClassListType GUIContent[] GUIContent[] List<GUIContent> Pointer
    // 1D8 M_DebugScenarioValues                    ModelPrimitiveListType int[] int[] List<int> Pointer
    // 1E0 M_DebugActiveSceneGUID                   ModelPrimitiveType string string string String
    // 1E8 M_DebugActiveScenario                    ModelPrimitiveType string string string String
    // 1F0 M_DebugScenarioField                     ModelClassType EnumField EnumField EnumField Pointer
    // 1F8 BakingProcessSettings                    ModelEnumType ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings Int32
    // 228 realtimeSubdivisionInfo                  Dictionary`2<Bounds, Brick[]> IL2CPP_TYPE_GENERICINST
    // 230 M_MaxSubdivVisualizedIsMaxAvailable      ModelPrimitiveType bool bool bool Bool
    // 238 m_LoadedCells                            DynamicArray`1<CellInfo> IL2CPP_TYPE_GENERICINST
    // 240 m_ToBeLoadedCells                        DynamicArray`1<CellInfo> IL2CPP_TYPE_GENERICINST
    // 248 m_TempCellToLoadList                     DynamicArray`1<CellInfo> IL2CPP_TYPE_GENERICINST
    // 250 m_TempCellToUnloadList                   DynamicArray`1<CellInfo> IL2CPP_TYPE_GENERICINST
    // 258 m_LoadedBlendingCells                    DynamicArray`1<BlendingCellInfo> IL2CPP_TYPE_GENERICINST
    // 260 m_ToBeLoadedBlendingCells                DynamicArray`1<BlendingCellInfo> IL2CPP_TYPE_GENERICINST
    // 268 m_TempBlendingCellToLoadList             DynamicArray`1<BlendingCellInfo> IL2CPP_TYPE_GENERICINST
    // 270 m_TempBlendingCellToUnloadList           DynamicArray`1<BlendingCellInfo> IL2CPP_TYPE_GENERICINST
    // 278 M_FrozenCameraPosition                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 284 M_HasRemainingCellsToBlend               ModelPrimitiveType bool bool bool Bool
    public partial class ProbeReferenceVolume : DataModel
    {
        public bool                                     M_IsInitialized                         { get; set; }
        public bool                                     M_SupportStreaming                      { get; set; }
        public RefVolTransform                          M_Transform                             { get; set; }
        public int                                      M_MaxSubdivision                        { get; set; }
        public ProbeBrickPool?                          M_Pool                                  { get; set; }
        public ProbeBrickIndex?                         M_Index                                 { get; set; }
        public ProbeCellIndices?                        M_CellIndices                           { get; set; }
        public ProbeBrickBlendingPool?                  M_BlendingPool                          { get; set; }
        public List<BrickChunkAlloc>?                   M_TmpSrcChunks                          { get; set; }
        public List<float>?                             M_PositionOffsets                       { get; set; }
        public Bounds                                   M_CurrGlobalBounds                      { get; set; }
        public DataLocation                             M_TemporaryDataLocation                 { get; set; }
        public int                                      M_TemporaryDataLocationMemCost          { get; set; }
        public int                                      M_CurrentProbeVolumeChunkSizeInBricks   { get; set; }
        public ProbeVolumeSceneData?                    SceneData                               { get; set; }
        public Vector3Int                               MinLoadedCellPos                        { get; set; }
        public Vector3Int                               MaxLoadedCellPos                        { get; set; }
        public Action?                                  ChecksDuringBakeAction                  { get; set; }
        public bool                                     M_BricksLoaded                          { get; set; }
        public bool                                     M_NeedLoadAsset                         { get; set; }
        public bool                                     M_ProbeReferenceVolumeInit              { get; set; }
        public bool                                     M_EnabledBySRP                          { get; set; }
        public InitInfo                                 M_PendingInitInfo                       { get; set; }
        public bool                                     M_NeedsIndexRebuild                     { get; set; }
        public bool                                     M_HasChangedIndex                       { get; set; }
        public int                                      M_CBShaderID                            { get; set; }
        public int                                      M_NumberOfCellsLoadedPerFrame           { get; set; }
        public int                                      M_NumberOfCellsBlendedPerFrame          { get; set; }
        public float                                    M_TurnoverRate                          { get; set; }
        public ProbeVolumeTextureMemoryBudget           M_MemoryBudget                          { get; set; }
        public ProbeVolumeBlendingTextureMemoryBudget   M_BlendingMemoryBudget                  { get; set; }
        public ProbeVolumeSHBands                       M_SHBands                               { get; set; }
        public float                                    M_ProbeVolumesWeight                    { get; set; }
        public bool                                     ClearAssetsOnVolumeClear                { get; set; }
        public List<ProbeVolumePerSceneData>?           PerSceneDataList                        { get; set; }
        public string                                   K_DebugPanelName                        { get; set; }
        public ProbeVolumeDebug?                        ProbeVolumeDebug                        { get; set; }
        public List<Color>?                             SubdivisionDebugColors                  { get; set; }
        public List<Widget>?                            M_DebugItems                            { get; set; }
        public Mesh?                                    M_DebugMesh                             { get; set; }
        public Material?                                M_DebugMaterial                         { get; set; }
        public Mesh?                                    M_DebugOffsetMesh                       { get; set; }
        public Material?                                M_DebugOffsetMaterial                   { get; set; }
        public List<Plane>?                             M_DebugFrustumPlanes                    { get; set; }
        public List<GUIContent>?                        M_DebugScenarioNames                    { get; set; }
        public List<int>?                               M_DebugScenarioValues                   { get; set; }
        public string                                   M_DebugActiveSceneGUID                  { get; set; }
        public string                                   M_DebugActiveScenario                   { get; set; }
        public EnumField?                               M_DebugScenarioField                    { get; set; }
        public ProbeVolumeBakingProcessSettings         BakingProcessSettings                   { get; set; }
        public bool                                     M_MaxSubdivVisualizedIsMaxAvailable     { get; set; }
        public Vector3                                  M_FrozenCameraPosition                  { get; set; }
        public bool                                     M_HasRemainingCellsToBlend              { get; set; }

        public static ProbeReferenceVolume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeReferenceVolume() { Pointer= p0 };

            value.M_IsInitialized                           = GetBool(new IntPtr(p + 0x010)); // 0x10 M_IsInitialized             ( ModelPrimitiveType bool bool bool Bool )
            value.M_SupportStreaming                        = GetBool(new IntPtr(p + 0x011)); // 0x11 M_SupportStreaming          ( ModelPrimitiveType bool bool bool Bool )
            value.M_Transform                               = (RefVolTransform)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_Transform                 ( ModelEnumType RefVolTransform RefVolTransform RefVolTransform Int32 )
            value.M_MaxSubdivision                          = GetInt32(new IntPtr(p + 0x034)); // 0x34 M_MaxSubdivision            ( ModelPrimitiveType int int int Int32 )
            value.M_Pool                                    = GetObject<ProbeBrickPool>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProbeBrickPool.FromPointer); // 0x38 M_Pool                      ( ModelClassType ProbeBrickPool ProbeBrickPool ProbeBrickPool Pointer )
            value.M_Index                                   = GetObject<ProbeBrickIndex>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProbeBrickIndex.FromPointer); // 0x40 M_Index                     ( ModelClassType ProbeBrickIndex ProbeBrickIndex ProbeBrickIndex Pointer )
            value.M_CellIndices                             = GetObject<ProbeCellIndices>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProbeCellIndices.FromPointer); // 0x48 M_CellIndices               ( ModelClassType ProbeCellIndices ProbeCellIndices ProbeCellIndices Pointer )
            value.M_BlendingPool                            = GetObject<ProbeBrickBlendingPool>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProbeBrickBlendingPool.FromPointer); // 0x50 M_BlendingPool              ( ModelClassType ProbeBrickBlendingPool ProbeBrickBlendingPool ProbeBrickBlendingPool Pointer )
            value.M_TmpSrcChunks                            = GetEnumList<BrickChunkAlloc>(new IntPtr(p + 0x058)); // 0x58 M_TmpSrcChunks              ( ModelEnumListType List`1<BrickChunkAlloc> List`1<BrickChunkAlloc> List<BrickChunkAlloc> Pointer )
            value.M_PositionOffsets                         = GetSingleList(new IntPtr(p + 0x060)); // 0x60 M_PositionOffsets           ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_CurrGlobalBounds                        = (Bounds)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_CurrGlobalBounds          ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_TemporaryDataLocation                   = (DataLocation)GetInt32(new IntPtr(p + 0x098)); // 0x98 M_TemporaryDataLocation     ( ModelEnumType DataLocation DataLocation DataLocation Int32 )
            value.M_TemporaryDataLocationMemCost            = GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 M_TemporaryDataLocationMemCost ( ModelPrimitiveType int int int Int32 )
            value.M_CurrentProbeVolumeChunkSizeInBricks     = GetInt32(new IntPtr(p + 0x0EC)); // 0xEC M_CurrentProbeVolumeChunkSizeInBricks ( ModelPrimitiveType int int int Int32 )
            value.SceneData                                 = GetObject<ProbeVolumeSceneData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ProbeVolumeSceneData.FromPointer); // 0xF0 SceneData                   ( ModelClassType ProbeVolumeSceneData ProbeVolumeSceneData ProbeVolumeSceneData Pointer )
            value.MinLoadedCellPos                          = (Vector3Int)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 MinLoadedCellPos            ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.MaxLoadedCellPos                          = (Vector3Int)GetInt32(new IntPtr(p + 0x104)); // 0x104 MaxLoadedCellPos            ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.ChecksDuringBakeAction                    = GetObject<Action>(new IntPtr(p + 0x118), ReversePrism.DataModels.Action.FromPointer); // 0x118 ChecksDuringBakeAction      ( ModelClassType Action Action Action Pointer )
            value.M_BricksLoaded                            = GetBool(new IntPtr(p + 0x120)); // 0x120 M_BricksLoaded              ( ModelPrimitiveType bool bool bool Bool )
            value.M_NeedLoadAsset                           = GetBool(new IntPtr(p + 0x140)); // 0x140 M_NeedLoadAsset             ( ModelPrimitiveType bool bool bool Bool )
            value.M_ProbeReferenceVolumeInit                = GetBool(new IntPtr(p + 0x141)); // 0x141 M_ProbeReferenceVolumeInit  ( ModelPrimitiveType bool bool bool Bool )
            value.M_EnabledBySRP                            = GetBool(new IntPtr(p + 0x142)); // 0x142 M_EnabledBySRP              ( ModelPrimitiveType bool bool bool Bool )
            value.M_PendingInitInfo                         = (InitInfo)GetInt32(new IntPtr(p + 0x144)); // 0x144 M_PendingInitInfo           ( ModelEnumType InitInfo InitInfo InitInfo Int32 )
            value.M_NeedsIndexRebuild                       = GetBool(new IntPtr(p + 0x15C)); // 0x15C M_NeedsIndexRebuild         ( ModelPrimitiveType bool bool bool Bool )
            value.M_HasChangedIndex                         = GetBool(new IntPtr(p + 0x15D)); // 0x15D M_HasChangedIndex           ( ModelPrimitiveType bool bool bool Bool )
            value.M_CBShaderID                              = GetInt32(new IntPtr(p + 0x160)); // 0x160 M_CBShaderID                ( ModelPrimitiveType int int int Int32 )
            value.M_NumberOfCellsLoadedPerFrame             = GetInt32(new IntPtr(p + 0x164)); // 0x164 M_NumberOfCellsLoadedPerFrame ( ModelPrimitiveType int int int Int32 )
            value.M_NumberOfCellsBlendedPerFrame            = GetInt32(new IntPtr(p + 0x168)); // 0x168 M_NumberOfCellsBlendedPerFrame ( ModelPrimitiveType int int int Int32 )
            value.M_TurnoverRate                            = GetSingle(new IntPtr(p + 0x16C)); // 0x16C M_TurnoverRate              ( ModelPrimitiveType float float float Single )
            value.M_MemoryBudget                            = (ProbeVolumeTextureMemoryBudget)GetInt32(new IntPtr(p + 0x170)); // 0x170 M_MemoryBudget              ( ModelEnumType ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget Int32 )
            value.M_BlendingMemoryBudget                    = (ProbeVolumeBlendingTextureMemoryBudget)GetInt32(new IntPtr(p + 0x174)); // 0x174 M_BlendingMemoryBudget      ( ModelEnumType ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget Int32 )
            value.M_SHBands                                 = (ProbeVolumeSHBands)GetInt32(new IntPtr(p + 0x178)); // 0x178 M_SHBands                   ( ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32 )
            value.M_ProbeVolumesWeight                      = GetSingle(new IntPtr(p + 0x17C)); // 0x17C M_ProbeVolumesWeight        ( ModelPrimitiveType float float float Single )
            value.ClearAssetsOnVolumeClear                  = GetBool(new IntPtr(p + 0x180)); // 0x180 ClearAssetsOnVolumeClear    ( ModelPrimitiveType bool bool bool Bool )
            value.PerSceneDataList                          = GetObjectList<ProbeVolumePerSceneData>(new IntPtr(p + 0x188), ReversePrism.DataModels.ProbeVolumePerSceneData.FromPointer); // 0x188 PerSceneDataList            ( ModelClassListType List`1<ProbeVolumePerSceneData> List`1<ProbeVolumePerSceneData> List<ProbeVolumePerSceneData> Pointer )
            value.K_DebugPanelName                          = GetString(new IntPtr(p + 0x010)); // 0x10 K_DebugPanelName            ( ModelPrimitiveType string string string String )
            value.ProbeVolumeDebug                          = GetObject<ProbeVolumeDebug>(new IntPtr(p + 0x190), ReversePrism.DataModels.ProbeVolumeDebug.FromPointer); // 0x190 ProbeVolumeDebug            ( ModelClassType ProbeVolumeDebug ProbeVolumeDebug ProbeVolumeDebug Pointer )
            value.SubdivisionDebugColors                    = GetEnumList<Color>(new IntPtr(p + 0x198)); // 0x198 SubdivisionDebugColors      ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.M_DebugItems                              = GetObjectList<Widget>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.Widget.FromPointer); // 0x1A0 M_DebugItems                ( ModelClassListType Widget[] Widget[] List<Widget> Pointer )
            value.M_DebugMesh                               = GetObject<Mesh>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.Mesh.FromPointer); // 0x1A8 M_DebugMesh                 ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_DebugMaterial                           = GetObject<Material>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.Material.FromPointer); // 0x1B0 M_DebugMaterial             ( ModelClassType Material Material Material Pointer )
            value.M_DebugOffsetMesh                         = GetObject<Mesh>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.Mesh.FromPointer); // 0x1B8 M_DebugOffsetMesh           ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_DebugOffsetMaterial                     = GetObject<Material>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.Material.FromPointer); // 0x1C0 M_DebugOffsetMaterial       ( ModelClassType Material Material Material Pointer )
            value.M_DebugFrustumPlanes                      = GetEnumList<Plane>(new IntPtr(p + 0x1C8)); // 0x1C8 M_DebugFrustumPlanes        ( ModelEnumListType Plane[] Plane[] List<Plane> Pointer )
            value.M_DebugScenarioNames                      = GetObjectList<GUIContent>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.GUIContent.FromPointer); // 0x1D0 M_DebugScenarioNames        ( ModelClassListType GUIContent[] GUIContent[] List<GUIContent> Pointer )
            value.M_DebugScenarioValues                     = GetInt32List(new IntPtr(p + 0x1D8)); // 0x1D8 M_DebugScenarioValues       ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_DebugActiveSceneGUID                    = GetString(new IntPtr(p + 0x1E0)); // 0x1E0 M_DebugActiveSceneGUID      ( ModelPrimitiveType string string string String )
            value.M_DebugActiveScenario                     = GetString(new IntPtr(p + 0x1E8)); // 0x1E8 M_DebugActiveScenario       ( ModelPrimitiveType string string string String )
            value.M_DebugScenarioField                      = GetObject<EnumField>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.EnumField.FromPointer); // 0x1F0 M_DebugScenarioField        ( ModelClassType EnumField EnumField EnumField Pointer )
            value.BakingProcessSettings                     = (ProbeVolumeBakingProcessSettings)GetInt32(new IntPtr(p + 0x1F8)); // 0x1F8 BakingProcessSettings       ( ModelEnumType ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings Int32 )
            value.M_MaxSubdivVisualizedIsMaxAvailable       = GetBool(new IntPtr(p + 0x230)); // 0x230 M_MaxSubdivVisualizedIsMaxAvailable ( ModelPrimitiveType bool bool bool Bool )
            value.M_FrozenCameraPosition                    = (Vector3)GetInt32(new IntPtr(p + 0x278)); // 0x278 M_FrozenCameraPosition      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_HasRemainingCellsToBlend                = GetBool(new IntPtr(p + 0x284)); // 0x284 M_HasRemainingCellsToBlend  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
