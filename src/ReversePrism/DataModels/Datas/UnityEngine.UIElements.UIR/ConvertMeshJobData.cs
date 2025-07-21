using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 vertSrc                                  <int> IL2CPP_TYPE_I
    // 018 vertDst                                  <int> IL2CPP_TYPE_I
    // 020 VertCount                                ModelPrimitiveType int int int Int32
    // 024 Transform                                ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 064 TransformUVs                             ModelPrimitiveType int int int Int32
    // 068 XformClipPages                           ModelEnumType Color32 Color32 Color32 Int32
    // 06C Ids                                      ModelEnumType Color32 Color32 Color32 Int32
    // 070 AddFlags                                 ModelEnumType Color32 Color32 Color32 Int32
    // 074 OpacityPage                              ModelEnumType Color32 Color32 Color32 Int32
    // 078 TextCoreSettingsPage                     ModelEnumType Color32 Color32 Color32 Int32
    // 07C IsText                                   ModelPrimitiveType int int int Int32
    // 080 TextureId                                ModelPrimitiveType float float float Single
    // 088 indexSrc                                 <int> IL2CPP_TYPE_I
    // 090 indexDst                                 <int> IL2CPP_TYPE_I
    // 098 IndexCount                               ModelPrimitiveType int int int Int32
    // 09C IndexOffset                              ModelPrimitiveType int int int Int32
    // 0A0 FlipIndices                              ModelPrimitiveType int int int Int32
    public partial class ConvertMeshJobData : DataModel
    {
        public int                                      VertCount                               { get; set; }
        public Matrix4x4                                Transform                               { get; set; }
        public int                                      TransformUVs                            { get; set; }
        public Color32                                  XformClipPages                          { get; set; }
        public Color32                                  Ids                                     { get; set; }
        public Color32                                  AddFlags                                { get; set; }
        public Color32                                  OpacityPage                             { get; set; }
        public Color32                                  TextCoreSettingsPage                    { get; set; }
        public int                                      IsText                                  { get; set; }
        public float                                    TextureId                               { get; set; }
        public int                                      IndexCount                              { get; set; }
        public int                                      IndexOffset                             { get; set; }
        public int                                      FlipIndices                             { get; set; }

        public static ConvertMeshJobData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConvertMeshJobData() { Pointer= p0 };

            value.VertCount                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 VertCount                   ( ModelPrimitiveType int int int Int32 )
            value.Transform                                 = (Matrix4x4)GetInt32(new IntPtr(p + 0x024)); // 0x24 Transform                   ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.TransformUVs                              = GetInt32(new IntPtr(p + 0x064)); // 0x64 TransformUVs                ( ModelPrimitiveType int int int Int32 )
            value.XformClipPages                            = (Color32)GetInt32(new IntPtr(p + 0x068)); // 0x68 XformClipPages              ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.Ids                                       = (Color32)GetInt32(new IntPtr(p + 0x06C)); // 0x6C Ids                         ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.AddFlags                                  = (Color32)GetInt32(new IntPtr(p + 0x070)); // 0x70 AddFlags                    ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.OpacityPage                               = (Color32)GetInt32(new IntPtr(p + 0x074)); // 0x74 OpacityPage                 ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.TextCoreSettingsPage                      = (Color32)GetInt32(new IntPtr(p + 0x078)); // 0x78 TextCoreSettingsPage        ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.IsText                                    = GetInt32(new IntPtr(p + 0x07C)); // 0x7C IsText                      ( ModelPrimitiveType int int int Int32 )
            value.TextureId                                 = GetSingle(new IntPtr(p + 0x080)); // 0x80 TextureId                   ( ModelPrimitiveType float float float Single )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x098)); // 0x98 IndexCount                  ( ModelPrimitiveType int int int Int32 )
            value.IndexOffset                               = GetInt32(new IntPtr(p + 0x09C)); // 0x9C IndexOffset                 ( ModelPrimitiveType int int int Int32 )
            value.FlipIndices                               = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 FlipIndices                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
