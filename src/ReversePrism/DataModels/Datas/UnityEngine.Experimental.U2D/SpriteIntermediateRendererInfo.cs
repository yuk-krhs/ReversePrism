using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SpriteID                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 TextureID                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 MaterialID                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 02C Transform                                00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 06C Bounds                                   000186599AF0 ModelEnumType Bounds Bounds Bounds Int32
    // 084 Layer                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 088 SortingLayer                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 08C SortingOrder                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 090 SceneCullingMask                         00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 098 IndexData                                <int> IL2CPP_TYPE_I
    // 0A0 VertexData                               <int> IL2CPP_TYPE_I
    // 0A8 IndexCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 0AC VertexCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 0B0 ShaderChannelMask                        0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SpriteIntermediateRendererInfo
    {
        public int                                      SpriteID                                { get; set; }
        public int                                      TextureID                               { get; set; }
        public int                                      MaterialID                              { get; set; }
        public Color                                    Color                                   { get; set; }
        public Matrix4x4                                Transform                               { get; set; }
        public Bounds                                   Bounds                                  { get; set; }
        public int                                      Layer                                   { get; set; }
        public int                                      SortingLayer                            { get; set; }
        public int                                      SortingOrder                            { get; set; }
        public ulong                                    SceneCullingMask                        { get; set; }
        public int                                      IndexCount                              { get; set; }
        public int                                      VertexCount                             { get; set; }
        public int                                      ShaderChannelMask                       { get; set; }

        public static SpriteIntermediateRendererInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteIntermediateRendererInfo();

            value.SpriteID                                  = GetInt32(new IntPtr(p + 0x010)); // 0270023A2A90 0x10 SpriteID                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TextureID                                 = GetInt32(new IntPtr(p + 0x014)); // 0270023A2AB0 0x14 TextureID                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaterialID                                = GetInt32(new IntPtr(p + 0x018)); // 0270023A2AD0 0x18 MaterialID                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x01C)); // 0270023A2AF0 0x1C Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.Transform                                 = (Matrix4x4)GetInt32(new IntPtr(p + 0x02C)); // 0270023A2B10 0x2C Transform                   ( 00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Bounds                                    = (Bounds)GetInt32(new IntPtr(p + 0x06C)); // 0270023A2B30 0x6C Bounds                      ( 000186599AF0 ModelEnumType Bounds Bounds Bounds Int32 )
            value.Layer                                     = GetInt32(new IntPtr(p + 0x084)); // 0270023A2B50 0x84 Layer                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SortingLayer                              = GetInt32(new IntPtr(p + 0x088)); // 0270023A2B70 0x88 SortingLayer                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SortingOrder                              = GetInt32(new IntPtr(p + 0x08C)); // 0270023A2B90 0x8C SortingOrder                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SceneCullingMask                          = GetUInt64(new IntPtr(p + 0x090)); // 0270023A2BB0 0x90 SceneCullingMask            ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x0A8)); // 0270023A2C10 0xA8 IndexCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VertexCount                               = GetInt32(new IntPtr(p + 0x0AC)); // 0270023A2C30 0xAC VertexCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ShaderChannelMask                         = GetInt32(new IntPtr(p + 0x0B0)); // 0270023A2C50 0xB0 ShaderChannelMask           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
