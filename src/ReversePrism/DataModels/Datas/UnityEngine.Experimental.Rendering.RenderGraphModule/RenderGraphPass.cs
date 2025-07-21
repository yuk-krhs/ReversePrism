using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 020 CustomSampler                            ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 028 EnableAsyncCompute                       ModelPrimitiveType bool bool bool Bool
    // 029 AllowPassCulling                         ModelPrimitiveType bool bool bool Bool
    // 02C DepthBuffer                              ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 038 ColorBuffers                             ModelEnumListType TextureHandle[] TextureHandle[] List<TextureHandle> Pointer
    // 040 ColorBufferMaxIndex                      ModelPrimitiveType int int int Int32
    // 044 RefCount                                 ModelPrimitiveType int int int Int32
    // 048 GenerateDebugData                        ModelPrimitiveType bool bool bool Bool
    // 049 AllowRendererListCulling                 ModelPrimitiveType bool bool bool Bool
    // 050 resourceReadLists                        List`1<ResourceHandle>[] IL2CPP_TYPE_SZARRAY
    // 058 resourceWriteLists                       List`1<ResourceHandle>[] IL2CPP_TYPE_SZARRAY
    // 060 transientResourceList                    List`1<ResourceHandle>[] IL2CPP_TYPE_SZARRAY
    // 068 UsedRendererListList                     ModelEnumListType List`1<RendererListHandle> List`1<RendererListHandle> List<RendererListHandle> Pointer
    public partial class RenderGraphPass : DataModel
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
            var value   = new RenderGraphPass() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.CustomSampler                             = GetObject<ProfilingSampler>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x20 CustomSampler               ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.EnableAsyncCompute                        = GetBool(new IntPtr(p + 0x028)); // 0x28 EnableAsyncCompute          ( ModelPrimitiveType bool bool bool Bool )
            value.AllowPassCulling                          = GetBool(new IntPtr(p + 0x029)); // 0x29 AllowPassCulling            ( ModelPrimitiveType bool bool bool Bool )
            value.DepthBuffer                               = (TextureHandle)GetInt32(new IntPtr(p + 0x02C)); // 0x2C DepthBuffer                 ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.ColorBuffers                              = GetEnumList<TextureHandle>(new IntPtr(p + 0x038)); // 0x38 ColorBuffers                ( ModelEnumListType TextureHandle[] TextureHandle[] List<TextureHandle> Pointer )
            value.ColorBufferMaxIndex                       = GetInt32(new IntPtr(p + 0x040)); // 0x40 ColorBufferMaxIndex         ( ModelPrimitiveType int int int Int32 )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x044)); // 0x44 RefCount                    ( ModelPrimitiveType int int int Int32 )
            value.GenerateDebugData                         = GetBool(new IntPtr(p + 0x048)); // 0x48 GenerateDebugData           ( ModelPrimitiveType bool bool bool Bool )
            value.AllowRendererListCulling                  = GetBool(new IntPtr(p + 0x049)); // 0x49 AllowRendererListCulling    ( ModelPrimitiveType bool bool bool Bool )
            value.UsedRendererListList                      = GetEnumList<RendererListHandle>(new IntPtr(p + 0x068)); // 0x68 UsedRendererListList        ( ModelEnumListType List`1<RendererListHandle> List`1<RendererListHandle> List<RendererListHandle> Pointer )

            return value;
        }
    }
}
