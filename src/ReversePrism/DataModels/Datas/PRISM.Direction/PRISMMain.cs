using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OverlayCanvasPrefab                      ModelClassType Canvas Canvas Canvas Pointer
    // 028 OverlayCanvasBelowBlurCamera             ModelClassType Camera Camera Camera Pointer
    // 030 OverlayCanvasAboveBlurCamera             ModelClassType Camera Camera Camera Pointer
    // 038 LoadingCanvas                            ModelClassType LoadingCanvas LoadingCanvas LoadingCanvas Pointer
    // 040 LoadingView                              ModelClassType LoadingView LoadingView LoadingView Pointer
    // 048 ConnectingView                           ModelClassType ConnectingView ConnectingView ConnectingView Pointer
    // 050 OverlayMask                              ModelClassType GameObject GameObject GameObject Pointer
    // 058 ButtonGotoTypeReference                  ModelClassType ButtonGotoTypeReference ButtonGotoTypeReference ButtonGotoTypeReference Pointer
    // 060 CanvasManager                            ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer
    // 000 DmmScreenWidth                           int IL2CPP_TYPE_I4
    // 000 DmmScreenHeight                          int IL2CPP_TYPE_I4
    // 000 NotFullScreenBorder                      float IL2CPP_TYPE_R4
    public partial class PRISMMain : DataModel
    {
        public Canvas?                                  OverlayCanvasPrefab                     { get; set; }
        public Camera?                                  OverlayCanvasBelowBlurCamera            { get; set; }
        public Camera?                                  OverlayCanvasAboveBlurCamera            { get; set; }
        public LoadingCanvas?                           LoadingCanvas                           { get; set; }
        public LoadingView?                             LoadingView                             { get; set; }
        public ConnectingView?                          ConnectingView                          { get; set; }
        public GameObject?                              OverlayMask                             { get; set; }
        public ButtonGotoTypeReference?                 ButtonGotoTypeReference                 { get; set; }
        public UICanvasManager?                         CanvasManager                           { get; set; }

        public static PRISMMain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PRISMMain() { Pointer= p0 };

            value.OverlayCanvasPrefab                       = GetObject<Canvas>(new IntPtr(p + 0x020), ReversePrism.DataModels.Canvas.FromPointer); // 0x20 OverlayCanvasPrefab         ( ModelClassType Canvas Canvas Canvas Pointer )
            value.OverlayCanvasBelowBlurCamera              = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0x28 OverlayCanvasBelowBlurCamera ( ModelClassType Camera Camera Camera Pointer )
            value.OverlayCanvasAboveBlurCamera              = GetObject<Camera>(new IntPtr(p + 0x030), ReversePrism.DataModels.Camera.FromPointer); // 0x30 OverlayCanvasAboveBlurCamera ( ModelClassType Camera Camera Camera Pointer )
            value.LoadingCanvas                             = GetObject<LoadingCanvas>(new IntPtr(p + 0x038), ReversePrism.DataModels.LoadingCanvas.FromPointer); // 0x38 LoadingCanvas               ( ModelClassType LoadingCanvas LoadingCanvas LoadingCanvas Pointer )
            value.LoadingView                               = GetObject<LoadingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.LoadingView.FromPointer); // 0x40 LoadingView                 ( ModelClassType LoadingView LoadingView LoadingView Pointer )
            value.ConnectingView                            = GetObject<ConnectingView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ConnectingView.FromPointer); // 0x48 ConnectingView              ( ModelClassType ConnectingView ConnectingView ConnectingView Pointer )
            value.OverlayMask                               = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 OverlayMask                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ButtonGotoTypeReference                   = GetObject<ButtonGotoTypeReference>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonGotoTypeReference.FromPointer); // 0x58 ButtonGotoTypeReference     ( ModelClassType ButtonGotoTypeReference ButtonGotoTypeReference ButtonGotoTypeReference Pointer )
            value.CanvasManager                             = GetObject<UICanvasManager>(new IntPtr(p + 0x060), ReversePrism.DataModels.UICanvasManager.FromPointer); // 0x60 CanvasManager               ( ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer )

            return value;
        }
    }
}
