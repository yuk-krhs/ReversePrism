using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderingFlags                           0001866CF070 ModelEnumType RenderingFlag RenderingFlag RenderingFlag Int32
    // 018 Camera                                   0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 020 PostProcessLayer                         00018676C2C0 ModelClassType PostProcessLayer PostProcessLayer PostProcessLayer Pointer
    // 028 CullingResults                           0001866656C0 ModelEnumType CullingResults CullingResults CullingResults Int32
    // 038 TargetBuffer                             000186655450 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 060 TargetBufferDesc                         000186657320 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
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

            value.RenderingFlags                            = (RenderingFlag)GetInt32(new IntPtr(p + 0x010)); // 02466BB14420 0x10 RenderingFlags              ( 0001866CF070 ModelEnumType RenderingFlag RenderingFlag RenderingFlag Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x018), ReversePrism.DataModels.Camera.FromPointer); // 02466BB14440 0x18 Camera                      ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.PostProcessLayer                          = GetObject<PostProcessLayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.PostProcessLayer.FromPointer); // 02466BB14460 0x20 PostProcessLayer            ( 00018676C2C0 ModelClassType PostProcessLayer PostProcessLayer PostProcessLayer Pointer )
            value.CullingResults                            = (CullingResults)GetInt32(new IntPtr(p + 0x028)); // 02466BB14480 0x28 CullingResults              ( 0001866656C0 ModelEnumType CullingResults CullingResults CullingResults Int32 )
            value.TargetBuffer                              = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x038)); // 02466BB144A0 0x38 TargetBuffer                ( 000186655450 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.TargetBufferDesc                          = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x060)); // 02466BB144C0 0x60 TargetBufferDesc            ( 000186657320 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )

            return value;
        }
    }
}
