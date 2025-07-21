using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_NumLayers                              int IL2CPP_TYPE_I4
    // 010 ScreenRect                               ModelEnumType Rect Rect Rect Int32
    // 020 ViewDir                                  ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C ProjectionNear                           ModelPrimitiveType float float float Single
    // 030 ProjectionFar                            ModelPrimitiveType float float float Single
    // 034 CameraNear                               ModelPrimitiveType float float float Single
    // 038 CameraFar                                ModelPrimitiveType float float float Single
    // 03C CameraAspect                             ModelPrimitiveType float float float Single
    // 040 CameraToWorld                            ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 080 ActualWorldToClip                        ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0C0 CameraClipToWorld                        ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 100 CameraWorldToClip                        ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 140 ImplicitProjection                       ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 180 StereoWorldToClipLeft                    ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 1C0 StereoWorldToClipRight                   ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 200 WorldToCamera                            ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 240 Up                                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 24C Right                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 258 TransformDirection                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 264 CameraEuler                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 270 Velocity                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 27C FarPlaneWorldSpaceLength                 ModelPrimitiveType float float float Single
    // 280 RendererCount                            ModelPrimitiveType uint uint uint UInt32
    // 000 k_PlaneCount                             int IL2CPP_TYPE_I4
    // 284 M_ShadowCullPlanes                       ModelEnumType <m_ShadowCullPlanes>e__FixedBuffer <m_ShadowCullPlanes>e__FixedBuffer <m_ShadowCullPlanes>e__FixedBuffer Int32
    // 2E4 M_CameraCullPlanes                       ModelEnumType <m_CameraCullPlanes>e__FixedBuffer <m_CameraCullPlanes>e__FixedBuffer <m_CameraCullPlanes>e__FixedBuffer Int32
    // 344 BaseFarDistance                          ModelPrimitiveType float float float Single
    // 348 ShadowCullCenter                         ModelEnumType Vector3 Vector3 Vector3 Int32
    // 354 LayerCullDistances                       ModelEnumType <layerCullDistances>e__FixedBuffer <layerCullDistances>e__FixedBuffer <layerCullDistances>e__FixedBuffer Int32
    // 3D4 LayerCullSpherical                       ModelPrimitiveType int int int Int32
    // 3D8 CoreCameraValues                         ModelEnumType CoreCameraValues CoreCameraValues CoreCameraValues Int32
    // 3E4 CameraType                               ModelPrimitiveType uint uint uint UInt32
    // 3E8 ProjectionIsOblique                      ModelPrimitiveType int int int Int32
    // 3EC IsImplicitProjectionMatrix               ModelPrimitiveType int int int Int32
    public partial class CameraProperties : DataModel
    {
        public Rect                                     ScreenRect                              { get; set; }
        public Vector3                                  ViewDir                                 { get; set; }
        public float                                    ProjectionNear                          { get; set; }
        public float                                    ProjectionFar                           { get; set; }
        public float                                    CameraNear                              { get; set; }
        public float                                    CameraFar                               { get; set; }
        public float                                    CameraAspect                            { get; set; }
        public Matrix4x4                                CameraToWorld                           { get; set; }
        public Matrix4x4                                ActualWorldToClip                       { get; set; }
        public Matrix4x4                                CameraClipToWorld                       { get; set; }
        public Matrix4x4                                CameraWorldToClip                       { get; set; }
        public Matrix4x4                                ImplicitProjection                      { get; set; }
        public Matrix4x4                                StereoWorldToClipLeft                   { get; set; }
        public Matrix4x4                                StereoWorldToClipRight                  { get; set; }
        public Matrix4x4                                WorldToCamera                           { get; set; }
        public Vector3                                  Up                                      { get; set; }
        public Vector3                                  Right                                   { get; set; }
        public Vector3                                  TransformDirection                      { get; set; }
        public Vector3                                  CameraEuler                             { get; set; }
        public Vector3                                  Velocity                                { get; set; }
        public float                                    FarPlaneWorldSpaceLength                { get; set; }
        public uint                                     RendererCount                           { get; set; }
        public <m_ShadowCullPlanes>e__FixedBuffer       M_ShadowCullPlanes                      { get; set; }
        public <m_CameraCullPlanes>e__FixedBuffer       M_CameraCullPlanes                      { get; set; }
        public float                                    BaseFarDistance                         { get; set; }
        public Vector3                                  ShadowCullCenter                        { get; set; }
        public <layerCullDistances>e__FixedBuffer       LayerCullDistances                      { get; set; }
        public int                                      LayerCullSpherical                      { get; set; }
        public CoreCameraValues                         CoreCameraValues                        { get; set; }
        public uint                                     CameraType                              { get; set; }
        public int                                      ProjectionIsOblique                     { get; set; }
        public int                                      IsImplicitProjectionMatrix              { get; set; }

        public static CameraProperties? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraProperties() { Pointer= p0 };

            value.ScreenRect                                = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0x10 ScreenRect                  ( ModelEnumType Rect Rect Rect Int32 )
            value.ViewDir                                   = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 ViewDir                     ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ProjectionNear                            = GetSingle(new IntPtr(p + 0x02C)); // 0x2C ProjectionNear              ( ModelPrimitiveType float float float Single )
            value.ProjectionFar                             = GetSingle(new IntPtr(p + 0x030)); // 0x30 ProjectionFar               ( ModelPrimitiveType float float float Single )
            value.CameraNear                                = GetSingle(new IntPtr(p + 0x034)); // 0x34 CameraNear                  ( ModelPrimitiveType float float float Single )
            value.CameraFar                                 = GetSingle(new IntPtr(p + 0x038)); // 0x38 CameraFar                   ( ModelPrimitiveType float float float Single )
            value.CameraAspect                              = GetSingle(new IntPtr(p + 0x03C)); // 0x3C CameraAspect                ( ModelPrimitiveType float float float Single )
            value.CameraToWorld                             = (Matrix4x4)GetInt32(new IntPtr(p + 0x040)); // 0x40 CameraToWorld               ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ActualWorldToClip                         = (Matrix4x4)GetInt32(new IntPtr(p + 0x080)); // 0x80 ActualWorldToClip           ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.CameraClipToWorld                         = (Matrix4x4)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 CameraClipToWorld           ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.CameraWorldToClip                         = (Matrix4x4)GetInt32(new IntPtr(p + 0x100)); // 0x100 CameraWorldToClip           ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ImplicitProjection                        = (Matrix4x4)GetInt32(new IntPtr(p + 0x140)); // 0x140 ImplicitProjection          ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.StereoWorldToClipLeft                     = (Matrix4x4)GetInt32(new IntPtr(p + 0x180)); // 0x180 StereoWorldToClipLeft       ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.StereoWorldToClipRight                    = (Matrix4x4)GetInt32(new IntPtr(p + 0x1C0)); // 0x1C0 StereoWorldToClipRight      ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.WorldToCamera                             = (Matrix4x4)GetInt32(new IntPtr(p + 0x200)); // 0x200 WorldToCamera               ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Up                                        = (Vector3)GetInt32(new IntPtr(p + 0x240)); // 0x240 Up                          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Right                                     = (Vector3)GetInt32(new IntPtr(p + 0x24C)); // 0x24C Right                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TransformDirection                        = (Vector3)GetInt32(new IntPtr(p + 0x258)); // 0x258 TransformDirection          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraEuler                               = (Vector3)GetInt32(new IntPtr(p + 0x264)); // 0x264 CameraEuler                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Velocity                                  = (Vector3)GetInt32(new IntPtr(p + 0x270)); // 0x270 Velocity                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.FarPlaneWorldSpaceLength                  = GetSingle(new IntPtr(p + 0x27C)); // 0x27C FarPlaneWorldSpaceLength    ( ModelPrimitiveType float float float Single )
            value.RendererCount                             = GetUInt32(new IntPtr(p + 0x280)); // 0x280 RendererCount               ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_ShadowCullPlanes                        = (<m_ShadowCullPlanes>e__FixedBuffer)GetInt32(new IntPtr(p + 0x284)); // 0x284 M_ShadowCullPlanes          ( ModelEnumType <m_ShadowCullPlanes>e__FixedBuffer <m_ShadowCullPlanes>e__FixedBuffer <m_ShadowCullPlanes>e__FixedBuffer Int32 )
            value.M_CameraCullPlanes                        = (<m_CameraCullPlanes>e__FixedBuffer)GetInt32(new IntPtr(p + 0x2E4)); // 0x2E4 M_CameraCullPlanes          ( ModelEnumType <m_CameraCullPlanes>e__FixedBuffer <m_CameraCullPlanes>e__FixedBuffer <m_CameraCullPlanes>e__FixedBuffer Int32 )
            value.BaseFarDistance                           = GetSingle(new IntPtr(p + 0x344)); // 0x344 BaseFarDistance             ( ModelPrimitiveType float float float Single )
            value.ShadowCullCenter                          = (Vector3)GetInt32(new IntPtr(p + 0x348)); // 0x348 ShadowCullCenter            ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LayerCullDistances                        = (<layerCullDistances>e__FixedBuffer)GetInt32(new IntPtr(p + 0x354)); // 0x354 LayerCullDistances          ( ModelEnumType <layerCullDistances>e__FixedBuffer <layerCullDistances>e__FixedBuffer <layerCullDistances>e__FixedBuffer Int32 )
            value.LayerCullSpherical                        = GetInt32(new IntPtr(p + 0x3D4)); // 0x3D4 LayerCullSpherical          ( ModelPrimitiveType int int int Int32 )
            value.CoreCameraValues                          = (CoreCameraValues)GetInt32(new IntPtr(p + 0x3D8)); // 0x3D8 CoreCameraValues            ( ModelEnumType CoreCameraValues CoreCameraValues CoreCameraValues Int32 )
            value.CameraType                                = GetUInt32(new IntPtr(p + 0x3E4)); // 0x3E4 CameraType                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.ProjectionIsOblique                       = GetInt32(new IntPtr(p + 0x3E8)); // 0x3E8 ProjectionIsOblique         ( ModelPrimitiveType int int int Int32 )
            value.IsImplicitProjectionMatrix                = GetInt32(new IntPtr(p + 0x3EC)); // 0x3EC IsImplicitProjectionMatrix  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
