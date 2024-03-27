using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_MarkerWrite                            ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 s_MarkerCommit                           ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 M_Length                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 014 M_ElemWidth                              0001865F4260 ModelPrimitiveType int int int Int32
    // 018 M_Allocator                              00018674EA00 ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer
    // 020 M_Atlas                                  000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 028 M_RawAtlas                               00018651B4A0 ModelEnumType RawTexture RawTexture RawTexture Int32
    // 010 S_TextureCounter                         0001865F38E0 ModelPrimitiveType int int int Int32
    // 038 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 MustCommit                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GradientSettingsAtlas
    {
        public int                                      M_Length                                { get; set; }
        public int                                      M_ElemWidth                             { get; set; }
        public BestFitAllocator?                        M_Allocator                             { get; set; }
        public Texture2D?                               M_Atlas                                 { get; set; }
        public RawTexture                               M_RawAtlas                              { get; set; }
        public int                                      S_TextureCounter                        { get; set; }
        public bool                                     Disposed                                { get; set; }
        public bool                                     MustCommit                              { get; set; }

        public static GradientSettingsAtlas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GradientSettingsAtlas();

            value.M_Length                                  = GetInt32(new IntPtr(p + 0x010)); // 027006863C08 0x10 M_Length                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.M_ElemWidth                               = GetInt32(new IntPtr(p + 0x014)); // 027006863C28 0x14 M_ElemWidth                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.M_Allocator                               = GetObject<BestFitAllocator>(new IntPtr(p + 0x018), ReversePrism.DataModels.BestFitAllocator.FromPointer); // 027006863C48 0x18 M_Allocator                 ( 00018674EA00 ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer )
            value.M_Atlas                                   = GetObject<Texture2D>(new IntPtr(p + 0x020), ReversePrism.DataModels.Texture2D.FromPointer); // 027006863C68 0x20 M_Atlas                     ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_RawAtlas                                = (RawTexture)GetInt32(new IntPtr(p + 0x028)); // 027006863C88 0x28 M_RawAtlas                  ( 00018651B4A0 ModelEnumType RawTexture RawTexture RawTexture Int32 )
            value.S_TextureCounter                          = GetInt32(new IntPtr(p + 0x010)); // 027006863CA8 0x10 S_TextureCounter            ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x038)); // 027006863CC8 0x38 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MustCommit                                = GetBool(new IntPtr(p + 0x039)); // 027006863CE8 0x39 MustCommit                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
