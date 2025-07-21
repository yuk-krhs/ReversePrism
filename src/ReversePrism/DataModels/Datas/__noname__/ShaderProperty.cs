using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 mainLightTexture                         int IL2CPP_TYPE_I4
    // 004 mainLightWorldToLight                    int IL2CPP_TYPE_I4
    // 008 mainLightCookieTextureFormat             int IL2CPP_TYPE_I4
    // 00C additionalLightsCookieAtlasTexture       int IL2CPP_TYPE_I4
    // 010 AdditionalLightsCookieAtlasTextureFormat ModelPrimitiveType int int int Int32
    // 014 AdditionalLightsCookieEnableBits         ModelPrimitiveType int int int Int32
    // 018 AdditionalLightsCookieAtlasUVRectBuffer  ModelPrimitiveType int int int Int32
    // 01C AdditionalLightsCookieAtlasUVRects       ModelPrimitiveType int int int Int32
    // 020 AdditionalLightsWorldToLightBuffer       ModelPrimitiveType int int int Int32
    // 024 AdditionalLightsLightTypeBuffer          ModelPrimitiveType int int int Int32
    // 028 AdditionalLightsWorldToLights            ModelPrimitiveType int int int Int32
    // 02C AdditionalLightsLightTypes               ModelPrimitiveType int int int Int32
    public partial class ShaderProperty : DataModel
    {
        public int                                      AdditionalLightsCookieAtlasTextureFormat { get; set; }
        public int                                      AdditionalLightsCookieEnableBits        { get; set; }
        public int                                      AdditionalLightsCookieAtlasUVRectBuffer { get; set; }
        public int                                      AdditionalLightsCookieAtlasUVRects      { get; set; }
        public int                                      AdditionalLightsWorldToLightBuffer      { get; set; }
        public int                                      AdditionalLightsLightTypeBuffer         { get; set; }
        public int                                      AdditionalLightsWorldToLights           { get; set; }
        public int                                      AdditionalLightsLightTypes              { get; set; }

        public static ShaderProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderProperty() { Pointer= p0 };

            value.AdditionalLightsCookieAtlasTextureFormat  = GetInt32(new IntPtr(p + 0x010)); // 0x10 AdditionalLightsCookieAtlasTextureFormat ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsCookieEnableBits          = GetInt32(new IntPtr(p + 0x014)); // 0x14 AdditionalLightsCookieEnableBits ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsCookieAtlasUVRectBuffer   = GetInt32(new IntPtr(p + 0x018)); // 0x18 AdditionalLightsCookieAtlasUVRectBuffer ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsCookieAtlasUVRects        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C AdditionalLightsCookieAtlasUVRects ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsWorldToLightBuffer        = GetInt32(new IntPtr(p + 0x020)); // 0x20 AdditionalLightsWorldToLightBuffer ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsLightTypeBuffer           = GetInt32(new IntPtr(p + 0x024)); // 0x24 AdditionalLightsLightTypeBuffer ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsWorldToLights             = GetInt32(new IntPtr(p + 0x028)); // 0x28 AdditionalLightsWorldToLights ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsLightTypes                = GetInt32(new IntPtr(p + 0x02C)); // 0x2C AdditionalLightsLightTypes  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
