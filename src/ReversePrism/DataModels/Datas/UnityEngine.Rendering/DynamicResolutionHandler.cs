using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Enabled                                ModelPrimitiveType bool bool bool Bool
    // 011 M_UseMipBias                             ModelPrimitiveType bool bool bool Bool
    // 014 M_MinScreenFraction                      ModelPrimitiveType float float float Single
    // 018 M_MaxScreenFraction                      ModelPrimitiveType float float float Single
    // 01C M_CurrentFraction                        ModelPrimitiveType float float float Single
    // 020 M_ForcingRes                             ModelPrimitiveType bool bool bool Bool
    // 021 M_CurrentCameraRequest                   ModelPrimitiveType bool bool bool Bool
    // 024 M_PrevFraction                           ModelPrimitiveType float float float Single
    // 028 M_ForceSoftwareFallback                  ModelPrimitiveType bool bool bool Bool
    // 029 M_RunUpscalerFilterOnFullResolution      ModelPrimitiveType bool bool bool Bool
    // 02C M_PrevHWScaleWidth                       ModelPrimitiveType float float float Single
    // 030 M_PrevHWScaleHeight                      ModelPrimitiveType float float float Single
    // 034 M_LastScaledSize                         ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 000 s_ActiveScalerSlot                       DynamicResScalerSlot IL2CPP_TYPE_VALUETYPE
    // 008 s_ScalerContainers                       ScalerContainer[] IL2CPP_TYPE_SZARRAY
    // 03C CachedOriginalSize                       ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 044 Filter                                   ModelEnumType DynamicResUpscaleFilter DynamicResUpscaleFilter DynamicResUpscaleFilter Int32
    // 010 s_CameraUpscaleFilters                   Dictionary`2<int, DynamicResUpscaleFilter> IL2CPP_TYPE_GENERICINST
    // 048 FinalViewport                            ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 050 Type                                     ModelEnumType DynamicResolutionType DynamicResolutionType DynamicResolutionType Int32
    // 054 M_CachedSettings                         ModelEnumType GlobalDynamicResolutionSettings GlobalDynamicResolutionSettings GlobalDynamicResolutionSettings Int32
    // 000 CameraDictionaryMaxcCapacity             int IL2CPP_TYPE_I4
    // 088 M_OwnerCameraWeakRef                     ModelClassType WeakReference WeakReference WeakReference Pointer
    // 018 s_CameraInstances                        Dictionary`2<int, DynamicResolutionHandler> IL2CPP_TYPE_GENERICINST
    // 020 S_DefaultInstance                        ModelClassType DynamicResolutionHandler DynamicResolutionHandler DynamicResolutionHandler Pointer
    // 028 S_ActiveCameraId                         ModelPrimitiveType int int int Int32
    // 030 S_ActiveInstance                         ModelClassType DynamicResolutionHandler DynamicResolutionHandler DynamicResolutionHandler Pointer
    // 038 S_ActiveInstanceDirty                    ModelPrimitiveType bool bool bool Bool
    // 03C S_GlobalHwFraction                       ModelPrimitiveType float float float Single
    // 040 S_GlobalHwUpresActive                    ModelPrimitiveType bool bool bool Bool
    // 090 M_UpsamplerSchedule                      ModelEnumType UpsamplerScheduleType UpsamplerScheduleType UpsamplerScheduleType Int32
    public partial class DynamicResolutionHandler : DataModel
    {
        public bool                                     M_Enabled                               { get; set; }
        public bool                                     M_UseMipBias                            { get; set; }
        public float                                    M_MinScreenFraction                     { get; set; }
        public float                                    M_MaxScreenFraction                     { get; set; }
        public float                                    M_CurrentFraction                       { get; set; }
        public bool                                     M_ForcingRes                            { get; set; }
        public bool                                     M_CurrentCameraRequest                  { get; set; }
        public float                                    M_PrevFraction                          { get; set; }
        public bool                                     M_ForceSoftwareFallback                 { get; set; }
        public bool                                     M_RunUpscalerFilterOnFullResolution     { get; set; }
        public float                                    M_PrevHWScaleWidth                      { get; set; }
        public float                                    M_PrevHWScaleHeight                     { get; set; }
        public Vector2Int                               M_LastScaledSize                        { get; set; }
        public Vector2Int                               CachedOriginalSize                      { get; set; }
        public DynamicResUpscaleFilter                  Filter                                  { get; set; }
        public Vector2Int                               FinalViewport                           { get; set; }
        public DynamicResolutionType                    Type                                    { get; set; }
        public GlobalDynamicResolutionSettings          M_CachedSettings                        { get; set; }
        public WeakReference?                           M_OwnerCameraWeakRef                    { get; set; }
        public DynamicResolutionHandler?                S_DefaultInstance                       { get; set; }
        public int                                      S_ActiveCameraId                        { get; set; }
        public DynamicResolutionHandler?                S_ActiveInstance                        { get; set; }
        public bool                                     S_ActiveInstanceDirty                   { get; set; }
        public float                                    S_GlobalHwFraction                      { get; set; }
        public bool                                     S_GlobalHwUpresActive                   { get; set; }
        public UpsamplerScheduleType                    M_UpsamplerSchedule                     { get; set; }

        public static DynamicResolutionHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DynamicResolutionHandler() { Pointer= p0 };

            value.M_Enabled                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 M_Enabled                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseMipBias                              = GetBool(new IntPtr(p + 0x011)); // 0x11 M_UseMipBias                ( ModelPrimitiveType bool bool bool Bool )
            value.M_MinScreenFraction                       = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_MinScreenFraction         ( ModelPrimitiveType float float float Single )
            value.M_MaxScreenFraction                       = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_MaxScreenFraction         ( ModelPrimitiveType float float float Single )
            value.M_CurrentFraction                         = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_CurrentFraction           ( ModelPrimitiveType float float float Single )
            value.M_ForcingRes                              = GetBool(new IntPtr(p + 0x020)); // 0x20 M_ForcingRes                ( ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentCameraRequest                    = GetBool(new IntPtr(p + 0x021)); // 0x21 M_CurrentCameraRequest      ( ModelPrimitiveType bool bool bool Bool )
            value.M_PrevFraction                            = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_PrevFraction              ( ModelPrimitiveType float float float Single )
            value.M_ForceSoftwareFallback                   = GetBool(new IntPtr(p + 0x028)); // 0x28 M_ForceSoftwareFallback     ( ModelPrimitiveType bool bool bool Bool )
            value.M_RunUpscalerFilterOnFullResolution       = GetBool(new IntPtr(p + 0x029)); // 0x29 M_RunUpscalerFilterOnFullResolution ( ModelPrimitiveType bool bool bool Bool )
            value.M_PrevHWScaleWidth                        = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_PrevHWScaleWidth          ( ModelPrimitiveType float float float Single )
            value.M_PrevHWScaleHeight                       = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_PrevHWScaleHeight         ( ModelPrimitiveType float float float Single )
            value.M_LastScaledSize                          = (Vector2Int)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_LastScaledSize            ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.CachedOriginalSize                        = (Vector2Int)GetInt32(new IntPtr(p + 0x03C)); // 0x3C CachedOriginalSize          ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.Filter                                    = (DynamicResUpscaleFilter)GetInt32(new IntPtr(p + 0x044)); // 0x44 Filter                      ( ModelEnumType DynamicResUpscaleFilter DynamicResUpscaleFilter DynamicResUpscaleFilter Int32 )
            value.FinalViewport                             = (Vector2Int)GetInt32(new IntPtr(p + 0x048)); // 0x48 FinalViewport               ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.Type                                      = (DynamicResolutionType)GetInt32(new IntPtr(p + 0x050)); // 0x50 Type                        ( ModelEnumType DynamicResolutionType DynamicResolutionType DynamicResolutionType Int32 )
            value.M_CachedSettings                          = (GlobalDynamicResolutionSettings)GetInt32(new IntPtr(p + 0x054)); // 0x54 M_CachedSettings            ( ModelEnumType GlobalDynamicResolutionSettings GlobalDynamicResolutionSettings GlobalDynamicResolutionSettings Int32 )
            value.M_OwnerCameraWeakRef                      = GetObject<WeakReference>(new IntPtr(p + 0x088), ReversePrism.DataModels.WeakReference.FromPointer); // 0x88 M_OwnerCameraWeakRef        ( ModelClassType WeakReference WeakReference WeakReference Pointer )
            value.S_DefaultInstance                         = GetObject<DynamicResolutionHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.DynamicResolutionHandler.FromPointer); // 0x20 S_DefaultInstance           ( ModelClassType DynamicResolutionHandler DynamicResolutionHandler DynamicResolutionHandler Pointer )
            value.S_ActiveCameraId                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 S_ActiveCameraId            ( ModelPrimitiveType int int int Int32 )
            value.S_ActiveInstance                          = GetObject<DynamicResolutionHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.DynamicResolutionHandler.FromPointer); // 0x30 S_ActiveInstance            ( ModelClassType DynamicResolutionHandler DynamicResolutionHandler DynamicResolutionHandler Pointer )
            value.S_ActiveInstanceDirty                     = GetBool(new IntPtr(p + 0x038)); // 0x38 S_ActiveInstanceDirty       ( ModelPrimitiveType bool bool bool Bool )
            value.S_GlobalHwFraction                        = GetSingle(new IntPtr(p + 0x03C)); // 0x3C S_GlobalHwFraction          ( ModelPrimitiveType float float float Single )
            value.S_GlobalHwUpresActive                     = GetBool(new IntPtr(p + 0x040)); // 0x40 S_GlobalHwUpresActive       ( ModelPrimitiveType bool bool bool Bool )
            value.M_UpsamplerSchedule                       = (UpsamplerScheduleType)GetInt32(new IntPtr(p + 0x090)); // 0x90 M_UpsamplerSchedule         ( ModelEnumType UpsamplerScheduleType UpsamplerScheduleType UpsamplerScheduleType Int32 )

            return value;
        }
    }
}
