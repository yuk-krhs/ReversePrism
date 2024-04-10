using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_TmpSoftMasks                           List`1<SoftMask>[] IL2CPP_TYPE_SZARRAY
    // 008 s_ClearColors                            Color[] IL2CPP_TYPE_SZARRAY
    // 010 S_UVStartsAtTop                          000186595C30 ModelPrimitiveType bool bool bool Bool
    // 011 S_IsMetal                                000186595C30 ModelPrimitiveType bool bool bool Bool
    // 018 S_SoftMaskShader                         00018674CE60 ModelClassType Shader Shader Shader Pointer
    // 020 S_ReadTexture                            000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 028 S_ActiveSoftMasks                        000185D0A468 ModelClassListType List`1<SoftMask> List`1<SoftMask> List<SoftMask> Pointer
    // 030 S_TempRelatables                         000185D0A468 ModelClassListType List`1<SoftMask> List`1<SoftMask> List<SoftMask> Pointer
    // 038 s_PreviousViewProjectionMatrices         Dictionary`2<int, Matrix4x4> IL2CPP_TYPE_GENERICINST
    // 040 s_NowViewProjectionMatrices              Dictionary`2<int, Matrix4x4> IL2CPP_TYPE_GENERICINST
    // 048 S_StencilCompId                          0001865F38E0 ModelPrimitiveType int int int Int32
    // 04C S_ColorMaskId                            0001865F38E0 ModelPrimitiveType int int int Int32
    // 050 S_MainTexId                              0001865F38E0 ModelPrimitiveType int int int Int32
    // 054 S_SoftnessId                             0001865F38E0 ModelPrimitiveType int int int Int32
    // 058 S_Alpha                                  0001865F38E0 ModelPrimitiveType int int int Int32
    // 05C S_PreviousWidth                          0001865F38E0 ModelPrimitiveType int int int Int32
    // 060 S_PreviousHeight                         0001865F38E0 ModelPrimitiveType int int int Int32
    // 048 Mpb                                      0001865E0FC0 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 050 Cb                                       0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 058 Material                                 00018660BDD0 ModelClassType Material Material Material Pointer
    // 060 SoftMaskBuffer                           000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 068 StencilDepth                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 Mesh                                     0001866104D0 ModelClassType Mesh Mesh Mesh Pointer
    // 078 Parent                                   000186526680 ModelClassType SoftMask SoftMask SoftMask Pointer
    // 080 Children                                 000185D0A3C8 ModelClassListType List`1<SoftMask> List`1<SoftMask> List<SoftMask> Pointer
    // 088 HasChanged                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 089 HasStencilStateChanged                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 08C M_DownSamplingRate                       0001865462E0 ModelEnumType DownSamplingRate DownSamplingRate DownSamplingRate Int32
    // 090 M_Softness                               0001866656B0 ModelPrimitiveType float float float Single
    // 094 M_Alpha                                  0001866656B0 ModelPrimitiveType float float float Single
    // 098 M_IgnoreParent                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 099 M_PartOfParent                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09A M_IgnoreSelfGraphic                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09B M_IgnoreSelfStencil                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SoftMask : DataModel
    {
        public bool                                     S_UVStartsAtTop                         { get; set; }
        public bool                                     S_IsMetal                               { get; set; }
        public Shader?                                  S_SoftMaskShader                        { get; set; }
        public Texture2D?                               S_ReadTexture                           { get; set; }
        public List<SoftMask>?                          S_ActiveSoftMasks                       { get; set; }
        public List<SoftMask>?                          S_TempRelatables                        { get; set; }
        public int                                      S_StencilCompId                         { get; set; }
        public int                                      S_ColorMaskId                           { get; set; }
        public int                                      S_MainTexId                             { get; set; }
        public int                                      S_SoftnessId                            { get; set; }
        public int                                      S_Alpha                                 { get; set; }
        public int                                      S_PreviousWidth                         { get; set; }
        public int                                      S_PreviousHeight                        { get; set; }
        public MaterialPropertyBlock?                   Mpb                                     { get; set; }
        public CommandBuffer?                           Cb                                      { get; set; }
        public Material?                                Material                                { get; set; }
        public RenderTexture?                           SoftMaskBuffer                          { get; set; }
        public int                                      StencilDepth                            { get; set; }
        public Mesh?                                    Mesh                                    { get; set; }
        public SoftMask?                                Parent                                  { get; set; }
        public List<SoftMask>?                          Children                                { get; set; }
        public bool                                     HasChanged                              { get; set; }
        public bool                                     HasStencilStateChanged                  { get; set; }
        public DownSamplingRate                         M_DownSamplingRate                      { get; set; }
        public float                                    M_Softness                              { get; set; }
        public float                                    M_Alpha                                 { get; set; }
        public bool                                     M_IgnoreParent                          { get; set; }
        public bool                                     M_PartOfParent                          { get; set; }
        public bool                                     M_IgnoreSelfGraphic                     { get; set; }
        public bool                                     M_IgnoreSelfStencil                     { get; set; }

        public static SoftMask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoftMask() { Pointer= p0 };

            value.S_UVStartsAtTop                           = GetBool(new IntPtr(p + 0x010)); // 02466BE888C0 0x10 S_UVStartsAtTop             ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.S_IsMetal                                 = GetBool(new IntPtr(p + 0x011)); // 02466BE888E0 0x11 S_IsMetal                   ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.S_SoftMaskShader                          = GetObject<Shader>(new IntPtr(p + 0x018), ReversePrism.DataModels.Shader.FromPointer); // 02466BE88900 0x18 S_SoftMaskShader            ( 00018674CE60 ModelClassType Shader Shader Shader Pointer )
            value.S_ReadTexture                             = GetObject<Texture2D>(new IntPtr(p + 0x020), ReversePrism.DataModels.Texture2D.FromPointer); // 02466BE88920 0x20 S_ReadTexture               ( 000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.S_ActiveSoftMasks                         = GetObjectList<SoftMask>(new IntPtr(p + 0x028), ReversePrism.DataModels.SoftMask.FromPointer); // 02466BE88940 0x28 S_ActiveSoftMasks           ( 000185D0A468 ModelClassListType List`1<SoftMask> List`1<SoftMask> List<SoftMask> Pointer )
            value.S_TempRelatables                          = GetObjectList<SoftMask>(new IntPtr(p + 0x030), ReversePrism.DataModels.SoftMask.FromPointer); // 02466BE88960 0x30 S_TempRelatables            ( 000185D0A468 ModelClassListType List`1<SoftMask> List`1<SoftMask> List<SoftMask> Pointer )
            value.S_StencilCompId                           = GetInt32(new IntPtr(p + 0x048)); // 02466BE889C0 0x48 S_StencilCompId             ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_ColorMaskId                             = GetInt32(new IntPtr(p + 0x04C)); // 02466BE889E0 0x4C S_ColorMaskId               ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_MainTexId                               = GetInt32(new IntPtr(p + 0x050)); // 02466BE88A00 0x50 S_MainTexId                 ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_SoftnessId                              = GetInt32(new IntPtr(p + 0x054)); // 02466BE88A20 0x54 S_SoftnessId                ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_Alpha                                   = GetInt32(new IntPtr(p + 0x058)); // 02466BE88A40 0x58 S_Alpha                     ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_PreviousWidth                           = GetInt32(new IntPtr(p + 0x05C)); // 02466BE88A60 0x5C S_PreviousWidth             ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_PreviousHeight                          = GetInt32(new IntPtr(p + 0x060)); // 02466BE88A80 0x60 S_PreviousHeight            ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.Mpb                                       = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x048), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 02466BE88AA0 0x48 Mpb                         ( 0001865E0FC0 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.Cb                                        = GetObject<CommandBuffer>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommandBuffer.FromPointer); // 02466BE88AC0 0x50 Cb                          ( 0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x058), ReversePrism.DataModels.Material.FromPointer); // 02466BE88AE0 0x58 Material                    ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.SoftMaskBuffer                            = GetObject<RenderTexture>(new IntPtr(p + 0x060), ReversePrism.DataModels.RenderTexture.FromPointer); // 02466BE88B00 0x60 SoftMaskBuffer              ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.StencilDepth                              = GetInt32(new IntPtr(p + 0x068)); // 02466BE88B20 0x68 StencilDepth                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Mesh                                      = GetObject<Mesh>(new IntPtr(p + 0x070), ReversePrism.DataModels.Mesh.FromPointer); // 02466BE88B40 0x70 Mesh                        ( 0001866104D0 ModelClassType Mesh Mesh Mesh Pointer )
            value.Parent                                    = GetObject<SoftMask>(new IntPtr(p + 0x078), ReversePrism.DataModels.SoftMask.FromPointer); // 02466BE88B60 0x78 Parent                      ( 000186526680 ModelClassType SoftMask SoftMask SoftMask Pointer )
            value.Children                                  = GetObjectList<SoftMask>(new IntPtr(p + 0x080), ReversePrism.DataModels.SoftMask.FromPointer); // 02466BE88B80 0x80 Children                    ( 000185D0A3C8 ModelClassListType List`1<SoftMask> List`1<SoftMask> List<SoftMask> Pointer )
            value.HasChanged                                = GetBool(new IntPtr(p + 0x088)); // 02466BE88BA0 0x88 HasChanged                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasStencilStateChanged                    = GetBool(new IntPtr(p + 0x089)); // 02466BE88BC0 0x89 HasStencilStateChanged      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DownSamplingRate                        = (DownSamplingRate)GetInt32(new IntPtr(p + 0x08C)); // 02466BE88BE0 0x8C M_DownSamplingRate          ( 0001865462E0 ModelEnumType DownSamplingRate DownSamplingRate DownSamplingRate Int32 )
            value.M_Softness                                = GetSingle(new IntPtr(p + 0x090)); // 02466BE88C00 0x90 M_Softness                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Alpha                                   = GetSingle(new IntPtr(p + 0x094)); // 02466BE88C20 0x94 M_Alpha                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_IgnoreParent                            = GetBool(new IntPtr(p + 0x098)); // 02466BE88C40 0x98 M_IgnoreParent              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PartOfParent                            = GetBool(new IntPtr(p + 0x099)); // 02466BE88C60 0x99 M_PartOfParent              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IgnoreSelfGraphic                       = GetBool(new IntPtr(p + 0x09A)); // 02466BE88C80 0x9A M_IgnoreSelfGraphic         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IgnoreSelfStencil                       = GetBool(new IntPtr(p + 0x09B)); // 02466BE88CA0 0x9B M_IgnoreSelfStencil         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
