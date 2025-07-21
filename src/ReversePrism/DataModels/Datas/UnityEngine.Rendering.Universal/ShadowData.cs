using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportsMainLightShadows                 ModelPrimitiveType bool bool bool Bool
    // 011 MainLightShadowsEnabled                  ModelPrimitiveType bool bool bool Bool
    // 012 RequiresScreenSpaceShadowResolve         ModelPrimitiveType bool bool bool Bool
    // 014 MainLightShadowmapWidth                  ModelPrimitiveType int int int Int32
    // 018 MainLightShadowmapHeight                 ModelPrimitiveType int int int Int32
    // 01C MainLightShadowCascadesCount             ModelPrimitiveType int int int Int32
    // 020 MainLightShadowCascadesSplit             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C MainLightShadowCascadeBorder             ModelPrimitiveType float float float Single
    // 030 SupportsAdditionalLightShadows           ModelPrimitiveType bool bool bool Bool
    // 031 AdditionalLightShadowsEnabled            ModelPrimitiveType bool bool bool Bool
    // 034 AdditionalLightsShadowmapWidth           ModelPrimitiveType int int int Int32
    // 038 AdditionalLightsShadowmapHeight          ModelPrimitiveType int int int Int32
    // 03C SupportsSoftShadows                      ModelPrimitiveType bool bool bool Bool
    // 040 ShadowmapDepthBufferBits                 ModelPrimitiveType int int int Int32
    // 048 Bias                                     ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer
    // 050 Resolution                               ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 058 IsKeywordAdditionalLightShadowsEnabled   ModelPrimitiveType bool bool bool Bool
    // 059 IsKeywordSoftShadowsEnabled              ModelPrimitiveType bool bool bool Bool
    public partial class ShadowData : DataModel
    {
        public bool                                     SupportsMainLightShadows                { get; set; }
        public bool                                     MainLightShadowsEnabled                 { get; set; }
        public bool                                     RequiresScreenSpaceShadowResolve        { get; set; }
        public int                                      MainLightShadowmapWidth                 { get; set; }
        public int                                      MainLightShadowmapHeight                { get; set; }
        public int                                      MainLightShadowCascadesCount            { get; set; }
        public Vector3                                  MainLightShadowCascadesSplit            { get; set; }
        public float                                    MainLightShadowCascadeBorder            { get; set; }
        public bool                                     SupportsAdditionalLightShadows          { get; set; }
        public bool                                     AdditionalLightShadowsEnabled           { get; set; }
        public int                                      AdditionalLightsShadowmapWidth          { get; set; }
        public int                                      AdditionalLightsShadowmapHeight         { get; set; }
        public bool                                     SupportsSoftShadows                     { get; set; }
        public int                                      ShadowmapDepthBufferBits                { get; set; }
        public List<Vector4>?                           Bias                                    { get; set; }
        public List<int>?                               Resolution                              { get; set; }
        public bool                                     IsKeywordAdditionalLightShadowsEnabled  { get; set; }
        public bool                                     IsKeywordSoftShadowsEnabled             { get; set; }

        public static ShadowData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShadowData() { Pointer= p0 };

            value.SupportsMainLightShadows                  = GetBool(new IntPtr(p + 0x010)); // 0x10 SupportsMainLightShadows    ( ModelPrimitiveType bool bool bool Bool )
            value.MainLightShadowsEnabled                   = GetBool(new IntPtr(p + 0x011)); // 0x11 MainLightShadowsEnabled     ( ModelPrimitiveType bool bool bool Bool )
            value.RequiresScreenSpaceShadowResolve          = GetBool(new IntPtr(p + 0x012)); // 0x12 RequiresScreenSpaceShadowResolve ( ModelPrimitiveType bool bool bool Bool )
            value.MainLightShadowmapWidth                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 MainLightShadowmapWidth     ( ModelPrimitiveType int int int Int32 )
            value.MainLightShadowmapHeight                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 MainLightShadowmapHeight    ( ModelPrimitiveType int int int Int32 )
            value.MainLightShadowCascadesCount              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MainLightShadowCascadesCount ( ModelPrimitiveType int int int Int32 )
            value.MainLightShadowCascadesSplit              = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 MainLightShadowCascadesSplit ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MainLightShadowCascadeBorder              = GetSingle(new IntPtr(p + 0x02C)); // 0x2C MainLightShadowCascadeBorder ( ModelPrimitiveType float float float Single )
            value.SupportsAdditionalLightShadows            = GetBool(new IntPtr(p + 0x030)); // 0x30 SupportsAdditionalLightShadows ( ModelPrimitiveType bool bool bool Bool )
            value.AdditionalLightShadowsEnabled             = GetBool(new IntPtr(p + 0x031)); // 0x31 AdditionalLightShadowsEnabled ( ModelPrimitiveType bool bool bool Bool )
            value.AdditionalLightsShadowmapWidth            = GetInt32(new IntPtr(p + 0x034)); // 0x34 AdditionalLightsShadowmapWidth ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsShadowmapHeight           = GetInt32(new IntPtr(p + 0x038)); // 0x38 AdditionalLightsShadowmapHeight ( ModelPrimitiveType int int int Int32 )
            value.SupportsSoftShadows                       = GetBool(new IntPtr(p + 0x03C)); // 0x3C SupportsSoftShadows         ( ModelPrimitiveType bool bool bool Bool )
            value.ShadowmapDepthBufferBits                  = GetInt32(new IntPtr(p + 0x040)); // 0x40 ShadowmapDepthBufferBits    ( ModelPrimitiveType int int int Int32 )
            value.Bias                                      = GetEnumList<Vector4>(new IntPtr(p + 0x048)); // 0x48 Bias                        ( ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer )
            value.Resolution                                = GetInt32List(new IntPtr(p + 0x050)); // 0x50 Resolution                  ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.IsKeywordAdditionalLightShadowsEnabled    = GetBool(new IntPtr(p + 0x058)); // 0x58 IsKeywordAdditionalLightShadowsEnabled ( ModelPrimitiveType bool bool bool Bool )
            value.IsKeywordSoftShadowsEnabled               = GetBool(new IntPtr(p + 0x059)); // 0x59 IsKeywordSoftShadowsEnabled ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
