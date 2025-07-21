using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SpriteID                                 ModelPrimitiveType int int int Int32
    // 014 TextureID                                ModelPrimitiveType int int int Int32
    // 018 MaterialID                               ModelPrimitiveType int int int Int32
    // 01C Color                                    ModelEnumType Color Color Color Int32
    // 02C Transform                                ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 06C Bounds                                   ModelEnumType Bounds Bounds Bounds Int32
    // 084 Layer                                    ModelPrimitiveType int int int Int32
    // 088 SortingLayer                             ModelPrimitiveType int int int Int32
    // 08C SortingOrder                             ModelPrimitiveType int int int Int32
    // 090 SceneCullingMask                         ModelPrimitiveType ulong ulong ulong UInt64
    // 098 IndexData                                <int> IL2CPP_TYPE_I
    // 0A0 VertexData                               <int> IL2CPP_TYPE_I
    // 0A8 IndexCount                               ModelPrimitiveType int int int Int32
    // 0AC VertexCount                              ModelPrimitiveType int int int Int32
    // 0B0 ShaderChannelMask                        ModelPrimitiveType int int int Int32
    public partial class SpriteIntermediateRendererInfo : DataModel
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
            var value   = new SpriteIntermediateRendererInfo() { Pointer= p0 };

            value.SpriteID                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 SpriteID                    ( ModelPrimitiveType int int int Int32 )
            value.TextureID                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 TextureID                   ( ModelPrimitiveType int int int Int32 )
            value.MaterialID                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaterialID                  ( ModelPrimitiveType int int int Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Color                       ( ModelEnumType Color Color Color Int32 )
            value.Transform                                 = (Matrix4x4)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Transform                   ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Bounds                                    = (Bounds)GetInt32(new IntPtr(p + 0x06C)); // 0x6C Bounds                      ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.Layer                                     = GetInt32(new IntPtr(p + 0x084)); // 0x84 Layer                       ( ModelPrimitiveType int int int Int32 )
            value.SortingLayer                              = GetInt32(new IntPtr(p + 0x088)); // 0x88 SortingLayer                ( ModelPrimitiveType int int int Int32 )
            value.SortingOrder                              = GetInt32(new IntPtr(p + 0x08C)); // 0x8C SortingOrder                ( ModelPrimitiveType int int int Int32 )
            value.SceneCullingMask                          = GetUInt64(new IntPtr(p + 0x090)); // 0x90 SceneCullingMask            ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 IndexCount                  ( ModelPrimitiveType int int int Int32 )
            value.VertexCount                               = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC VertexCount                 ( ModelPrimitiveType int int int Int32 )
            value.ShaderChannelMask                         = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 ShaderChannelMask           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
