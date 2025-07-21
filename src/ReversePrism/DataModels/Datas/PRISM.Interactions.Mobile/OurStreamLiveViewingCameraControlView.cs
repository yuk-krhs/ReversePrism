using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TapUIView                                ModelClassType OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView Pointer
    // 028 UnavailableIcon                          ModelClassType UIImage UIImage UIImage Pointer
    // 030 ShowUnavailableIconTime                  ModelPrimitiveType float float float Single
    // 034 FadeUnavailableIconTime                  ModelPrimitiveType float float float Single
    // 038 MinRotateXSensitivity                    ModelPrimitiveType float float float Single
    // 03C MinRotateYSensitivity                    ModelPrimitiveType float float float Single
    // 040 MaxRotateXSensitivity                    ModelPrimitiveType float float float Single
    // 044 MaxRotateYSensitivity                    ModelPrimitiveType float float float Single
    // 048 LimitRotateX                             ModelPrimitiveType float float float Single
    // 04C LimitRotateY                             ModelPrimitiveType float float float Single
    // 050 ZoomSensitivity                          ModelPrimitiveType float float float Single
    // 054 ZoomMouseScrollSensitivity               ModelPrimitiveType float float float Single
    // 058 MaxZoomInValue                           ModelPrimitiveType float float float Single
    // 05C MaxZoomOutValue                          ModelPrimitiveType float float float Single
    // 060 ResetPCameraFadeTime                     ModelPrimitiveType float float float Single
    // 064 ShowUnavailableIcon                      ModelPrimitiveType bool bool bool Bool
    // 068 CurrentUnavailableIconTime               ModelPrimitiveType float float float Single
    // 06C RotateX                                  ModelPrimitiveType float float float Single
    // 070 RotateY                                  ModelPrimitiveType float float float Single
    // 074 ZoomValue                                ModelPrimitiveType float float float Single
    // 078 CameraView                               ModelClassType CameraView CameraView CameraView Pointer
    // 080 IsLive                                   ModelPrimitiveType bool bool bool Bool
    // 088 ChangeCameraControlDisposable            ModelClassType IDisposable IDisposable IDisposable Pointer
    // 090 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class OurStreamLiveViewingCameraControlView : DataModel
    {
        public OurStreamLiveViewingScreenTapUIView?     TapUIView                               { get; set; }
        public UIImage?                                 UnavailableIcon                         { get; set; }
        public float                                    ShowUnavailableIconTime                 { get; set; }
        public float                                    FadeUnavailableIconTime                 { get; set; }
        public float                                    MinRotateXSensitivity                   { get; set; }
        public float                                    MinRotateYSensitivity                   { get; set; }
        public float                                    MaxRotateXSensitivity                   { get; set; }
        public float                                    MaxRotateYSensitivity                   { get; set; }
        public float                                    LimitRotateX                            { get; set; }
        public float                                    LimitRotateY                            { get; set; }
        public float                                    ZoomSensitivity                         { get; set; }
        public float                                    ZoomMouseScrollSensitivity              { get; set; }
        public float                                    MaxZoomInValue                          { get; set; }
        public float                                    MaxZoomOutValue                         { get; set; }
        public float                                    ResetPCameraFadeTime                    { get; set; }
        public bool                                     ShowUnavailableIcon                     { get; set; }
        public float                                    CurrentUnavailableIconTime              { get; set; }
        public float                                    RotateX                                 { get; set; }
        public float                                    RotateY                                 { get; set; }
        public float                                    ZoomValue                               { get; set; }
        public CameraView?                              CameraView                              { get; set; }
        public bool                                     IsLive                                  { get; set; }
        public IDisposable?                             ChangeCameraControlDisposable           { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static OurStreamLiveViewingCameraControlView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveViewingCameraControlView() { Pointer= p0 };

            value.TapUIView                                 = GetObject<OurStreamLiveViewingScreenTapUIView>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamLiveViewingScreenTapUIView.FromPointer); // 0x20 TapUIView                   ( ModelClassType OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView Pointer )
            value.UnavailableIcon                           = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 UnavailableIcon             ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ShowUnavailableIconTime                   = GetSingle(new IntPtr(p + 0x030)); // 0x30 ShowUnavailableIconTime     ( ModelPrimitiveType float float float Single )
            value.FadeUnavailableIconTime                   = GetSingle(new IntPtr(p + 0x034)); // 0x34 FadeUnavailableIconTime     ( ModelPrimitiveType float float float Single )
            value.MinRotateXSensitivity                     = GetSingle(new IntPtr(p + 0x038)); // 0x38 MinRotateXSensitivity       ( ModelPrimitiveType float float float Single )
            value.MinRotateYSensitivity                     = GetSingle(new IntPtr(p + 0x03C)); // 0x3C MinRotateYSensitivity       ( ModelPrimitiveType float float float Single )
            value.MaxRotateXSensitivity                     = GetSingle(new IntPtr(p + 0x040)); // 0x40 MaxRotateXSensitivity       ( ModelPrimitiveType float float float Single )
            value.MaxRotateYSensitivity                     = GetSingle(new IntPtr(p + 0x044)); // 0x44 MaxRotateYSensitivity       ( ModelPrimitiveType float float float Single )
            value.LimitRotateX                              = GetSingle(new IntPtr(p + 0x048)); // 0x48 LimitRotateX                ( ModelPrimitiveType float float float Single )
            value.LimitRotateY                              = GetSingle(new IntPtr(p + 0x04C)); // 0x4C LimitRotateY                ( ModelPrimitiveType float float float Single )
            value.ZoomSensitivity                           = GetSingle(new IntPtr(p + 0x050)); // 0x50 ZoomSensitivity             ( ModelPrimitiveType float float float Single )
            value.ZoomMouseScrollSensitivity                = GetSingle(new IntPtr(p + 0x054)); // 0x54 ZoomMouseScrollSensitivity  ( ModelPrimitiveType float float float Single )
            value.MaxZoomInValue                            = GetSingle(new IntPtr(p + 0x058)); // 0x58 MaxZoomInValue              ( ModelPrimitiveType float float float Single )
            value.MaxZoomOutValue                           = GetSingle(new IntPtr(p + 0x05C)); // 0x5C MaxZoomOutValue             ( ModelPrimitiveType float float float Single )
            value.ResetPCameraFadeTime                      = GetSingle(new IntPtr(p + 0x060)); // 0x60 ResetPCameraFadeTime        ( ModelPrimitiveType float float float Single )
            value.ShowUnavailableIcon                       = GetBool(new IntPtr(p + 0x064)); // 0x64 ShowUnavailableIcon         ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentUnavailableIconTime                = GetSingle(new IntPtr(p + 0x068)); // 0x68 CurrentUnavailableIconTime  ( ModelPrimitiveType float float float Single )
            value.RotateX                                   = GetSingle(new IntPtr(p + 0x06C)); // 0x6C RotateX                     ( ModelPrimitiveType float float float Single )
            value.RotateY                                   = GetSingle(new IntPtr(p + 0x070)); // 0x70 RotateY                     ( ModelPrimitiveType float float float Single )
            value.ZoomValue                                 = GetSingle(new IntPtr(p + 0x074)); // 0x74 ZoomValue                   ( ModelPrimitiveType float float float Single )
            value.CameraView                                = GetObject<CameraView>(new IntPtr(p + 0x078), ReversePrism.DataModels.CameraView.FromPointer); // 0x78 CameraView                  ( ModelClassType CameraView CameraView CameraView Pointer )
            value.IsLive                                    = GetBool(new IntPtr(p + 0x080)); // 0x80 IsLive                      ( ModelPrimitiveType bool bool bool Bool )
            value.ChangeCameraControlDisposable             = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0x88 ChangeCameraControlDisposable ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x090), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x90 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
