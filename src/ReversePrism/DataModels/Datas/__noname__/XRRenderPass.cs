using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 displaySubsystemInstance                 <int> IL2CPP_TYPE_I
    // 018 RenderPassIndex                          ModelPrimitiveType int int int Int32
    // 020 RenderTarget                             ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 048 RenderTargetDesc                         ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 07C HasMotionVectorPass                      ModelPrimitiveType bool bool bool Bool
    // 080 MotionVectorRenderTarget                 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 0A8 MotionVectorRenderTargetDesc             ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 0DC ShouldFillOutDepth                       ModelPrimitiveType bool bool bool Bool
    // 0E0 CullingPassIndex                         ModelPrimitiveType int int int Int32
    // 0E8 foveatedRenderingInfo                    <int> IL2CPP_TYPE_I
    public partial class XRRenderPass : DataModel
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
            var value   = new XRRenderPass() { Pointer= p0 };

            value.RenderPassIndex                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 RenderPassIndex             ( ModelPrimitiveType int int int Int32 )
            value.RenderTarget                              = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x020)); // 0x20 RenderTarget                ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.RenderTargetDesc                          = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x048)); // 0x48 RenderTargetDesc            ( ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.HasMotionVectorPass                       = GetBool(new IntPtr(p + 0x07C)); // 0x7C HasMotionVectorPass         ( ModelPrimitiveType bool bool bool Bool )
            value.MotionVectorRenderTarget                  = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x080)); // 0x80 MotionVectorRenderTarget    ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.MotionVectorRenderTargetDesc              = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 MotionVectorRenderTargetDesc ( ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.ShouldFillOutDepth                        = GetBool(new IntPtr(p + 0x0DC)); // 0xDC ShouldFillOutDepth          ( ModelPrimitiveType bool bool bool Bool )
            value.CullingPassIndex                          = GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 CullingPassIndex            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
