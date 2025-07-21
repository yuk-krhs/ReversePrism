using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_IsValid                                ModelPrimitiveType bool bool bool Bool
    // 018 M_BlackTexture2D                         ModelClassType RTHandle RTHandle RTHandle Pointer
    // 020 M_WhiteTexture2D                         ModelClassType RTHandle RTHandle RTHandle Pointer
    // 028 M_ShadowTexture2D                        ModelClassType RTHandle RTHandle RTHandle Pointer
    // 030 BlackTexture                             ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 038 WhiteTexture                             ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 040 ClearTextureXR                           ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 048 MagentaTextureXR                         ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 050 BlackTextureXR                           ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 058 BlackTextureArrayXR                      ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 060 BlackUIntTextureXR                       ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 068 BlackTexture3DXR                         ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 070 WhiteTextureXR                           ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 078 DefaultShadowTexture                     ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    public partial class RenderGraphDefaultResources : DataModel
    {
        public bool                                     M_IsValid                               { get; set; }
        public RTHandle?                                M_BlackTexture2D                        { get; set; }
        public RTHandle?                                M_WhiteTexture2D                        { get; set; }
        public RTHandle?                                M_ShadowTexture2D                       { get; set; }
        public TextureHandle                            BlackTexture                            { get; set; }
        public TextureHandle                            WhiteTexture                            { get; set; }
        public TextureHandle                            ClearTextureXR                          { get; set; }
        public TextureHandle                            MagentaTextureXR                        { get; set; }
        public TextureHandle                            BlackTextureXR                          { get; set; }
        public TextureHandle                            BlackTextureArrayXR                     { get; set; }
        public TextureHandle                            BlackUIntTextureXR                      { get; set; }
        public TextureHandle                            BlackTexture3DXR                        { get; set; }
        public TextureHandle                            WhiteTextureXR                          { get; set; }
        public TextureHandle                            DefaultShadowTexture                    { get; set; }

        public static RenderGraphDefaultResources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphDefaultResources() { Pointer= p0 };

            value.M_IsValid                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 M_IsValid                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_BlackTexture2D                          = GetObject<RTHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.RTHandle.FromPointer); // 0x18 M_BlackTexture2D            ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_WhiteTexture2D                          = GetObject<RTHandle>(new IntPtr(p + 0x020), ReversePrism.DataModels.RTHandle.FromPointer); // 0x20 M_WhiteTexture2D            ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_ShadowTexture2D                         = GetObject<RTHandle>(new IntPtr(p + 0x028), ReversePrism.DataModels.RTHandle.FromPointer); // 0x28 M_ShadowTexture2D           ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.BlackTexture                              = (TextureHandle)GetInt32(new IntPtr(p + 0x030)); // 0x30 BlackTexture                ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.WhiteTexture                              = (TextureHandle)GetInt32(new IntPtr(p + 0x038)); // 0x38 WhiteTexture                ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.ClearTextureXR                            = (TextureHandle)GetInt32(new IntPtr(p + 0x040)); // 0x40 ClearTextureXR              ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.MagentaTextureXR                          = (TextureHandle)GetInt32(new IntPtr(p + 0x048)); // 0x48 MagentaTextureXR            ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.BlackTextureXR                            = (TextureHandle)GetInt32(new IntPtr(p + 0x050)); // 0x50 BlackTextureXR              ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.BlackTextureArrayXR                       = (TextureHandle)GetInt32(new IntPtr(p + 0x058)); // 0x58 BlackTextureArrayXR         ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.BlackUIntTextureXR                        = (TextureHandle)GetInt32(new IntPtr(p + 0x060)); // 0x60 BlackUIntTextureXR          ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.BlackTexture3DXR                          = (TextureHandle)GetInt32(new IntPtr(p + 0x068)); // 0x68 BlackTexture3DXR            ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.WhiteTextureXR                            = (TextureHandle)GetInt32(new IntPtr(p + 0x070)); // 0x70 WhiteTextureXR              ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.DefaultShadowTexture                      = (TextureHandle)GetInt32(new IntPtr(p + 0x078)); // 0x78 DefaultShadowTexture        ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )

            return value;
        }
    }
}
