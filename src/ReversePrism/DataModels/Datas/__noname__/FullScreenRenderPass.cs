using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_PassMaterial                           ModelClassType Material Material Material Pointer
    // 0E8 M_PassIndex                              ModelPrimitiveType int int int Int32
    // 0EC M_RequiresColor                          ModelPrimitiveType bool bool bool Bool
    // 0ED M_IsBeforeTransparents                   ModelPrimitiveType bool bool bool Bool
    // 0F0 M_PassData                               ModelClassType PassData PassData PassData Pointer
    // 0F8 M_ProfilingSampler                       ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 100 M_CopiedColor                            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 000 m_BlitTextureShaderID                    int IL2CPP_TYPE_I4
    public partial class FullScreenRenderPass : DataModel
    {
        public Material?                                M_PassMaterial                          { get; set; }
        public int                                      M_PassIndex                             { get; set; }
        public bool                                     M_RequiresColor                         { get; set; }
        public bool                                     M_IsBeforeTransparents                  { get; set; }
        public PassData?                                M_PassData                              { get; set; }
        public ProfilingSampler?                        M_ProfilingSampler                      { get; set; }
        public RTHandle?                                M_CopiedColor                           { get; set; }

        public static FullScreenRenderPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FullScreenRenderPass() { Pointer= p0 };

            value.M_PassMaterial                            = GetObject<Material>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Material.FromPointer); // 0xE0 M_PassMaterial              ( ModelClassType Material Material Material Pointer )
            value.M_PassIndex                               = GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 M_PassIndex                 ( ModelPrimitiveType int int int Int32 )
            value.M_RequiresColor                           = GetBool(new IntPtr(p + 0x0EC)); // 0xEC M_RequiresColor             ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsBeforeTransparents                    = GetBool(new IntPtr(p + 0x0ED)); // 0xED M_IsBeforeTransparents      ( ModelPrimitiveType bool bool bool Bool )
            value.M_PassData                                = GetObject<PassData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.PassData.FromPointer); // 0xF0 M_PassData                  ( ModelClassType PassData PassData PassData Pointer )
            value.M_ProfilingSampler                        = GetObject<ProfilingSampler>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0xF8 M_ProfilingSampler          ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_CopiedColor                             = GetObject<RTHandle>(new IntPtr(p + 0x100), ReversePrism.DataModels.RTHandle.FromPointer); // 0x100 M_CopiedColor               ( ModelClassType RTHandle RTHandle RTHandle Pointer )

            return value;
        }
    }
}
