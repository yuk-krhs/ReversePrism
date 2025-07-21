using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NeedsClosing                             ModelPrimitiveType bool bool bool Bool
    // 011 PopViewMatrix                            ModelPrimitiveType bool bool bool Bool
    // 012 PopScissorClip                           ModelPrimitiveType bool bool bool Bool
    // 013 BlitAndPopRenderTexture                  ModelPrimitiveType bool bool bool Bool
    // 014 PopDefaultMaterial                       ModelPrimitiveType bool bool bool Bool
    // 018 ClipUnregisterDrawCommand                ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 020 clipperRegisterVertices                  NativeSlice`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 030 clipperRegisterIndices                   NativeSlice`1<ushort> IL2CPP_TYPE_GENERICINST
    // 040 ClipperRegisterIndexOffset               ModelPrimitiveType int int int Int32
    // 044 MaskStencilRef                           ModelPrimitiveType int int int Int32
    public partial class ClosingInfo : DataModel
    {
        public bool                                     NeedsClosing                            { get; set; }
        public bool                                     PopViewMatrix                           { get; set; }
        public bool                                     PopScissorClip                          { get; set; }
        public bool                                     BlitAndPopRenderTexture                 { get; set; }
        public bool                                     PopDefaultMaterial                      { get; set; }
        public RenderChainCommand?                      ClipUnregisterDrawCommand               { get; set; }
        public int                                      ClipperRegisterIndexOffset              { get; set; }
        public int                                      MaskStencilRef                          { get; set; }

        public static ClosingInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClosingInfo() { Pointer= p0 };

            value.NeedsClosing                              = GetBool(new IntPtr(p + 0x010)); // 0x10 NeedsClosing                ( ModelPrimitiveType bool bool bool Bool )
            value.PopViewMatrix                             = GetBool(new IntPtr(p + 0x011)); // 0x11 PopViewMatrix               ( ModelPrimitiveType bool bool bool Bool )
            value.PopScissorClip                            = GetBool(new IntPtr(p + 0x012)); // 0x12 PopScissorClip              ( ModelPrimitiveType bool bool bool Bool )
            value.BlitAndPopRenderTexture                   = GetBool(new IntPtr(p + 0x013)); // 0x13 BlitAndPopRenderTexture     ( ModelPrimitiveType bool bool bool Bool )
            value.PopDefaultMaterial                        = GetBool(new IntPtr(p + 0x014)); // 0x14 PopDefaultMaterial          ( ModelPrimitiveType bool bool bool Bool )
            value.ClipUnregisterDrawCommand                 = GetObject<RenderChainCommand>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 0x18 ClipUnregisterDrawCommand   ( ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.ClipperRegisterIndexOffset                = GetInt32(new IntPtr(p + 0x040)); // 0x40 ClipperRegisterIndexOffset  ( ModelPrimitiveType int int int Int32 )
            value.MaskStencilRef                            = GetInt32(new IntPtr(p + 0x044)); // 0x44 MaskStencilRef              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
