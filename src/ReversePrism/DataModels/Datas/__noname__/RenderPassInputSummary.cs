using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RequiresDepthTexture                     ModelPrimitiveType bool bool bool Bool
    // 011 RequiresDepthPrepass                     ModelPrimitiveType bool bool bool Bool
    // 012 RequiresNormalsTexture                   ModelPrimitiveType bool bool bool Bool
    // 013 RequiresColorTexture                     ModelPrimitiveType bool bool bool Bool
    // 014 RequiresColorTextureCreated              ModelPrimitiveType bool bool bool Bool
    // 015 RequiresMotionVectors                    ModelPrimitiveType bool bool bool Bool
    // 018 RequiresDepthNormalAtEvent               ModelEnumType RenderPassEvent RenderPassEvent RenderPassEvent Int32
    // 01C RequiresDepthTextureEarliestEvent        ModelEnumType RenderPassEvent RenderPassEvent RenderPassEvent Int32
    public partial class RenderPassInputSummary : DataModel
    {
        public bool                                     RequiresDepthTexture                    { get; set; }
        public bool                                     RequiresDepthPrepass                    { get; set; }
        public bool                                     RequiresNormalsTexture                  { get; set; }
        public bool                                     RequiresColorTexture                    { get; set; }
        public bool                                     RequiresColorTextureCreated             { get; set; }
        public bool                                     RequiresMotionVectors                   { get; set; }
        public RenderPassEvent                          RequiresDepthNormalAtEvent              { get; set; }
        public RenderPassEvent                          RequiresDepthTextureEarliestEvent       { get; set; }

        public static RenderPassInputSummary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderPassInputSummary() { Pointer= p0 };

            value.RequiresDepthTexture                      = GetBool(new IntPtr(p + 0x010)); // 0x10 RequiresDepthTexture        ( ModelPrimitiveType bool bool bool Bool )
            value.RequiresDepthPrepass                      = GetBool(new IntPtr(p + 0x011)); // 0x11 RequiresDepthPrepass        ( ModelPrimitiveType bool bool bool Bool )
            value.RequiresNormalsTexture                    = GetBool(new IntPtr(p + 0x012)); // 0x12 RequiresNormalsTexture      ( ModelPrimitiveType bool bool bool Bool )
            value.RequiresColorTexture                      = GetBool(new IntPtr(p + 0x013)); // 0x13 RequiresColorTexture        ( ModelPrimitiveType bool bool bool Bool )
            value.RequiresColorTextureCreated               = GetBool(new IntPtr(p + 0x014)); // 0x14 RequiresColorTextureCreated ( ModelPrimitiveType bool bool bool Bool )
            value.RequiresMotionVectors                     = GetBool(new IntPtr(p + 0x015)); // 0x15 RequiresMotionVectors       ( ModelPrimitiveType bool bool bool Bool )
            value.RequiresDepthNormalAtEvent                = (RenderPassEvent)GetInt32(new IntPtr(p + 0x018)); // 0x18 RequiresDepthNormalAtEvent  ( ModelEnumType RenderPassEvent RenderPassEvent RenderPassEvent Int32 )
            value.RequiresDepthTextureEarliestEvent         = (RenderPassEvent)GetInt32(new IntPtr(p + 0x01C)); // 0x1C RequiresDepthTextureEarliestEvent ( ModelEnumType RenderPassEvent RenderPassEvent RenderPassEvent Int32 )

            return value;
        }
    }
}
