using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PostProcessResources                     ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer
    // 028 BaseCamera                               ModelClassType Camera Camera Camera Pointer
    // 030 OffscreenImage                           ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 000 main                                     Camera IL2CPP_TYPE_CLASS
    // 038 SrpCameraCaptureId                       ModelPrimitiveType int int int Int32
    public partial class CameraController : DataModel
    {
        public PostProcessResources?                    PostProcessResources                    { get; set; }
        public Camera?                                  BaseCamera                              { get; set; }
        public RenderTexture?                           OffscreenImage                          { get; set; }
        public int                                      SrpCameraCaptureId                      { get; set; }

        public static CameraController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraController() { Pointer= p0 };

            value.PostProcessResources                      = GetObject<PostProcessResources>(new IntPtr(p + 0x020), ReversePrism.DataModels.PostProcessResources.FromPointer); // 0x20 PostProcessResources        ( ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer )
            value.BaseCamera                                = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0x28 BaseCamera                  ( ModelClassType Camera Camera Camera Pointer )
            value.OffscreenImage                            = GetObject<RenderTexture>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x30 OffscreenImage              ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.SrpCameraCaptureId                        = GetInt32(new IntPtr(p + 0x038)); // 0x38 SrpCameraCaptureId          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
