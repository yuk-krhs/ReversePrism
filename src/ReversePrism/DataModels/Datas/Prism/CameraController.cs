using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PostProcessResources                     00018676DC00 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer
    // 028 BaseCamera                               0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 030 MyCamera                                 0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 038 OffscreenImage                           000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 040 PostProcessOff                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 main                                     Camera IL2CPP_TYPE_CLASS
    // 044 SrpCameraCaptureId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CameraController
    {
        public PostProcessResources?                    PostProcessResources                    { get; set; }
        public Camera?                                  BaseCamera                              { get; set; }
        public Camera?                                  MyCamera                                { get; set; }
        public RenderTexture?                           OffscreenImage                          { get; set; }
        public bool                                     PostProcessOff                          { get; set; }
        public int                                      SrpCameraCaptureId                      { get; set; }

        public static CameraController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraController();

            value.PostProcessResources                      = GetObject<PostProcessResources>(new IntPtr(p + 0x020), ReversePrism.DataModels.PostProcessResources.FromPointer); // 0270D3307DF8 0x20 PostProcessResources        ( 00018676DC00 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer )
            value.BaseCamera                                = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0270D3307E18 0x28 BaseCamera                  ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.MyCamera                                  = GetObject<Camera>(new IntPtr(p + 0x030), ReversePrism.DataModels.Camera.FromPointer); // 0270D3307E38 0x30 MyCamera                    ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.OffscreenImage                            = GetObject<RenderTexture>(new IntPtr(p + 0x038), ReversePrism.DataModels.RenderTexture.FromPointer); // 0270D3307E58 0x38 OffscreenImage              ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.PostProcessOff                            = GetBool(new IntPtr(p + 0x040)); // 0270D3307E78 0x40 PostProcessOff              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SrpCameraCaptureId                        = GetInt32(new IntPtr(p + 0x044)); // 0270D3307EB8 0x44 SrpCameraCaptureId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
