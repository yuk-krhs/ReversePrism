using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StandardMaterial                         ModelClassType Material Material Material Pointer
    // 018 InitialMaterial                          ModelClassType Material Material Material Pointer
    // 020 MatPropBlock                             ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 028 FirstCommand                             ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 030 Device                                   ModelClassType UIRenderDevice UIRenderDevice UIRenderDevice Pointer
    // 038 VectorAtlas                              ModelClassType Texture Texture Texture Pointer
    // 040 ShaderInfoAtlas                          ModelClassType Texture Texture Texture Pointer
    // 048 DpiScale                                 ModelPrimitiveType float float float Single
    // 050 transformConstants                       NativeSlice`1<Transform3x4> IL2CPP_TYPE_GENERICINST
    // 060 clipRectConstants                        NativeSlice`1<Vector4> IL2CPP_TYPE_GENERICINST
    public partial class RenderNodeData : DataModel
    {
        public Material?                                StandardMaterial                        { get; set; }
        public Material?                                InitialMaterial                         { get; set; }
        public MaterialPropertyBlock?                   MatPropBlock                            { get; set; }
        public RenderChainCommand?                      FirstCommand                            { get; set; }
        public UIRenderDevice?                          Device                                  { get; set; }
        public Texture?                                 VectorAtlas                             { get; set; }
        public Texture?                                 ShaderInfoAtlas                         { get; set; }
        public float                                    DpiScale                                { get; set; }

        public static RenderNodeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderNodeData() { Pointer= p0 };

            value.StandardMaterial                          = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0x10 StandardMaterial            ( ModelClassType Material Material Material Pointer )
            value.InitialMaterial                           = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0x18 InitialMaterial             ( ModelClassType Material Material Material Pointer )
            value.MatPropBlock                              = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x020), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 0x20 MatPropBlock                ( ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.FirstCommand                              = GetObject<RenderChainCommand>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 0x28 FirstCommand                ( ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.Device                                    = GetObject<UIRenderDevice>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRenderDevice.FromPointer); // 0x30 Device                      ( ModelClassType UIRenderDevice UIRenderDevice UIRenderDevice Pointer )
            value.VectorAtlas                               = GetObject<Texture>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture.FromPointer); // 0x38 VectorAtlas                 ( ModelClassType Texture Texture Texture Pointer )
            value.ShaderInfoAtlas                           = GetObject<Texture>(new IntPtr(p + 0x040), ReversePrism.DataModels.Texture.FromPointer); // 0x40 ShaderInfoAtlas             ( ModelClassType Texture Texture Texture Pointer )
            value.DpiScale                                  = GetSingle(new IntPtr(p + 0x048)); // 0x48 DpiScale                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
