using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 displaySubsystemInstance                 <int> IL2CPP_TYPE_I
    // 018 RenderPassIndex                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 RenderTarget                             000186655940 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 048 RenderTargetDesc                         000186657800 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 07C HasMotionVectorPass                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 080 MotionVectorRenderTarget                 000186655940 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 0A8 MotionVectorRenderTargetDesc             000186657800 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 0DC ShouldFillOutDepth                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 0E0 CullingPassIndex                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 0E8 foveatedRenderingInfo                    <int> IL2CPP_TYPE_I
    public partial class XRRenderPass
    {
        public int                                      RenderPassIndex                         { get; set; }
        public RenderTargetIdentifier                   RenderTarget                            { get; set; }
        public RenderTextureDescriptor                  RenderTargetDesc                        { get; set; }
        public bool                                     HasMotionVectorPass                     { get; set; }
        public RenderTargetIdentifier                   MotionVectorRenderTarget                { get; set; }
        public RenderTextureDescriptor                  MotionVectorRenderTargetDesc            { get; set; }
        public bool                                     ShouldFillOutDepth                      { get; set; }
        public int                                      CullingPassIndex                        { get; set; }

        public static XRRenderPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRRenderPass();

            value.RenderPassIndex                           = GetInt32(new IntPtr(p + 0x018)); // 0270069722E8 0x18 RenderPassIndex             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RenderTarget                              = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x020)); // 027006972308 0x20 RenderTarget                ( 000186655940 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.RenderTargetDesc                          = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x048)); // 027006972328 0x48 RenderTargetDesc            ( 000186657800 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.HasMotionVectorPass                       = GetBool(new IntPtr(p + 0x07C)); // 027006972348 0x7C HasMotionVectorPass         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.MotionVectorRenderTarget                  = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x080)); // 027006972368 0x80 MotionVectorRenderTarget    ( 000186655940 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.MotionVectorRenderTargetDesc              = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x0A8)); // 027006972388 0xA8 MotionVectorRenderTargetDesc ( 000186657800 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.ShouldFillOutDepth                        = GetBool(new IntPtr(p + 0x0DC)); // 0270069723A8 0xDC ShouldFillOutDepth          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CullingPassIndex                          = GetInt32(new IntPtr(p + 0x0E0)); // 0270069723C8 0xE0 CullingPassIndex            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
