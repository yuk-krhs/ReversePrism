using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Width                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 Height                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 ChromaWidth                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C ChromaHeight                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 UseUserShader                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 CodecType                                0001865C0BD0 ModelEnumType CodecType CodecType CodecType Int32
    // 048 MovieTextureST                           0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 058 MovieChromaTextureST                     0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 068 textures                                 Texture2D[][] IL2CPP_TYPE_SZARRAY
    // 070 CurrentTextureSet                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 DrawTextureSet                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 nativePixels                             <int>[] IL2CPP_TYPE_SZARRAY
    // 080 PlayerID                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 084 HasTextureUpdated                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 085 IsTextureReady                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 086 HasRenderedNewFrame                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RendererResourceSofdecPrimeYuvRawData
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
            var value   = new RendererResourceSofdecPrimeYuvRawData();

            value.Width                                     = GetInt32(new IntPtr(p + 0x030)); // 0270DAD0AF00 0x30 Width                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x034)); // 0270DAD0AF20 0x34 Height                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChromaWidth                               = GetInt32(new IntPtr(p + 0x038)); // 0270DAD0AF40 0x38 ChromaWidth                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChromaHeight                              = GetInt32(new IntPtr(p + 0x03C)); // 0270DAD0AF60 0x3C ChromaHeight                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UseUserShader                             = GetBool(new IntPtr(p + 0x040)); // 0270DAD0AF80 0x40 UseUserShader               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CodecType                                 = (CodecType)GetInt32(new IntPtr(p + 0x044)); // 0270DAD0AFA0 0x44 CodecType                   ( 0001865C0BD0 ModelEnumType CodecType CodecType CodecType Int32 )
            value.MovieTextureST                            = (Vector4)GetInt32(new IntPtr(p + 0x048)); // 0270DAD0AFC0 0x48 MovieTextureST              ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.MovieChromaTextureST                      = (Vector4)GetInt32(new IntPtr(p + 0x058)); // 0270DAD0AFE0 0x58 MovieChromaTextureST        ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.CurrentTextureSet                         = GetInt32(new IntPtr(p + 0x070)); // 0270DAD0B020 0x70 CurrentTextureSet           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DrawTextureSet                            = GetInt32(new IntPtr(p + 0x074)); // 0270DAD0B040 0x74 DrawTextureSet              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PlayerID                                  = GetInt32(new IntPtr(p + 0x080)); // 0270DAD0B080 0x80 PlayerID                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HasTextureUpdated                         = GetBool(new IntPtr(p + 0x084)); // 0270DAD0B0A0 0x84 HasTextureUpdated           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsTextureReady                            = GetBool(new IntPtr(p + 0x085)); // 0270DAD0B0C0 0x85 IsTextureReady              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasRenderedNewFrame                       = GetBool(new IntPtr(p + 0x086)); // 0270DAD0B0E0 0x86 HasRenderedNewFrame         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
