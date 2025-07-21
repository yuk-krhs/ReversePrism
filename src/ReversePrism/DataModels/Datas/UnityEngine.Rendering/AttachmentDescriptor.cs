using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_LoadAction                             ModelEnumType RenderBufferLoadAction RenderBufferLoadAction RenderBufferLoadAction Int32
    // 014 M_StoreAction                            ModelEnumType RenderBufferStoreAction RenderBufferStoreAction RenderBufferStoreAction Int32
    // 018 M_Format                                 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 020 M_LoadStoreTarget                        ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 048 M_ResolveTarget                          ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 070 M_ClearColor                             ModelEnumType Color Color Color Int32
    // 080 M_ClearDepth                             ModelPrimitiveType float float float Single
    // 084 M_ClearStencil                           ModelPrimitiveType uint uint uint UInt32
    public partial class AttachmentDescriptor : DataModel
    {
        public RenderBufferLoadAction                   M_LoadAction                            { get; set; }
        public RenderBufferStoreAction                  M_StoreAction                           { get; set; }
        public GraphicsFormat                           M_Format                                { get; set; }
        public RenderTargetIdentifier                   M_LoadStoreTarget                       { get; set; }
        public RenderTargetIdentifier                   M_ResolveTarget                         { get; set; }
        public Color                                    M_ClearColor                            { get; set; }
        public float                                    M_ClearDepth                            { get; set; }
        public uint                                     M_ClearStencil                          { get; set; }

        public static AttachmentDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachmentDescriptor() { Pointer= p0 };

            value.M_LoadAction                              = (RenderBufferLoadAction)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_LoadAction                ( ModelEnumType RenderBufferLoadAction RenderBufferLoadAction RenderBufferLoadAction Int32 )
            value.M_StoreAction                             = (RenderBufferStoreAction)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_StoreAction               ( ModelEnumType RenderBufferStoreAction RenderBufferStoreAction RenderBufferStoreAction Int32 )
            value.M_Format                                  = (GraphicsFormat)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Format                    ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.M_LoadStoreTarget                         = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_LoadStoreTarget           ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.M_ResolveTarget                           = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_ResolveTarget             ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.M_ClearColor                              = (Color)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_ClearColor                ( ModelEnumType Color Color Color Int32 )
            value.M_ClearDepth                              = GetSingle(new IntPtr(p + 0x080)); // 0x80 M_ClearDepth                ( ModelPrimitiveType float float float Single )
            value.M_ClearStencil                            = GetUInt32(new IntPtr(p + 0x084)); // 0x84 M_ClearStencil              ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
