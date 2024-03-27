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
    // 038 UseUserShader                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C CodecType                                0001865C0BD0 ModelEnumType CodecType CodecType CodecType Int32
    // 040 MovieTextureST                           0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 050 MovieChromaTextureST                     0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 060 TextureY                                 000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 068 TextureU                                 000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 070 TextureV                                 000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 078 TextureA                                 000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 080 nativeTextures                           <int>[] IL2CPP_TYPE_SZARRAY
    // 088 CurrentTextureSet                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 08C DrawTextureSet                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 090 PlayerID                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 094 HasTextureUpdated                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 095 IsTextureReady                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 096 HasRenderedNewFrame                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 097 IsStoppingForSeek                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RendererResourceSofdecPrimeYuv
    {
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }
        public bool                                     UseUserShader                           { get; set; }
        public CodecType                                CodecType                               { get; set; }
        public Vector4                                  MovieTextureST                          { get; set; }
        public Vector4                                  MovieChromaTextureST                    { get; set; }
        public List<Texture2D>?                         TextureY                                { get; set; }
        public List<Texture2D>?                         TextureU                                { get; set; }
        public List<Texture2D>?                         TextureV                                { get; set; }
        public List<Texture2D>?                         TextureA                                { get; set; }
        public int                                      CurrentTextureSet                       { get; set; }
        public int                                      DrawTextureSet                          { get; set; }
        public int                                      PlayerID                                { get; set; }
        public bool                                     HasTextureUpdated                       { get; set; }
        public bool                                     IsTextureReady                          { get; set; }
        public bool                                     HasRenderedNewFrame                     { get; set; }
        public bool                                     IsStoppingForSeek                       { get; set; }

        public static RendererResourceSofdecPrimeYuv? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererResourceSofdecPrimeYuv();

            value.Width                                     = GetInt32(new IntPtr(p + 0x030)); // 027004A43E58 0x30 Width                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x034)); // 027004A43E78 0x34 Height                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UseUserShader                             = GetBool(new IntPtr(p + 0x038)); // 027004A43E98 0x38 UseUserShader               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CodecType                                 = (CodecType)GetInt32(new IntPtr(p + 0x03C)); // 027004A43EB8 0x3C CodecType                   ( 0001865C0BD0 ModelEnumType CodecType CodecType CodecType Int32 )
            value.MovieTextureST                            = (Vector4)GetInt32(new IntPtr(p + 0x040)); // 027004A43ED8 0x40 MovieTextureST              ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.MovieChromaTextureST                      = (Vector4)GetInt32(new IntPtr(p + 0x050)); // 027004A43EF8 0x50 MovieChromaTextureST        ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.TextureY                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x060), ReversePrism.DataModels.Texture2D.FromPointer); // 027004A43F18 0x60 TextureY                    ( 000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.TextureU                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x068), ReversePrism.DataModels.Texture2D.FromPointer); // 027004A43F38 0x68 TextureU                    ( 000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.TextureV                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x070), ReversePrism.DataModels.Texture2D.FromPointer); // 027004A43F58 0x70 TextureV                    ( 000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.TextureA                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x078), ReversePrism.DataModels.Texture2D.FromPointer); // 027004A43F78 0x78 TextureA                    ( 000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.CurrentTextureSet                         = GetInt32(new IntPtr(p + 0x088)); // 027004A43FB8 0x88 CurrentTextureSet           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DrawTextureSet                            = GetInt32(new IntPtr(p + 0x08C)); // 027004A43FD8 0x8C DrawTextureSet              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PlayerID                                  = GetInt32(new IntPtr(p + 0x090)); // 027004A43FF8 0x90 PlayerID                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HasTextureUpdated                         = GetBool(new IntPtr(p + 0x094)); // 027004A44018 0x94 HasTextureUpdated           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsTextureReady                            = GetBool(new IntPtr(p + 0x095)); // 027004A44038 0x95 IsTextureReady              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasRenderedNewFrame                       = GetBool(new IntPtr(p + 0x096)); // 027004A44058 0x96 HasRenderedNewFrame         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsStoppingForSeek                         = GetBool(new IntPtr(p + 0x097)); // 027004A44078 0x97 IsStoppingForSeek           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
