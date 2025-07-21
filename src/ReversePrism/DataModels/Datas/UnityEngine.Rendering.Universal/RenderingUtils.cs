using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_LegacyShaderPassNames                  List`1<ShaderTagId> IL2CPP_TYPE_GENERICINST
    // 008 s_EmptyAttachment                        AttachmentDescriptor IL2CPP_TYPE_VALUETYPE
    // 080 S_FullscreenMesh                         ModelClassType Mesh Mesh Mesh Pointer
    // 088 S_ErrorMaterial                          ModelClassType Material Material Material Pointer
    // 090 m_RenderTextureFormatSupport             Dictionary`2<RenderTextureFormat, bool> IL2CPP_TYPE_GENERICINST
    // 098 m_GraphicsFormatSupport                  Dictionary`2<GraphicsFormat, Dictionary`2<FormatUsage, bool>> IL2CPP_TYPE_GENERICINST
    public partial class RenderingUtils : DataModel
    {
        public Mesh?                                    S_FullscreenMesh                        { get; set; }
        public Material?                                S_ErrorMaterial                         { get; set; }

        public static RenderingUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderingUtils() { Pointer= p0 };

            value.S_FullscreenMesh                          = GetObject<Mesh>(new IntPtr(p + 0x080), ReversePrism.DataModels.Mesh.FromPointer); // 0x80 S_FullscreenMesh            ( ModelClassType Mesh Mesh Mesh Pointer )
            value.S_ErrorMaterial                           = GetObject<Material>(new IntPtr(p + 0x088), ReversePrism.DataModels.Material.FromPointer); // 0x88 S_ErrorMaterial             ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
