using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OverlayCanvasPrefab                      00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 028 OverlayCanvasBelowBlurCamera             0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 030 OverlayCanvasAboveBlurCamera             0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 038 LoadingCanvas                            00018659DCF0 ModelClassType LoadingCanvas LoadingCanvas LoadingCanvas Pointer
    // 040 LoadingView                              0001865A0650 ModelClassType LoadingView LoadingView LoadingView Pointer
    // 048 ConnectingView                           000186603050 ModelClassType ConnectingView ConnectingView ConnectingView Pointer
    // 050 OverlayMask                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 CommonPopupReference                     0001865E8590 ModelClassType CommonPopupReference CommonPopupReference CommonPopupReference Pointer
    // 060 ButtonGotoTypeReference                  0001865178C0 ModelClassType ButtonGotoTypeReference ButtonGotoTypeReference ButtonGotoTypeReference Pointer
    // 068 CanvasManager                            0001866E1E10 ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer
    public partial class PRISMMain
    {
        public Canvas?                                  OverlayCanvasPrefab                     { get; set; }
        public Camera?                                  OverlayCanvasBelowBlurCamera            { get; set; }
        public Camera?                                  OverlayCanvasAboveBlurCamera            { get; set; }
        public LoadingCanvas?                           LoadingCanvas                           { get; set; }
        public LoadingView?                             LoadingView                             { get; set; }
        public ConnectingView?                          ConnectingView                          { get; set; }
        public GameObject?                              OverlayMask                             { get; set; }
        public CommonPopupReference?                    CommonPopupReference                    { get; set; }
        public ButtonGotoTypeReference?                 ButtonGotoTypeReference                 { get; set; }
        public UICanvasManager?                         CanvasManager                           { get; set; }

        public static PRISMMain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PRISMMain();

            value.OverlayCanvasPrefab                       = GetObject<Canvas>(new IntPtr(p + 0x020), ReversePrism.DataModels.Canvas.FromPointer); // 027001E99C00 0x20 OverlayCanvasPrefab         ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.OverlayCanvasBelowBlurCamera              = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 027001E99C20 0x28 OverlayCanvasBelowBlurCamera ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.OverlayCanvasAboveBlurCamera              = GetObject<Camera>(new IntPtr(p + 0x030), ReversePrism.DataModels.Camera.FromPointer); // 027001E99C40 0x30 OverlayCanvasAboveBlurCamera ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.LoadingCanvas                             = GetObject<LoadingCanvas>(new IntPtr(p + 0x038), ReversePrism.DataModels.LoadingCanvas.FromPointer); // 027001E99C60 0x38 LoadingCanvas               ( 00018659DCF0 ModelClassType LoadingCanvas LoadingCanvas LoadingCanvas Pointer )
            value.LoadingView                               = GetObject<LoadingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.LoadingView.FromPointer); // 027001E99C80 0x40 LoadingView                 ( 0001865A0650 ModelClassType LoadingView LoadingView LoadingView Pointer )
            value.ConnectingView                            = GetObject<ConnectingView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ConnectingView.FromPointer); // 027001E99CA0 0x48 ConnectingView              ( 000186603050 ModelClassType ConnectingView ConnectingView ConnectingView Pointer )
            value.OverlayMask                               = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 027001E99CC0 0x50 OverlayMask                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonPopupReference                      = GetObject<CommonPopupReference>(new IntPtr(p + 0x058), ReversePrism.DataModels.CommonPopupReference.FromPointer); // 027001E99CE0 0x58 CommonPopupReference        ( 0001865E8590 ModelClassType CommonPopupReference CommonPopupReference CommonPopupReference Pointer )
            value.ButtonGotoTypeReference                   = GetObject<ButtonGotoTypeReference>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonGotoTypeReference.FromPointer); // 027001E99D00 0x60 ButtonGotoTypeReference     ( 0001865178C0 ModelClassType ButtonGotoTypeReference ButtonGotoTypeReference ButtonGotoTypeReference Pointer )
            value.CanvasManager                             = GetObject<UICanvasManager>(new IntPtr(p + 0x068), ReversePrism.DataModels.UICanvasManager.FromPointer); // 027001E99D20 0x68 CanvasManager               ( 0001866E1E10 ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer )

            return value;
        }
    }
}
