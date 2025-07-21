using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_GizmoPath                              string IL2CPP_TYPE_STRING
    // 000 k_BaseCameraGizmoPath                    string IL2CPP_TYPE_STRING
    // 000 k_OverlayCameraGizmoPath                 string IL2CPP_TYPE_STRING
    // 000 k_PostProcessingGizmoPath                string IL2CPP_TYPE_STRING
    // 020 M_RenderShadows                          ModelPrimitiveType bool bool bool Bool
    // 024 M_RequiresDepthTextureOption             ModelEnumType CameraOverrideOption CameraOverrideOption CameraOverrideOption Int32
    // 028 M_RequiresOpaqueTextureOption            ModelEnumType CameraOverrideOption CameraOverrideOption CameraOverrideOption Int32
    // 02C M_CameraType                             ModelEnumType CameraRenderType CameraRenderType CameraRenderType Int32
    // 030 M_Cameras                                ModelClassListType List`1<Camera> List`1<Camera> List<Camera> Pointer
    // 038 M_RendererIndex                          ModelPrimitiveType int int int Int32
    // 03C M_VolumeLayerMask                        ModelEnumType LayerMask LayerMask LayerMask Int32
    // 040 M_VolumeTrigger                          ModelClassType Transform Transform Transform Pointer
    // 048 M_VolumeFrameworkUpdateModeOption        ModelEnumType VolumeFrameworkUpdateMode VolumeFrameworkUpdateMode VolumeFrameworkUpdateMode Int32
    // 04C M_RenderPostProcessing                   ModelPrimitiveType bool bool bool Bool
    // 050 M_Antialiasing                           ModelEnumType AntialiasingMode AntialiasingMode AntialiasingMode Int32
    // 054 M_AntialiasingQuality                    ModelEnumType AntialiasingQuality AntialiasingQuality AntialiasingQuality Int32
    // 058 M_StopNaN                                ModelPrimitiveType bool bool bool Bool
    // 059 M_Dithering                              ModelPrimitiveType bool bool bool Bool
    // 05A M_ClearDepth                             ModelPrimitiveType bool bool bool Bool
    // 05B M_AllowXRRendering                       ModelPrimitiveType bool bool bool Bool
    // 05C M_AllowHDROutput                         ModelPrimitiveType bool bool bool Bool
    // 05D M_UseScreenCoordOverride                 ModelPrimitiveType bool bool bool Bool
    // 060 M_ScreenSizeOverride                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 070 M_ScreenCoordScaleBias                   ModelEnumType Vector4 Vector4 Vector4 Int32
    // 080 M_Camera                                 ModelClassType Camera Camera Camera Pointer
    // 088 M_RequiresDepthTexture                   ModelPrimitiveType bool bool bool Bool
    // 089 M_RequiresColorTexture                   ModelPrimitiveType bool bool bool Bool
    // 08C M_Version                                ModelPrimitiveType float float float Single
    // 090 M_MotionVectorsPersistentData            ModelClassType MotionVectorsPersistentData MotionVectorsPersistentData MotionVectorsPersistentData Pointer
    // 098 M_TaaPersistentData                      ModelClassType TaaPersistentData TaaPersistentData TaaPersistentData Pointer
    // 0A0 M_TaaSettings                            ModelEnumType Settings Settings Settings Int32
    // 000 s_DefaultAdditionalCameraData            UniversalAdditionalCameraData IL2CPP_TYPE_CLASS
    // 008 s_CachedVolumeStacks                     List`1<VolumeStack> IL2CPP_TYPE_GENERICINST
    // 0C0 M_VolumeStack                            ModelClassType VolumeStack VolumeStack VolumeStack Pointer
    public partial class UniversalAdditionalCameraData : DataModel
    {
        public bool                                     M_RenderShadows                         { get; set; }
        public CameraOverrideOption                     M_RequiresDepthTextureOption            { get; set; }
        public CameraOverrideOption                     M_RequiresOpaqueTextureOption           { get; set; }
        public CameraRenderType                         M_CameraType                            { get; set; }
        public List<Camera>?                            M_Cameras                               { get; set; }
        public int                                      M_RendererIndex                         { get; set; }
        public LayerMask                                M_VolumeLayerMask                       { get; set; }
        public Transform?                               M_VolumeTrigger                         { get; set; }
        public VolumeFrameworkUpdateMode                M_VolumeFrameworkUpdateModeOption       { get; set; }
        public bool                                     M_RenderPostProcessing                  { get; set; }
        public AntialiasingMode                         M_Antialiasing                          { get; set; }
        public AntialiasingQuality                      M_AntialiasingQuality                   { get; set; }
        public bool                                     M_StopNaN                               { get; set; }
        public bool                                     M_Dithering                             { get; set; }
        public bool                                     M_ClearDepth                            { get; set; }
        public bool                                     M_AllowXRRendering                      { get; set; }
        public bool                                     M_AllowHDROutput                        { get; set; }
        public bool                                     M_UseScreenCoordOverride                { get; set; }
        public Vector4                                  M_ScreenSizeOverride                    { get; set; }
        public Vector4                                  M_ScreenCoordScaleBias                  { get; set; }
        public Camera?                                  M_Camera                                { get; set; }
        public bool                                     M_RequiresDepthTexture                  { get; set; }
        public bool                                     M_RequiresColorTexture                  { get; set; }
        public float                                    M_Version                               { get; set; }
        public MotionVectorsPersistentData?             M_MotionVectorsPersistentData           { get; set; }
        public TaaPersistentData?                       M_TaaPersistentData                     { get; set; }
        public Settings                                 M_TaaSettings                           { get; set; }
        public VolumeStack?                             M_VolumeStack                           { get; set; }

        public static UniversalAdditionalCameraData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniversalAdditionalCameraData() { Pointer= p0 };

            value.M_RenderShadows                           = GetBool(new IntPtr(p + 0x020)); // 0x20 M_RenderShadows             ( ModelPrimitiveType bool bool bool Bool )
            value.M_RequiresDepthTextureOption              = (CameraOverrideOption)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_RequiresDepthTextureOption ( ModelEnumType CameraOverrideOption CameraOverrideOption CameraOverrideOption Int32 )
            value.M_RequiresOpaqueTextureOption             = (CameraOverrideOption)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_RequiresOpaqueTextureOption ( ModelEnumType CameraOverrideOption CameraOverrideOption CameraOverrideOption Int32 )
            value.M_CameraType                              = (CameraRenderType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_CameraType                ( ModelEnumType CameraRenderType CameraRenderType CameraRenderType Int32 )
            value.M_Cameras                                 = GetObjectList<Camera>(new IntPtr(p + 0x030), ReversePrism.DataModels.Camera.FromPointer); // 0x30 M_Cameras                   ( ModelClassListType List`1<Camera> List`1<Camera> List<Camera> Pointer )
            value.M_RendererIndex                           = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_RendererIndex             ( ModelPrimitiveType int int int Int32 )
            value.M_VolumeLayerMask                         = (LayerMask)GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_VolumeLayerMask           ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_VolumeTrigger                           = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0x40 M_VolumeTrigger             ( ModelClassType Transform Transform Transform Pointer )
            value.M_VolumeFrameworkUpdateModeOption         = (VolumeFrameworkUpdateMode)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_VolumeFrameworkUpdateModeOption ( ModelEnumType VolumeFrameworkUpdateMode VolumeFrameworkUpdateMode VolumeFrameworkUpdateMode Int32 )
            value.M_RenderPostProcessing                    = GetBool(new IntPtr(p + 0x04C)); // 0x4C M_RenderPostProcessing      ( ModelPrimitiveType bool bool bool Bool )
            value.M_Antialiasing                            = (AntialiasingMode)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_Antialiasing              ( ModelEnumType AntialiasingMode AntialiasingMode AntialiasingMode Int32 )
            value.M_AntialiasingQuality                     = (AntialiasingQuality)GetInt32(new IntPtr(p + 0x054)); // 0x54 M_AntialiasingQuality       ( ModelEnumType AntialiasingQuality AntialiasingQuality AntialiasingQuality Int32 )
            value.M_StopNaN                                 = GetBool(new IntPtr(p + 0x058)); // 0x58 M_StopNaN                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_Dithering                               = GetBool(new IntPtr(p + 0x059)); // 0x59 M_Dithering                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_ClearDepth                              = GetBool(new IntPtr(p + 0x05A)); // 0x5A M_ClearDepth                ( ModelPrimitiveType bool bool bool Bool )
            value.M_AllowXRRendering                        = GetBool(new IntPtr(p + 0x05B)); // 0x5B M_AllowXRRendering          ( ModelPrimitiveType bool bool bool Bool )
            value.M_AllowHDROutput                          = GetBool(new IntPtr(p + 0x05C)); // 0x5C M_AllowHDROutput            ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseScreenCoordOverride                  = GetBool(new IntPtr(p + 0x05D)); // 0x5D M_UseScreenCoordOverride    ( ModelPrimitiveType bool bool bool Bool )
            value.M_ScreenSizeOverride                      = (Vector4)GetInt32(new IntPtr(p + 0x060)); // 0x60 M_ScreenSizeOverride        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_ScreenCoordScaleBias                    = (Vector4)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_ScreenCoordScaleBias      ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_Camera                                  = GetObject<Camera>(new IntPtr(p + 0x080), ReversePrism.DataModels.Camera.FromPointer); // 0x80 M_Camera                    ( ModelClassType Camera Camera Camera Pointer )
            value.M_RequiresDepthTexture                    = GetBool(new IntPtr(p + 0x088)); // 0x88 M_RequiresDepthTexture      ( ModelPrimitiveType bool bool bool Bool )
            value.M_RequiresColorTexture                    = GetBool(new IntPtr(p + 0x089)); // 0x89 M_RequiresColorTexture      ( ModelPrimitiveType bool bool bool Bool )
            value.M_Version                                 = GetSingle(new IntPtr(p + 0x08C)); // 0x8C M_Version                   ( ModelPrimitiveType float float float Single )
            value.M_MotionVectorsPersistentData             = GetObject<MotionVectorsPersistentData>(new IntPtr(p + 0x090), ReversePrism.DataModels.MotionVectorsPersistentData.FromPointer); // 0x90 M_MotionVectorsPersistentData ( ModelClassType MotionVectorsPersistentData MotionVectorsPersistentData MotionVectorsPersistentData Pointer )
            value.M_TaaPersistentData                       = GetObject<TaaPersistentData>(new IntPtr(p + 0x098), ReversePrism.DataModels.TaaPersistentData.FromPointer); // 0x98 M_TaaPersistentData         ( ModelClassType TaaPersistentData TaaPersistentData TaaPersistentData Pointer )
            value.M_TaaSettings                             = (Settings)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_TaaSettings               ( ModelEnumType Settings Settings Settings Int32 )
            value.M_VolumeStack                             = GetObject<VolumeStack>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.VolumeStack.FromPointer); // 0xC0 M_VolumeStack               ( ModelClassType VolumeStack VolumeStack VolumeStack Pointer )

            return value;
        }
    }
}
