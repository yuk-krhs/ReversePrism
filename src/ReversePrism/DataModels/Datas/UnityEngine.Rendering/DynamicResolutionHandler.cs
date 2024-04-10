using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Enabled                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 M_UseMipBias                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 M_MinScreenFraction                      0001866656B0 ModelPrimitiveType float float float Single
    // 018 M_MaxScreenFraction                      0001866656B0 ModelPrimitiveType float float float Single
    // 01C M_CurrentFraction                        0001866656B0 ModelPrimitiveType float float float Single
    // 020 M_ForcingRes                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 M_CurrentCameraRequest                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 M_PrevFraction                           0001866656B0 ModelPrimitiveType float float float Single
    // 028 M_ForceSoftwareFallback                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 M_RunUpscalerFilterOnFullResolution      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C M_PrevHWScaleWidth                       0001866656B0 ModelPrimitiveType float float float Single
    // 030 M_PrevHWScaleHeight                      0001866656B0 ModelPrimitiveType float float float Single
    // 034 M_LastScaledSize                         0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 000 s_ActiveScalerSlot                       DynamicResScalerSlot IL2CPP_TYPE_VALUETYPE
    // 008 s_ScalerContainers                       ScalerContainer[] IL2CPP_TYPE_SZARRAY
    // 03C CachedOriginalSize                       0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 044 Filter                                   000186712C00 ModelEnumType DynamicResUpscaleFilter DynamicResUpscaleFilter DynamicResUpscaleFilter Int32
    // 010 s_CameraUpscaleFilters                   Dictionary`2<int, DynamicResUpscaleFilter> IL2CPP_TYPE_GENERICINST
    // 048 FinalViewport                            0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 050 Type                                     000186713AF0 ModelEnumType DynamicResolutionType DynamicResolutionType DynamicResolutionType Int32
    // 054 M_CachedSettings                         00018667B650 ModelEnumType GlobalDynamicResolutionSettings GlobalDynamicResolutionSettings GlobalDynamicResolutionSettings Int32
    // 000 CameraDictionaryMaxcCapacity             int IL2CPP_TYPE_I4
    // 088 M_OwnerCameraWeakRef                     0001866B4810 ModelClassType WeakReference WeakReference WeakReference Pointer
    // 018 s_CameraInstances                        Dictionary`2<int, DynamicResolutionHandler> IL2CPP_TYPE_GENERICINST
    // 020 S_DefaultInstance                        0001867135F0 ModelClassType DynamicResolutionHandler DynamicResolutionHandler DynamicResolutionHandler Pointer
    // 028 S_ActiveCameraId                         0001865F38E0 ModelPrimitiveType int int int Int32
    // 030 S_ActiveInstance                         0001867135F0 ModelClassType DynamicResolutionHandler DynamicResolutionHandler DynamicResolutionHandler Pointer
    // 038 S_ActiveInstanceDirty                    000186595C30 ModelPrimitiveType bool bool bool Bool
    // 03C S_GlobalHwFraction                       000186666300 ModelPrimitiveType float float float Single
    // 040 S_GlobalHwUpresActive                    000186595C30 ModelPrimitiveType bool bool bool Bool
    // 090 M_UpsamplerSchedule                      0001865CBF00 ModelEnumType UpsamplerScheduleType UpsamplerScheduleType UpsamplerScheduleType Int32
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

            value.M_Enabled                                 = GetBool(new IntPtr(p + 0x010)); // 0245A3FC0CB0 0x10 M_Enabled                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_UseMipBias                              = GetBool(new IntPtr(p + 0x011)); // 0245A3FC0CD0 0x11 M_UseMipBias                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MinScreenFraction                       = GetSingle(new IntPtr(p + 0x014)); // 0245A3FC0CF0 0x14 M_MinScreenFraction         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MaxScreenFraction                       = GetSingle(new IntPtr(p + 0x018)); // 0245A3FC0D10 0x18 M_MaxScreenFraction         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_CurrentFraction                         = GetSingle(new IntPtr(p + 0x01C)); // 0245A3FC0D30 0x1C M_CurrentFraction           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ForcingRes                              = GetBool(new IntPtr(p + 0x020)); // 0245A3FC0D50 0x20 M_ForcingRes                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentCameraRequest                    = GetBool(new IntPtr(p + 0x021)); // 0245A3FC0D70 0x21 M_CurrentCameraRequest      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PrevFraction                            = GetSingle(new IntPtr(p + 0x024)); // 0245A3FC0D90 0x24 M_PrevFraction              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ForceSoftwareFallback                   = GetBool(new IntPtr(p + 0x028)); // 0245A3FC0DB0 0x28 M_ForceSoftwareFallback     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RunUpscalerFilterOnFullResolution       = GetBool(new IntPtr(p + 0x029)); // 0245A3FC0DD0 0x29 M_RunUpscalerFilterOnFullResolution ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PrevHWScaleWidth                        = GetSingle(new IntPtr(p + 0x02C)); // 0245A3FC0DF0 0x2C M_PrevHWScaleWidth          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_PrevHWScaleHeight                       = GetSingle(new IntPtr(p + 0x030)); // 0245A3FC0E10 0x30 M_PrevHWScaleHeight         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_LastScaledSize                          = (Vector2Int)GetInt32(new IntPtr(p + 0x034)); // 0245A3FC0E30 0x34 M_LastScaledSize            ( 0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.CachedOriginalSize                        = (Vector2Int)GetInt32(new IntPtr(p + 0x03C)); // 0245A3FC0E90 0x3C CachedOriginalSize          ( 0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.Filter                                    = (DynamicResUpscaleFilter)GetInt32(new IntPtr(p + 0x044)); // 0245A3FC0EB0 0x44 Filter                      ( 000186712C00 ModelEnumType DynamicResUpscaleFilter DynamicResUpscaleFilter DynamicResUpscaleFilter Int32 )
            value.FinalViewport                             = (Vector2Int)GetInt32(new IntPtr(p + 0x048)); // 0245A3FC0EF0 0x48 FinalViewport               ( 0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.Type                                      = (DynamicResolutionType)GetInt32(new IntPtr(p + 0x050)); // 0245A3FC0F10 0x50 Type                        ( 000186713AF0 ModelEnumType DynamicResolutionType DynamicResolutionType DynamicResolutionType Int32 )
            value.M_CachedSettings                          = (GlobalDynamicResolutionSettings)GetInt32(new IntPtr(p + 0x054)); // 0245A3FC0F30 0x54 M_CachedSettings            ( 00018667B650 ModelEnumType GlobalDynamicResolutionSettings GlobalDynamicResolutionSettings GlobalDynamicResolutionSettings Int32 )
            value.M_OwnerCameraWeakRef                      = GetObject<WeakReference>(new IntPtr(p + 0x088), ReversePrism.DataModels.WeakReference.FromPointer); // 0245A3FC0F70 0x88 M_OwnerCameraWeakRef        ( 0001866B4810 ModelClassType WeakReference WeakReference WeakReference Pointer )
            value.S_DefaultInstance                         = GetObject<DynamicResolutionHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.DynamicResolutionHandler.FromPointer); // 0245A3FC0FB0 0x20 S_DefaultInstance           ( 0001867135F0 ModelClassType DynamicResolutionHandler DynamicResolutionHandler DynamicResolutionHandler Pointer )
            value.S_ActiveCameraId                          = GetInt32(new IntPtr(p + 0x028)); // 0245A3FC0FD0 0x28 S_ActiveCameraId            ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_ActiveInstance                          = GetObject<DynamicResolutionHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.DynamicResolutionHandler.FromPointer); // 0245A3FC0FF0 0x30 S_ActiveInstance            ( 0001867135F0 ModelClassType DynamicResolutionHandler DynamicResolutionHandler DynamicResolutionHandler Pointer )
            value.S_ActiveInstanceDirty                     = GetBool(new IntPtr(p + 0x038)); // 0245A3FC1010 0x38 S_ActiveInstanceDirty       ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.S_GlobalHwFraction                        = GetSingle(new IntPtr(p + 0x03C)); // 0245A3FC1030 0x3C S_GlobalHwFraction          ( 000186666300 ModelPrimitiveType float float float Single )
            value.S_GlobalHwUpresActive                     = GetBool(new IntPtr(p + 0x040)); // 0245A3FC1050 0x40 S_GlobalHwUpresActive       ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.M_UpsamplerSchedule                       = (UpsamplerScheduleType)GetInt32(new IntPtr(p + 0x090)); // 0245A3FC1070 0x90 M_UpsamplerSchedule         ( 0001865CBF00 ModelEnumType UpsamplerScheduleType UpsamplerScheduleType UpsamplerScheduleType Int32 )

            return value;
        }
    }
}
