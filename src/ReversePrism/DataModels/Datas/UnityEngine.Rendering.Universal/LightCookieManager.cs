using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_DirLightProj                           Matrix4x4 IL2CPP_TYPE_VALUETYPE
    // 010 M_AdditionalLightsCookieAtlas            ModelClassType Texture2DAtlas Texture2DAtlas Texture2DAtlas Pointer
    // 018 M_AdditionalLightsCookieShaderData       ModelClassType LightCookieShaderData LightCookieShaderData LightCookieShaderData Pointer
    // 020 M_Settings                               ModelEnumType Settings Settings Settings Int32
    // 040 M_WorkMem                                ModelClassType WorkMemory WorkMemory WorkMemory Pointer
    // 048 M_VisibleLightIndexToShaderDataIndex     ModelPrimitiveListType int[] int[] List<int> Pointer
    // 000 k_MaxCookieSizeDivisor                   int IL2CPP_TYPE_I4
    // 050 M_CookieSizeDivisor                      ModelPrimitiveType int int int Int32
    // 054 M_PrevCookieRequestPixelCount            ModelPrimitiveType uint uint uint UInt32
    // 058 M_PrevWarnFrame                          ModelPrimitiveType int int int Int32
    // 05C IsKeywordLightCookieEnabled              ModelPrimitiveType bool bool bool Bool
    public partial class LightCookieManager : DataModel
    {
        public Texture2DAtlas?                          M_AdditionalLightsCookieAtlas           { get; set; }
        public LightCookieShaderData?                   M_AdditionalLightsCookieShaderData      { get; set; }
        public Settings                                 M_Settings                              { get; set; }
        public WorkMemory?                              M_WorkMem                               { get; set; }
        public List<int>?                               M_VisibleLightIndexToShaderDataIndex    { get; set; }
        public int                                      M_CookieSizeDivisor                     { get; set; }
        public uint                                     M_PrevCookieRequestPixelCount           { get; set; }
        public int                                      M_PrevWarnFrame                         { get; set; }
        public bool                                     IsKeywordLightCookieEnabled             { get; set; }

        public static LightCookieManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightCookieManager() { Pointer= p0 };

            value.M_AdditionalLightsCookieAtlas             = GetObject<Texture2DAtlas>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture2DAtlas.FromPointer); // 0x10 M_AdditionalLightsCookieAtlas ( ModelClassType Texture2DAtlas Texture2DAtlas Texture2DAtlas Pointer )
            value.M_AdditionalLightsCookieShaderData        = GetObject<LightCookieShaderData>(new IntPtr(p + 0x018), ReversePrism.DataModels.LightCookieShaderData.FromPointer); // 0x18 M_AdditionalLightsCookieShaderData ( ModelClassType LightCookieShaderData LightCookieShaderData LightCookieShaderData Pointer )
            value.M_Settings                                = (Settings)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Settings                  ( ModelEnumType Settings Settings Settings Int32 )
            value.M_WorkMem                                 = GetObject<WorkMemory>(new IntPtr(p + 0x040), ReversePrism.DataModels.WorkMemory.FromPointer); // 0x40 M_WorkMem                   ( ModelClassType WorkMemory WorkMemory WorkMemory Pointer )
            value.M_VisibleLightIndexToShaderDataIndex      = GetInt32List(new IntPtr(p + 0x048)); // 0x48 M_VisibleLightIndexToShaderDataIndex ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_CookieSizeDivisor                       = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_CookieSizeDivisor         ( ModelPrimitiveType int int int Int32 )
            value.M_PrevCookieRequestPixelCount             = GetUInt32(new IntPtr(p + 0x054)); // 0x54 M_PrevCookieRequestPixelCount ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_PrevWarnFrame                           = GetInt32(new IntPtr(p + 0x058)); // 0x58 M_PrevWarnFrame             ( ModelPrimitiveType int int int Int32 )
            value.IsKeywordLightCookieEnabled               = GetBool(new IntPtr(p + 0x05C)); // 0x5C IsKeywordLightCookieEnabled ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
