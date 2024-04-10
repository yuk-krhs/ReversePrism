using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TargetCamera                             0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 028 PreviewBufferDesc                        000186657320 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 060 TargetObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 EyeTarget                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 onBufferConstructed                      Action`1<CameraRenderData> IL2CPP_TYPE_GENERICINST
    // 078 PreviewBuffer                            000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 080 ReservedBuffer                           000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    public partial class CameraRenderData : DataModel
    {
        public Camera?                                  TargetCamera                            { get; set; }
        public RenderTextureDescriptor                  PreviewBufferDesc                       { get; set; }
        public GameObject?                              TargetObject                            { get; set; }
        public GameObject?                              EyeTarget                               { get; set; }
        public RenderTexture?                           PreviewBuffer                           { get; set; }
        public RenderTexture?                           ReservedBuffer                          { get; set; }

        public static CameraRenderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraRenderData() { Pointer= p0 };

            value.TargetCamera                              = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0245A3FD16E8 0x20 TargetCamera                ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.PreviewBufferDesc                         = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x028)); // 0245A3FD1708 0x28 PreviewBufferDesc           ( 000186657320 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.TargetObject                              = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3FD1728 0x60 TargetObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeTarget                                 = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3FD1748 0x68 EyeTarget                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PreviewBuffer                             = GetObject<RenderTexture>(new IntPtr(p + 0x078), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A3FD1788 0x78 PreviewBuffer               ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.ReservedBuffer                            = GetObject<RenderTexture>(new IntPtr(p + 0x080), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A3FD17A8 0x80 ReservedBuffer              ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )

            return value;
        }
    }
}
