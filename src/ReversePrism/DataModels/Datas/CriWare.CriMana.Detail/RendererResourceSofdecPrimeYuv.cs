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
    // 038 UseUserShader                            ModelPrimitiveType bool bool bool Bool
    // 03C CodecType                                ModelEnumType CodecType CodecType CodecType Int32
    // 040 MovieTextureST                           ModelEnumType Vector4 Vector4 Vector4 Int32
    // 050 MovieChromaTextureST                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 060 TextureY                                 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 068 TextureU                                 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 070 TextureV                                 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 078 TextureA                                 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 080 nativeTextures                           <int>[] IL2CPP_TYPE_SZARRAY
    // 088 CurrentTextureSet                        ModelPrimitiveType int int int Int32
    // 08C DrawTextureSet                           ModelPrimitiveType int int int Int32
    // 090 PlayerID                                 ModelPrimitiveType int int int Int32
    // 094 HasTextureUpdated                        ModelPrimitiveType bool bool bool Bool
    // 095 IsTextureReady                           ModelPrimitiveType bool bool bool Bool
    // 096 HasRenderedNewFrame                      ModelPrimitiveType bool bool bool Bool
    // 097 IsStoppingForSeek                        ModelPrimitiveType bool bool bool Bool
    public partial class RendererResourceSofdecPrimeYuv : DataModel
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
            var value   = new RendererResourceSofdecPrimeYuv() { Pointer= p0 };

            value.Width                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 Width                       ( ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x034)); // 0x34 Height                      ( ModelPrimitiveType int int int Int32 )
            value.UseUserShader                             = GetBool(new IntPtr(p + 0x038)); // 0x38 UseUserShader               ( ModelPrimitiveType bool bool bool Bool )
            value.CodecType                                 = (CodecType)GetInt32(new IntPtr(p + 0x03C)); // 0x3C CodecType                   ( ModelEnumType CodecType CodecType CodecType Int32 )
            value.MovieTextureST                            = (Vector4)GetInt32(new IntPtr(p + 0x040)); // 0x40 MovieTextureST              ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.MovieChromaTextureST                      = (Vector4)GetInt32(new IntPtr(p + 0x050)); // 0x50 MovieChromaTextureST        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.TextureY                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x060), ReversePrism.DataModels.Texture2D.FromPointer); // 0x60 TextureY                    ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.TextureU                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x068), ReversePrism.DataModels.Texture2D.FromPointer); // 0x68 TextureU                    ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.TextureV                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x070), ReversePrism.DataModels.Texture2D.FromPointer); // 0x70 TextureV                    ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.TextureA                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x078), ReversePrism.DataModels.Texture2D.FromPointer); // 0x78 TextureA                    ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.CurrentTextureSet                         = GetInt32(new IntPtr(p + 0x088)); // 0x88 CurrentTextureSet           ( ModelPrimitiveType int int int Int32 )
            value.DrawTextureSet                            = GetInt32(new IntPtr(p + 0x08C)); // 0x8C DrawTextureSet              ( ModelPrimitiveType int int int Int32 )
            value.PlayerID                                  = GetInt32(new IntPtr(p + 0x090)); // 0x90 PlayerID                    ( ModelPrimitiveType int int int Int32 )
            value.HasTextureUpdated                         = GetBool(new IntPtr(p + 0x094)); // 0x94 HasTextureUpdated           ( ModelPrimitiveType bool bool bool Bool )
            value.IsTextureReady                            = GetBool(new IntPtr(p + 0x095)); // 0x95 IsTextureReady              ( ModelPrimitiveType bool bool bool Bool )
            value.HasRenderedNewFrame                       = GetBool(new IntPtr(p + 0x096)); // 0x96 HasRenderedNewFrame         ( ModelPrimitiveType bool bool bool Bool )
            value.IsStoppingForSeek                         = GetBool(new IntPtr(p + 0x097)); // 0x97 IsStoppingForSeek           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
