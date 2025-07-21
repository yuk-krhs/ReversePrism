using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ViewMatrix                             ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 050 M_ProjectionMatrix                       ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 090 M_JitterMatrix                           ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0D0 Camera                                   ModelClassType Camera Camera Camera Pointer
    // 0D8 RenderType                               ModelEnumType CameraRenderType CameraRenderType CameraRenderType Int32
    // 0E0 TargetTexture                            ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 0E8 CameraTargetDescriptor                   ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 11C PixelRect                                ModelEnumType Rect Rect Rect Int32
    // 12C UseScreenCoordOverride                   ModelPrimitiveType bool bool bool Bool
    // 130 ScreenSizeOverride                       ModelEnumType Vector4 Vector4 Vector4 Int32
    // 140 ScreenCoordScaleBias                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 150 PixelWidth                               ModelPrimitiveType int int int Int32
    // 154 PixelHeight                              ModelPrimitiveType int int int Int32
    // 158 AspectRatio                              ModelPrimitiveType float float float Single
    // 15C RenderScale                              ModelPrimitiveType float float float Single
    // 160 ImageScalingMode                         ModelEnumType ImageScalingMode ImageScalingMode ImageScalingMode Int32
    // 164 UpscalingFilter                          ModelEnumType ImageUpscalingFilter ImageUpscalingFilter ImageUpscalingFilter Int32
    // 168 FsrOverrideSharpness                     ModelPrimitiveType bool bool bool Bool
    // 16C FsrSharpness                             ModelPrimitiveType float float float Single
    // 170 HdrColorBufferPrecision                  ModelEnumType HDRColorBufferPrecision HDRColorBufferPrecision HDRColorBufferPrecision Int32
    // 174 ClearDepth                               ModelPrimitiveType bool bool bool Bool
    // 178 CameraType                               ModelEnumType CameraType CameraType CameraType Int32
    // 17C IsDefaultViewport                        ModelPrimitiveType bool bool bool Bool
    // 17D IsHdrEnabled                             ModelPrimitiveType bool bool bool Bool
    // 17E AllowHDROutput                           ModelPrimitiveType bool bool bool Bool
    // 17F RequiresDepthTexture                     ModelPrimitiveType bool bool bool Bool
    // 180 RequiresOpaqueTexture                    ModelPrimitiveType bool bool bool Bool
    // 181 PostProcessingRequiresDepthTexture       ModelPrimitiveType bool bool bool Bool
    // 182 XrRendering                              ModelPrimitiveType bool bool bool Bool
    // 184 DefaultOpaqueSortFlags                   ModelEnumType SortingCriteria SortingCriteria SortingCriteria Int32
    // 188 Xr                                       ModelClassType XRPass XRPass XRPass Pointer
    // 190 IsStereoEnabled                          ModelPrimitiveType bool bool bool Bool
    // 194 MaxShadowDistance                        ModelPrimitiveType float float float Single
    // 198 PostProcessEnabled                       ModelPrimitiveType bool bool bool Bool
    // 1A0 captureActions                           IEnumerator`1<Action`2<RenderTargetIdentifier, CommandBuffer>> IL2CPP_TYPE_GENERICINST
    // 1A8 VolumeLayerMask                          ModelEnumType LayerMask LayerMask LayerMask Int32
    // 1B0 VolumeTrigger                            ModelClassType Transform Transform Transform Pointer
    // 1B8 IsStopNaNEnabled                         ModelPrimitiveType bool bool bool Bool
    // 1B9 IsDitheringEnabled                       ModelPrimitiveType bool bool bool Bool
    // 1BC Antialiasing                             ModelEnumType AntialiasingMode AntialiasingMode AntialiasingMode Int32
    // 1C0 AntialiasingQuality                      ModelEnumType AntialiasingQuality AntialiasingQuality AntialiasingQuality Int32
    // 1C8 Renderer                                 ModelClassType ScriptableRenderer ScriptableRenderer ScriptableRenderer Pointer
    // 1D0 ResolveFinalTarget                       ModelPrimitiveType bool bool bool Bool
    // 1D4 WorldSpaceCameraPos                      ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1E0 BackgroundColor                          ModelEnumType Color Color Color Int32
    // 1F0 TaaPersistentData                        ModelClassType TaaPersistentData TaaPersistentData TaaPersistentData Pointer
    // 1F8 TaaSettings                              ModelEnumType Settings Settings Settings Int32
    // 218 BaseCamera                               ModelClassType Camera Camera Camera Pointer
    public partial class CameraData : DataModel
    {
        public Matrix4x4                                M_ViewMatrix                            { get; set; }
        public Matrix4x4                                M_ProjectionMatrix                      { get; set; }
        public Matrix4x4                                M_JitterMatrix                          { get; set; }
        public Camera?                                  Camera                                  { get; set; }
        public CameraRenderType                         RenderType                              { get; set; }
        public RenderTexture?                           TargetTexture                           { get; set; }
        public RenderTextureDescriptor                  CameraTargetDescriptor                  { get; set; }
        public Rect                                     PixelRect                               { get; set; }
        public bool                                     UseScreenCoordOverride                  { get; set; }
        public Vector4                                  ScreenSizeOverride                      { get; set; }
        public Vector4                                  ScreenCoordScaleBias                    { get; set; }
        public int                                      PixelWidth                              { get; set; }
        public int                                      PixelHeight                             { get; set; }
        public float                                    AspectRatio                             { get; set; }
        public float                                    RenderScale                             { get; set; }
        public ImageScalingMode                         ImageScalingMode                        { get; set; }
        public ImageUpscalingFilter                     UpscalingFilter                         { get; set; }
        public bool                                     FsrOverrideSharpness                    { get; set; }
        public float                                    FsrSharpness                            { get; set; }
        public HDRColorBufferPrecision                  HdrColorBufferPrecision                 { get; set; }
        public bool                                     ClearDepth                              { get; set; }
        public CameraType                               CameraType                              { get; set; }
        public bool                                     IsDefaultViewport                       { get; set; }
        public bool                                     IsHdrEnabled                            { get; set; }
        public bool                                     AllowHDROutput                          { get; set; }
        public bool                                     RequiresDepthTexture                    { get; set; }
        public bool                                     RequiresOpaqueTexture                   { get; set; }
        public bool                                     PostProcessingRequiresDepthTexture      { get; set; }
        public bool                                     XrRendering                             { get; set; }
        public SortingCriteria                          DefaultOpaqueSortFlags                  { get; set; }
        public XRPass?                                  Xr                                      { get; set; }
        public bool                                     IsStereoEnabled                         { get; set; }
        public float                                    MaxShadowDistance                       { get; set; }
        public bool                                     PostProcessEnabled                      { get; set; }
        public LayerMask                                VolumeLayerMask                         { get; set; }
        public Transform?                               VolumeTrigger                           { get; set; }
        public bool                                     IsStopNaNEnabled                        { get; set; }
        public bool                                     IsDitheringEnabled                      { get; set; }
        public AntialiasingMode                         Antialiasing                            { get; set; }
        public AntialiasingQuality                      AntialiasingQuality                     { get; set; }
        public ScriptableRenderer?                      Renderer                                { get; set; }
        public bool                                     ResolveFinalTarget                      { get; set; }
        public Vector3                                  WorldSpaceCameraPos                     { get; set; }
        public Color                                    BackgroundColor                         { get; set; }
        public TaaPersistentData?                       TaaPersistentData                       { get; set; }
        public Settings                                 TaaSettings                             { get; set; }
        public Camera?                                  BaseCamera                              { get; set; }

        public static CameraData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraData() { Pointer= p0 };

            value.M_ViewMatrix                              = (Matrix4x4)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_ViewMatrix                ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_ProjectionMatrix                        = (Matrix4x4)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_ProjectionMatrix          ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_JitterMatrix                            = (Matrix4x4)GetInt32(new IntPtr(p + 0x090)); // 0x90 M_JitterMatrix              ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Camera.FromPointer); // 0xD0 Camera                      ( ModelClassType Camera Camera Camera Pointer )
            value.RenderType                                = (CameraRenderType)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 RenderType                  ( ModelEnumType CameraRenderType CameraRenderType CameraRenderType Int32 )
            value.TargetTexture                             = GetObject<RenderTexture>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.RenderTexture.FromPointer); // 0xE0 TargetTexture               ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.CameraTargetDescriptor                    = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 CameraTargetDescriptor      ( ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.PixelRect                                 = (Rect)GetInt32(new IntPtr(p + 0x11C)); // 0x11C PixelRect                   ( ModelEnumType Rect Rect Rect Int32 )
            value.UseScreenCoordOverride                    = GetBool(new IntPtr(p + 0x12C)); // 0x12C UseScreenCoordOverride      ( ModelPrimitiveType bool bool bool Bool )
            value.ScreenSizeOverride                        = (Vector4)GetInt32(new IntPtr(p + 0x130)); // 0x130 ScreenSizeOverride          ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ScreenCoordScaleBias                      = (Vector4)GetInt32(new IntPtr(p + 0x140)); // 0x140 ScreenCoordScaleBias        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.PixelWidth                                = GetInt32(new IntPtr(p + 0x150)); // 0x150 PixelWidth                  ( ModelPrimitiveType int int int Int32 )
            value.PixelHeight                               = GetInt32(new IntPtr(p + 0x154)); // 0x154 PixelHeight                 ( ModelPrimitiveType int int int Int32 )
            value.AspectRatio                               = GetSingle(new IntPtr(p + 0x158)); // 0x158 AspectRatio                 ( ModelPrimitiveType float float float Single )
            value.RenderScale                               = GetSingle(new IntPtr(p + 0x15C)); // 0x15C RenderScale                 ( ModelPrimitiveType float float float Single )
            value.ImageScalingMode                          = (ImageScalingMode)GetInt32(new IntPtr(p + 0x160)); // 0x160 ImageScalingMode            ( ModelEnumType ImageScalingMode ImageScalingMode ImageScalingMode Int32 )
            value.UpscalingFilter                           = (ImageUpscalingFilter)GetInt32(new IntPtr(p + 0x164)); // 0x164 UpscalingFilter             ( ModelEnumType ImageUpscalingFilter ImageUpscalingFilter ImageUpscalingFilter Int32 )
            value.FsrOverrideSharpness                      = GetBool(new IntPtr(p + 0x168)); // 0x168 FsrOverrideSharpness        ( ModelPrimitiveType bool bool bool Bool )
            value.FsrSharpness                              = GetSingle(new IntPtr(p + 0x16C)); // 0x16C FsrSharpness                ( ModelPrimitiveType float float float Single )
            value.HdrColorBufferPrecision                   = (HDRColorBufferPrecision)GetInt32(new IntPtr(p + 0x170)); // 0x170 HdrColorBufferPrecision     ( ModelEnumType HDRColorBufferPrecision HDRColorBufferPrecision HDRColorBufferPrecision Int32 )
            value.ClearDepth                                = GetBool(new IntPtr(p + 0x174)); // 0x174 ClearDepth                  ( ModelPrimitiveType bool bool bool Bool )
            value.CameraType                                = (CameraType)GetInt32(new IntPtr(p + 0x178)); // 0x178 CameraType                  ( ModelEnumType CameraType CameraType CameraType Int32 )
            value.IsDefaultViewport                         = GetBool(new IntPtr(p + 0x17C)); // 0x17C IsDefaultViewport           ( ModelPrimitiveType bool bool bool Bool )
            value.IsHdrEnabled                              = GetBool(new IntPtr(p + 0x17D)); // 0x17D IsHdrEnabled                ( ModelPrimitiveType bool bool bool Bool )
            value.AllowHDROutput                            = GetBool(new IntPtr(p + 0x17E)); // 0x17E AllowHDROutput              ( ModelPrimitiveType bool bool bool Bool )
            value.RequiresDepthTexture                      = GetBool(new IntPtr(p + 0x17F)); // 0x17F RequiresDepthTexture        ( ModelPrimitiveType bool bool bool Bool )
            value.RequiresOpaqueTexture                     = GetBool(new IntPtr(p + 0x180)); // 0x180 RequiresOpaqueTexture       ( ModelPrimitiveType bool bool bool Bool )
            value.PostProcessingRequiresDepthTexture        = GetBool(new IntPtr(p + 0x181)); // 0x181 PostProcessingRequiresDepthTexture ( ModelPrimitiveType bool bool bool Bool )
            value.XrRendering                               = GetBool(new IntPtr(p + 0x182)); // 0x182 XrRendering                 ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultOpaqueSortFlags                    = (SortingCriteria)GetInt32(new IntPtr(p + 0x184)); // 0x184 DefaultOpaqueSortFlags      ( ModelEnumType SortingCriteria SortingCriteria SortingCriteria Int32 )
            value.Xr                                        = GetObject<XRPass>(new IntPtr(p + 0x188), ReversePrism.DataModels.XRPass.FromPointer); // 0x188 Xr                          ( ModelClassType XRPass XRPass XRPass Pointer )
            value.IsStereoEnabled                           = GetBool(new IntPtr(p + 0x190)); // 0x190 IsStereoEnabled             ( ModelPrimitiveType bool bool bool Bool )
            value.MaxShadowDistance                         = GetSingle(new IntPtr(p + 0x194)); // 0x194 MaxShadowDistance           ( ModelPrimitiveType float float float Single )
            value.PostProcessEnabled                        = GetBool(new IntPtr(p + 0x198)); // 0x198 PostProcessEnabled          ( ModelPrimitiveType bool bool bool Bool )
            value.VolumeLayerMask                           = (LayerMask)GetInt32(new IntPtr(p + 0x1A8)); // 0x1A8 VolumeLayerMask             ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.VolumeTrigger                             = GetObject<Transform>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.Transform.FromPointer); // 0x1B0 VolumeTrigger               ( ModelClassType Transform Transform Transform Pointer )
            value.IsStopNaNEnabled                          = GetBool(new IntPtr(p + 0x1B8)); // 0x1B8 IsStopNaNEnabled            ( ModelPrimitiveType bool bool bool Bool )
            value.IsDitheringEnabled                        = GetBool(new IntPtr(p + 0x1B9)); // 0x1B9 IsDitheringEnabled          ( ModelPrimitiveType bool bool bool Bool )
            value.Antialiasing                              = (AntialiasingMode)GetInt32(new IntPtr(p + 0x1BC)); // 0x1BC Antialiasing                ( ModelEnumType AntialiasingMode AntialiasingMode AntialiasingMode Int32 )
            value.AntialiasingQuality                       = (AntialiasingQuality)GetInt32(new IntPtr(p + 0x1C0)); // 0x1C0 AntialiasingQuality         ( ModelEnumType AntialiasingQuality AntialiasingQuality AntialiasingQuality Int32 )
            value.Renderer                                  = GetObject<ScriptableRenderer>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.ScriptableRenderer.FromPointer); // 0x1C8 Renderer                    ( ModelClassType ScriptableRenderer ScriptableRenderer ScriptableRenderer Pointer )
            value.ResolveFinalTarget                        = GetBool(new IntPtr(p + 0x1D0)); // 0x1D0 ResolveFinalTarget          ( ModelPrimitiveType bool bool bool Bool )
            value.WorldSpaceCameraPos                       = (Vector3)GetInt32(new IntPtr(p + 0x1D4)); // 0x1D4 WorldSpaceCameraPos         ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BackgroundColor                           = (Color)GetInt32(new IntPtr(p + 0x1E0)); // 0x1E0 BackgroundColor             ( ModelEnumType Color Color Color Int32 )
            value.TaaPersistentData                         = GetObject<TaaPersistentData>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.TaaPersistentData.FromPointer); // 0x1F0 TaaPersistentData           ( ModelClassType TaaPersistentData TaaPersistentData TaaPersistentData Pointer )
            value.TaaSettings                               = (Settings)GetInt32(new IntPtr(p + 0x1F8)); // 0x1F8 TaaSettings                 ( ModelEnumType Settings Settings Settings Int32 )
            value.BaseCamera                                = GetObject<Camera>(new IntPtr(p + 0x218), ReversePrism.DataModels.Camera.FromPointer); // 0x218 BaseCamera                  ( ModelClassType Camera Camera Camera Pointer )

            return value;
        }
    }
}
