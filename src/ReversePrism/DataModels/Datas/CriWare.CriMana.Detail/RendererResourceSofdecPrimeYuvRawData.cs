using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Width                                    ModelPrimitiveType int int int Int32
    // 034 Height                                   ModelPrimitiveType int int int Int32
    // 038 ChromaWidth                              ModelPrimitiveType int int int Int32
    // 03C ChromaHeight                             ModelPrimitiveType int int int Int32
    // 040 UseUserShader                            ModelPrimitiveType bool bool bool Bool
    // 044 CodecType                                ModelEnumType CodecType CodecType CodecType Int32
    // 048 MovieTextureST                           ModelEnumType Vector4 Vector4 Vector4 Int32
    // 058 MovieChromaTextureST                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 068 textures                                 Texture2D[][] IL2CPP_TYPE_SZARRAY
    // 070 CurrentTextureSet                        ModelPrimitiveType int int int Int32
    // 074 DrawTextureSet                           ModelPrimitiveType int int int Int32
    // 078 nativePixels                             <int>[] IL2CPP_TYPE_SZARRAY
    // 080 PlayerID                                 ModelPrimitiveType int int int Int32
    // 084 HasTextureUpdated                        ModelPrimitiveType bool bool bool Bool
    // 085 IsTextureReady                           ModelPrimitiveType bool bool bool Bool
    // 086 HasRenderedNewFrame                      ModelPrimitiveType bool bool bool Bool
    public partial class RendererResourceSofdecPrimeYuvRawData : DataModel
    {
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }
        public int                                      ChromaWidth                             { get; set; }
        public int                                      ChromaHeight                            { get; set; }
        public bool                                     UseUserShader                           { get; set; }
        public CodecType                                CodecType                               { get; set; }
        public Vector4                                  MovieTextureST                          { get; set; }
        public Vector4                                  MovieChromaTextureST                    { get; set; }
        public int                                      CurrentTextureSet                       { get; set; }
        public int                                      DrawTextureSet                          { get; set; }
        public int                                      PlayerID                                { get; set; }
        public bool                                     HasTextureUpdated                       { get; set; }
        public bool                                     IsTextureReady                          { get; set; }
        public bool                                     HasRenderedNewFrame                     { get; set; }

        public static RendererResourceSofdecPrimeYuvRawData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererResourceSofdecPrimeYuvRawData() { Pointer= p0 };

            value.Width                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 Width                       ( ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x034)); // 0x34 Height                      ( ModelPrimitiveType int int int Int32 )
            value.ChromaWidth                               = GetInt32(new IntPtr(p + 0x038)); // 0x38 ChromaWidth                 ( ModelPrimitiveType int int int Int32 )
            value.ChromaHeight                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ChromaHeight                ( ModelPrimitiveType int int int Int32 )
            value.UseUserShader                             = GetBool(new IntPtr(p + 0x040)); // 0x40 UseUserShader               ( ModelPrimitiveType bool bool bool Bool )
            value.CodecType                                 = (CodecType)GetInt32(new IntPtr(p + 0x044)); // 0x44 CodecType                   ( ModelEnumType CodecType CodecType CodecType Int32 )
            value.MovieTextureST                            = (Vector4)GetInt32(new IntPtr(p + 0x048)); // 0x48 MovieTextureST              ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.MovieChromaTextureST                      = (Vector4)GetInt32(new IntPtr(p + 0x058)); // 0x58 MovieChromaTextureST        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.CurrentTextureSet                         = GetInt32(new IntPtr(p + 0x070)); // 0x70 CurrentTextureSet           ( ModelPrimitiveType int int int Int32 )
            value.DrawTextureSet                            = GetInt32(new IntPtr(p + 0x074)); // 0x74 DrawTextureSet              ( ModelPrimitiveType int int int Int32 )
            value.PlayerID                                  = GetInt32(new IntPtr(p + 0x080)); // 0x80 PlayerID                    ( ModelPrimitiveType int int int Int32 )
            value.HasTextureUpdated                         = GetBool(new IntPtr(p + 0x084)); // 0x84 HasTextureUpdated           ( ModelPrimitiveType bool bool bool Bool )
            value.IsTextureReady                            = GetBool(new IntPtr(p + 0x085)); // 0x85 IsTextureReady              ( ModelPrimitiveType bool bool bool Bool )
            value.HasRenderedNewFrame                       = GetBool(new IntPtr(p + 0x086)); // 0x86 HasRenderedNewFrame         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
