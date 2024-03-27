using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StandardMaterial                         00018660C4B0 ModelClassType Material Material Material Pointer
    // 018 InitialMaterial                          00018660C4B0 ModelClassType Material Material Material Pointer
    // 020 MatPropBlock                             0001865E1260 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 028 FirstCommand                             0001866549D0 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 030 Device                                   0001866F0780 ModelClassType UIRenderDevice UIRenderDevice UIRenderDevice Pointer
    // 038 VectorAtlas                              00018664D720 ModelClassType Texture Texture Texture Pointer
    // 040 ShaderInfoAtlas                          00018664D720 ModelClassType Texture Texture Texture Pointer
    // 048 DpiScale                                 000186666050 ModelPrimitiveType float float float Single
    // 050 transformConstants                       NativeSlice`1<Transform3x4> IL2CPP_TYPE_GENERICINST
    // 060 clipRectConstants                        NativeSlice`1<Vector4> IL2CPP_TYPE_GENERICINST
    public partial class RenderNodeData
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
            var value   = new RenderNodeData();

            value.StandardMaterial                          = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 027006870CA8 0x10 StandardMaterial            ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.InitialMaterial                           = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 027006870CC8 0x18 InitialMaterial             ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.MatPropBlock                              = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x020), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 027006870CE8 0x20 MatPropBlock                ( 0001865E1260 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.FirstCommand                              = GetObject<RenderChainCommand>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 027006870D08 0x28 FirstCommand                ( 0001866549D0 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.Device                                    = GetObject<UIRenderDevice>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRenderDevice.FromPointer); // 027006870D28 0x30 Device                      ( 0001866F0780 ModelClassType UIRenderDevice UIRenderDevice UIRenderDevice Pointer )
            value.VectorAtlas                               = GetObject<Texture>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture.FromPointer); // 027006870D48 0x38 VectorAtlas                 ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.ShaderInfoAtlas                           = GetObject<Texture>(new IntPtr(p + 0x040), ReversePrism.DataModels.Texture.FromPointer); // 027006870D68 0x40 ShaderInfoAtlas             ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.DpiScale                                  = GetSingle(new IntPtr(p + 0x048)); // 027006870D88 0x48 DpiScale                    ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
