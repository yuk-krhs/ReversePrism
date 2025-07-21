using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BlendState                             ModelEnumType BlendState BlendState BlendState Int32
    // 054 M_RasterState                            ModelEnumType RasterState RasterState RasterState Int32
    // 064 M_DepthState                             ModelEnumType DepthState DepthState DepthState Int32
    // 066 M_StencilState                           ModelEnumType StencilState StencilState StencilState Int32
    // 074 M_StencilReference                       ModelPrimitiveType int int int Int32
    // 078 M_Mask                                   ModelEnumType RenderStateMask RenderStateMask RenderStateMask Int32
    public partial class RenderStateBlock : DataModel
    {
        public BlendState                               M_BlendState                            { get; set; }
        public RasterState                              M_RasterState                           { get; set; }
        public DepthState                               M_DepthState                            { get; set; }
        public StencilState                             M_StencilState                          { get; set; }
        public int                                      M_StencilReference                      { get; set; }
        public RenderStateMask                          M_Mask                                  { get; set; }

        public static RenderStateBlock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderStateBlock() { Pointer= p0 };

            value.M_BlendState                              = (BlendState)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_BlendState                ( ModelEnumType BlendState BlendState BlendState Int32 )
            value.M_RasterState                             = (RasterState)GetInt32(new IntPtr(p + 0x054)); // 0x54 M_RasterState               ( ModelEnumType RasterState RasterState RasterState Int32 )
            value.M_DepthState                              = (DepthState)GetInt32(new IntPtr(p + 0x064)); // 0x64 M_DepthState                ( ModelEnumType DepthState DepthState DepthState Int32 )
            value.M_StencilState                            = (StencilState)GetInt32(new IntPtr(p + 0x066)); // 0x66 M_StencilState              ( ModelEnumType StencilState StencilState StencilState Int32 )
            value.M_StencilReference                        = GetInt32(new IntPtr(p + 0x074)); // 0x74 M_StencilReference          ( ModelPrimitiveType int int int Int32 )
            value.M_Mask                                    = (RenderStateMask)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_Mask                      ( ModelEnumType RenderStateMask RenderStateMask RenderStateMask Int32 )

            return value;
        }
    }
}
