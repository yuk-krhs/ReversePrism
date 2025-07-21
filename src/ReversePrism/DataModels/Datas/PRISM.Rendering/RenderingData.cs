using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderingFlags                           ModelEnumType RenderingFlag RenderingFlag RenderingFlag Int32
    // 018 Camera                                   ModelClassType Camera Camera Camera Pointer
    // 020 PostProcessLayer                         ModelClassType PostProcessLayer PostProcessLayer PostProcessLayer Pointer
    // 028 CullingResults                           ModelEnumType CullingResults CullingResults CullingResults Int32
    // 038 TargetBuffer                             ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 060 TargetBufferDesc                         ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    public partial class RenderingData : DataModel
    {
        public RenderingFlag                            RenderingFlags                          { get; set; }
        public Camera?                                  Camera                                  { get; set; }
        public PostProcessLayer?                        PostProcessLayer                        { get; set; }
        public CullingResults                           CullingResults                          { get; set; }
        public RenderTargetIdentifier                   TargetBuffer                            { get; set; }
        public RenderTextureDescriptor                  TargetBufferDesc                        { get; set; }

        public static RenderingData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderingData() { Pointer= p0 };

            value.RenderingFlags                            = (RenderingFlag)GetInt32(new IntPtr(p + 0x010)); // 0x10 RenderingFlags              ( ModelEnumType RenderingFlag RenderingFlag RenderingFlag Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x018), ReversePrism.DataModels.Camera.FromPointer); // 0x18 Camera                      ( ModelClassType Camera Camera Camera Pointer )
            value.PostProcessLayer                          = GetObject<PostProcessLayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.PostProcessLayer.FromPointer); // 0x20 PostProcessLayer            ( ModelClassType PostProcessLayer PostProcessLayer PostProcessLayer Pointer )
            value.CullingResults                            = (CullingResults)GetInt32(new IntPtr(p + 0x028)); // 0x28 CullingResults              ( ModelEnumType CullingResults CullingResults CullingResults Int32 )
            value.TargetBuffer                              = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x038)); // 0x38 TargetBuffer                ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.TargetBufferDesc                          = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x060)); // 0x60 TargetBufferDesc            ( ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )

            return value;
        }
    }
}
