using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 CustomSampler                            0001865CD0D0 ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 028 EnableAsyncCompute                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 AllowPassCulling                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C DepthBuffer                              0001866873B0 ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 038 ColorBuffers                             000185CAB5B8 ModelEnumListType TextureHandle[] TextureHandle[] List<TextureHandle> Pointer
    // 040 ColorBufferMaxIndex                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 RefCount                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 GenerateDebugData                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 AllowRendererListCulling                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 resourceReadLists                        List`1<ResourceHandle>[] IL2CPP_TYPE_SZARRAY
    // 058 resourceWriteLists                       List`1<ResourceHandle>[] IL2CPP_TYPE_SZARRAY
    // 060 transientResourceList                    List`1<ResourceHandle>[] IL2CPP_TYPE_SZARRAY
    // 068 UsedRendererListList                     000185D02868 ModelEnumListType List`1<RendererListHandle> List`1<RendererListHandle> List<RendererListHandle> Pointer
    public partial class RenderGraphPass
    {
        public string                                   Name                                    { get; set; }
        public int                                      Index                                   { get; set; }
        public ProfilingSampler?                        CustomSampler                           { get; set; }
        public bool                                     EnableAsyncCompute                      { get; set; }
        public bool                                     AllowPassCulling                        { get; set; }
        public TextureHandle                            DepthBuffer                             { get; set; }
        public List<TextureHandle>?                     ColorBuffers                            { get; set; }
        public int                                      ColorBufferMaxIndex                     { get; set; }
        public int                                      RefCount                                { get; set; }
        public bool                                     GenerateDebugData                       { get; set; }
        public bool                                     AllowRendererListCulling                { get; set; }
        public List<RendererListHandle>?                UsedRendererListList                    { get; set; }

        public static RenderGraphPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphPass();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D90950D0 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D90950F0 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CustomSampler                             = GetObject<ProfilingSampler>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0270D9095110 0x20 CustomSampler               ( 0001865CD0D0 ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.EnableAsyncCompute                        = GetBool(new IntPtr(p + 0x028)); // 0270D9095130 0x28 EnableAsyncCompute          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AllowPassCulling                          = GetBool(new IntPtr(p + 0x029)); // 0270D9095150 0x29 AllowPassCulling            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DepthBuffer                               = (TextureHandle)GetInt32(new IntPtr(p + 0x02C)); // 0270D9095170 0x2C DepthBuffer                 ( 0001866873B0 ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.ColorBuffers                              = GetEnumList<TextureHandle>(new IntPtr(p + 0x038)); // 0270D9095190 0x38 ColorBuffers                ( 000185CAB5B8 ModelEnumListType TextureHandle[] TextureHandle[] List<TextureHandle> Pointer )
            value.ColorBufferMaxIndex                       = GetInt32(new IntPtr(p + 0x040)); // 0270D90951B0 0x40 ColorBufferMaxIndex         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x044)); // 0270D90951D0 0x44 RefCount                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GenerateDebugData                         = GetBool(new IntPtr(p + 0x048)); // 0270D90951F0 0x48 GenerateDebugData           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AllowRendererListCulling                  = GetBool(new IntPtr(p + 0x049)); // 0270D9095210 0x49 AllowRendererListCulling    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UsedRendererListList                      = GetEnumList<RendererListHandle>(new IntPtr(p + 0x068)); // 0270D9095290 0x68 UsedRendererListList        ( 000185D02868 ModelEnumListType List`1<RendererListHandle> List`1<RendererListHandle> List<RendererListHandle> Pointer )

            return value;
        }
    }
}
