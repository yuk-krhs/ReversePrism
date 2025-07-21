using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultReservedBufferScale               float IL2CPP_TYPE_R4
    // 020 PrimaryType                              ModelEnumType CameraPrimaryType CameraPrimaryType CameraPrimaryType Int32
    // 028 TargetCamera                             ModelClassType Camera Camera Camera Pointer
    // 030 PreviewBufferDesc                        ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 068 TargetObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 070 EyeTarget                                ModelClassType GameObject GameObject GameObject Pointer
    // 078 onBufferConstructed                      Action`1<CameraRenderData> IL2CPP_TYPE_GENERICINST
    // 080 PreviewBuffer                            ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 088 ReservedBuffer                           ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    public partial class CameraRenderData : DataModel
    {
        public CameraPrimaryType                        PrimaryType                             { get; set; }
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

            value.PrimaryType                               = (CameraPrimaryType)GetInt32(new IntPtr(p + 0x020)); // 0x20 PrimaryType                 ( ModelEnumType CameraPrimaryType CameraPrimaryType CameraPrimaryType Int32 )
            value.TargetCamera                              = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0x28 TargetCamera                ( ModelClassType Camera Camera Camera Pointer )
            value.PreviewBufferDesc                         = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x030)); // 0x30 PreviewBufferDesc           ( ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.TargetObject                              = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 TargetObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeTarget                                 = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 EyeTarget                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PreviewBuffer                             = GetObject<RenderTexture>(new IntPtr(p + 0x080), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x80 PreviewBuffer               ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.ReservedBuffer                            = GetObject<RenderTexture>(new IntPtr(p + 0x088), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x88 ReservedBuffer              ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )

            return value;
        }
    }
}
