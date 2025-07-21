using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CaptureAnimator                          ModelClassType Animator Animator Animator Pointer
    // 028 CaptureCamera                            ModelClassType SplitScreenCaptureCamera SplitScreenCaptureCamera SplitScreenCaptureCamera Pointer
    // 030 VirtualCamera                            ModelClassType CinemachineVirtualCamera CinemachineVirtualCamera CinemachineVirtualCamera Pointer
    // 038 CaptureRenderTexture                     ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 040 DisplayRootObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 048 DisplayAnimator                          ModelClassType Animator Animator Animator Pointer
    // 050 Canvas                                   ModelClassType Canvas Canvas Canvas Pointer
    // 058 CaptureDisplayImage                      ModelClassType RawImage RawImage RawImage Pointer
    // 060 Shape                                    ModelClassType ShapeUgui ShapeUgui ShapeUgui Pointer
    // 068 DynamicCreatedRenderTexture              ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    public partial class SplitScreen : DataModel
    {
        public Animator?                                CaptureAnimator                         { get; set; }
        public SplitScreenCaptureCamera?                CaptureCamera                           { get; set; }
        public CinemachineVirtualCamera?                VirtualCamera                           { get; set; }
        public RenderTexture?                           CaptureRenderTexture                    { get; set; }
        public GameObject?                              DisplayRootObject                       { get; set; }
        public Animator?                                DisplayAnimator                         { get; set; }
        public Canvas?                                  Canvas                                  { get; set; }
        public RawImage?                                CaptureDisplayImage                     { get; set; }
        public ShapeUgui?                               Shape                                   { get; set; }
        public RenderTexture?                           DynamicCreatedRenderTexture             { get; set; }

        public static SplitScreen? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SplitScreen() { Pointer= p0 };

            value.CaptureAnimator                           = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0x20 CaptureAnimator             ( ModelClassType Animator Animator Animator Pointer )
            value.CaptureCamera                             = GetObject<SplitScreenCaptureCamera>(new IntPtr(p + 0x028), ReversePrism.DataModels.SplitScreenCaptureCamera.FromPointer); // 0x28 CaptureCamera               ( ModelClassType SplitScreenCaptureCamera SplitScreenCaptureCamera SplitScreenCaptureCamera Pointer )
            value.VirtualCamera                             = GetObject<CinemachineVirtualCamera>(new IntPtr(p + 0x030), ReversePrism.DataModels.CinemachineVirtualCamera.FromPointer); // 0x30 VirtualCamera               ( ModelClassType CinemachineVirtualCamera CinemachineVirtualCamera CinemachineVirtualCamera Pointer )
            value.CaptureRenderTexture                      = GetObject<RenderTexture>(new IntPtr(p + 0x038), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x38 CaptureRenderTexture        ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.DisplayRootObject                         = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 DisplayRootObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DisplayAnimator                           = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0x48 DisplayAnimator             ( ModelClassType Animator Animator Animator Pointer )
            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x050), ReversePrism.DataModels.Canvas.FromPointer); // 0x50 Canvas                      ( ModelClassType Canvas Canvas Canvas Pointer )
            value.CaptureDisplayImage                       = GetObject<RawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.RawImage.FromPointer); // 0x58 CaptureDisplayImage         ( ModelClassType RawImage RawImage RawImage Pointer )
            value.Shape                                     = GetObject<ShapeUgui>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShapeUgui.FromPointer); // 0x60 Shape                       ( ModelClassType ShapeUgui ShapeUgui ShapeUgui Pointer )
            value.DynamicCreatedRenderTexture               = GetObject<RenderTexture>(new IntPtr(p + 0x068), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x68 DynamicCreatedRenderTexture ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )

            return value;
        }
    }
}
