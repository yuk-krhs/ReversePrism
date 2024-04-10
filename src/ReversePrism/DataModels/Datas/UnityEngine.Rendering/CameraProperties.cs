using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScreenRect                               00018664F620 ModelEnumType Rect Rect Rect Int32
    // 020 ViewDir                                  0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C ProjectionNear                           0001866656B0 ModelPrimitiveType float float float Single
    // 030 ProjectionFar                            0001866656B0 ModelPrimitiveType float float float Single
    // 034 CameraNear                               0001866656B0 ModelPrimitiveType float float float Single
    // 038 CameraFar                                0001866656B0 ModelPrimitiveType float float float Single
    // 03C CameraAspect                             0001866656B0 ModelPrimitiveType float float float Single
    // 040 CameraToWorld                            00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 080 ActualWorldToClip                        00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0C0 CameraClipToWorld                        00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 100 CameraWorldToClip                        00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 140 ImplicitProjection                       00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 180 StereoWorldToClipLeft                    00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 1C0 StereoWorldToClipRight                   00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 200 WorldToCamera                            00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 240 Up                                       0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 24C Right                                    0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 258 TransformDirection                       0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 264 CameraEuler                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 270 Velocity                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 27C FarPlaneWorldSpaceLength                 0001866656B0 ModelPrimitiveType float float float Single
    // 280 RendererCount                            000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 284 M_ShadowCullPlanes                       0001867238B0 ModelEnumType <m_ShadowCullPlanes>e__FixedBuffer <m_ShadowCullPlanes>e__FixedBuffer <m_ShadowCullPlanes>e__FixedBuffer Int32
    // 2E4 M_CameraCullPlanes                       0001867233C0 ModelEnumType <m_CameraCullPlanes>e__FixedBuffer <m_CameraCullPlanes>e__FixedBuffer <m_CameraCullPlanes>e__FixedBuffer Int32
    // 344 BaseFarDistance                          0001866656B0 ModelPrimitiveType float float float Single
    // 348 ShadowCullCenter                         0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 354 LayerCullDistances                       000186722EC0 ModelEnumType <layerCullDistances>e__FixedBuffer <layerCullDistances>e__FixedBuffer <layerCullDistances>e__FixedBuffer Int32
    // 3D4 LayerCullSpherical                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 3D8 CoreCameraValues                         0001866229F0 ModelEnumType CoreCameraValues CoreCameraValues CoreCameraValues Int32
    // 3E4 CameraType                               000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 3E8 ProjectionIsOblique                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 3EC IsImplicitProjectionMatrix               0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.ScreenRect                                = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0245A2457E98 0x10 ScreenRect                  ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.ViewDir                                   = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0245A2457EB8 0x20 ViewDir                     ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ProjectionNear                            = GetSingle(new IntPtr(p + 0x02C)); // 0245A2457ED8 0x2C ProjectionNear              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ProjectionFar                             = GetSingle(new IntPtr(p + 0x030)); // 0245A2457EF8 0x30 ProjectionFar               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraNear                                = GetSingle(new IntPtr(p + 0x034)); // 0245A2457F18 0x34 CameraNear                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraFar                                 = GetSingle(new IntPtr(p + 0x038)); // 0245A2457F38 0x38 CameraFar                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraAspect                              = GetSingle(new IntPtr(p + 0x03C)); // 0245A2457F58 0x3C CameraAspect                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraToWorld                             = (Matrix4x4)GetInt32(new IntPtr(p + 0x040)); // 0245A2457F78 0x40 CameraToWorld               ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ActualWorldToClip                         = (Matrix4x4)GetInt32(new IntPtr(p + 0x080)); // 0245A2457F98 0x80 ActualWorldToClip           ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.CameraClipToWorld                         = (Matrix4x4)GetInt32(new IntPtr(p + 0x0C0)); // 0245A2457FB8 0xC0 CameraClipToWorld           ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.CameraWorldToClip                         = (Matrix4x4)GetInt32(new IntPtr(p + 0x100)); // 0245A2457FD8 0x100 CameraWorldToClip           ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ImplicitProjection                        = (Matrix4x4)GetInt32(new IntPtr(p + 0x140)); // 0245A2457FF8 0x140 ImplicitProjection          ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.StereoWorldToClipLeft                     = (Matrix4x4)GetInt32(new IntPtr(p + 0x180)); // 0245A2458018 0x180 StereoWorldToClipLeft       ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.StereoWorldToClipRight                    = (Matrix4x4)GetInt32(new IntPtr(p + 0x1C0)); // 0245A2458038 0x1C0 StereoWorldToClipRight      ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.WorldToCamera                             = (Matrix4x4)GetInt32(new IntPtr(p + 0x200)); // 0245A2458058 0x200 WorldToCamera               ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Up                                        = (Vector3)GetInt32(new IntPtr(p + 0x240)); // 0245A2458078 0x240 Up                          ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Right                                     = (Vector3)GetInt32(new IntPtr(p + 0x24C)); // 0245A2458098 0x24C Right                       ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TransformDirection                        = (Vector3)GetInt32(new IntPtr(p + 0x258)); // 0245A24580B8 0x258 TransformDirection          ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraEuler                               = (Vector3)GetInt32(new IntPtr(p + 0x264)); // 0245A24580D8 0x264 CameraEuler                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Velocity                                  = (Vector3)GetInt32(new IntPtr(p + 0x270)); // 0245A24580F8 0x270 Velocity                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.FarPlaneWorldSpaceLength                  = GetSingle(new IntPtr(p + 0x27C)); // 0245A2458118 0x27C FarPlaneWorldSpaceLength    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RendererCount                             = GetUInt32(new IntPtr(p + 0x280)); // 0245A2458138 0x280 RendererCount               ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_ShadowCullPlanes                        = (<m_ShadowCullPlanes>e__FixedBuffer)GetInt32(new IntPtr(p + 0x284)); // 0245A2458158 0x284 M_ShadowCullPlanes          ( 0001867238B0 ModelEnumType <m_ShadowCullPlanes>e__FixedBuffer <m_ShadowCullPlanes>e__FixedBuffer <m_ShadowCullPlanes>e__FixedBuffer Int32 )
            value.M_CameraCullPlanes                        = (<m_CameraCullPlanes>e__FixedBuffer)GetInt32(new IntPtr(p + 0x2E4)); // 0245A2458178 0x2E4 M_CameraCullPlanes          ( 0001867233C0 ModelEnumType <m_CameraCullPlanes>e__FixedBuffer <m_CameraCullPlanes>e__FixedBuffer <m_CameraCullPlanes>e__FixedBuffer Int32 )
            value.BaseFarDistance                           = GetSingle(new IntPtr(p + 0x344)); // 0245A2458198 0x344 BaseFarDistance             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ShadowCullCenter                          = (Vector3)GetInt32(new IntPtr(p + 0x348)); // 0245A24581B8 0x348 ShadowCullCenter            ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LayerCullDistances                        = (<layerCullDistances>e__FixedBuffer)GetInt32(new IntPtr(p + 0x354)); // 0245A24581D8 0x354 LayerCullDistances          ( 000186722EC0 ModelEnumType <layerCullDistances>e__FixedBuffer <layerCullDistances>e__FixedBuffer <layerCullDistances>e__FixedBuffer Int32 )
            value.LayerCullSpherical                        = GetInt32(new IntPtr(p + 0x3D4)); // 0245A24581F8 0x3D4 LayerCullSpherical          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CoreCameraValues                          = (CoreCameraValues)GetInt32(new IntPtr(p + 0x3D8)); // 0245A2458218 0x3D8 CoreCameraValues            ( 0001866229F0 ModelEnumType CoreCameraValues CoreCameraValues CoreCameraValues Int32 )
            value.CameraType                                = GetUInt32(new IntPtr(p + 0x3E4)); // 0245A2458238 0x3E4 CameraType                  ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.ProjectionIsOblique                       = GetInt32(new IntPtr(p + 0x3E8)); // 0245A2458258 0x3E8 ProjectionIsOblique         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsImplicitProjectionMatrix                = GetInt32(new IntPtr(p + 0x3EC)); // 0245A2458278 0x3EC IsImplicitProjectionMatrix  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
