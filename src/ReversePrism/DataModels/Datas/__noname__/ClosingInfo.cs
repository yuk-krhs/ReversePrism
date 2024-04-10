using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NeedsClosing                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 PopViewMatrix                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 012 PopScissorClip                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 013 BlitAndPopRenderTexture                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 PopDefaultMaterial                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 ClipUnregisterDrawCommand                0001866549D0 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 020 clipperRegisterVertices                  NativeSlice`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 030 clipperRegisterIndices                   NativeSlice`1<ushort> IL2CPP_TYPE_GENERICINST
    // 040 ClipperRegisterIndexOffset               0001865F36C0 ModelPrimitiveType int int int Int32
    // 044 MaskStencilRef                           0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.NeedsClosing                              = GetBool(new IntPtr(p + 0x010)); // 0245A6841558 0x10 NeedsClosing                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PopViewMatrix                             = GetBool(new IntPtr(p + 0x011)); // 0245A6841578 0x11 PopViewMatrix               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PopScissorClip                            = GetBool(new IntPtr(p + 0x012)); // 0245A6841598 0x12 PopScissorClip              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.BlitAndPopRenderTexture                   = GetBool(new IntPtr(p + 0x013)); // 0245A68415B8 0x13 BlitAndPopRenderTexture     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PopDefaultMaterial                        = GetBool(new IntPtr(p + 0x014)); // 0245A68415D8 0x14 PopDefaultMaterial          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ClipUnregisterDrawCommand                 = GetObject<RenderChainCommand>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 0245A68415F8 0x18 ClipUnregisterDrawCommand   ( 0001866549D0 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.ClipperRegisterIndexOffset                = GetInt32(new IntPtr(p + 0x040)); // 0245A6841658 0x40 ClipperRegisterIndexOffset  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaskStencilRef                            = GetInt32(new IntPtr(p + 0x044)); // 0245A6841678 0x44 MaskStencilRef              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
