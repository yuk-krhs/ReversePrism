using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kPreviousViewProjectionNoJitter          string IL2CPP_TYPE_STRING
    // 000 kViewProjectionNoJitter                  string IL2CPP_TYPE_STRING
    // 000 k_TargetFormat                           GraphicsFormat IL2CPP_TYPE_VALUETYPE
    // 000 s_ShaderTags                             string[] IL2CPP_TYPE_SZARRAY
    // 0E0 M_Color                                  ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0E8 M_Depth                                  ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0F0 M_CameraMaterial                         ModelClassType Material Material Material Pointer
    // 0F8 M_ObjectMaterial                         ModelClassType Material Material Material Pointer
    // 100 M_PassData                               ModelClassType PassData PassData PassData Pointer
    public partial class MotionVectorRenderPass : DataModel
    {
        public RTHandle?                                M_Color                                 { get; set; }
        public RTHandle?                                M_Depth                                 { get; set; }
        public Material?                                M_CameraMaterial                        { get; set; }
        public Material?                                M_ObjectMaterial                        { get; set; }
        public PassData?                                M_PassData                              { get; set; }

        public static MotionVectorRenderPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MotionVectorRenderPass() { Pointer= p0 };

            value.M_Color                                   = GetObject<RTHandle>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE0 M_Color                     ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_Depth                                   = GetObject<RTHandle>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE8 M_Depth                     ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_CameraMaterial                          = GetObject<Material>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Material.FromPointer); // 0xF0 M_CameraMaterial            ( ModelClassType Material Material Material Pointer )
            value.M_ObjectMaterial                          = GetObject<Material>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Material.FromPointer); // 0xF8 M_ObjectMaterial            ( ModelClassType Material Material Material Pointer )
            value.M_PassData                                = GetObject<PassData>(new IntPtr(p + 0x100), ReversePrism.DataModels.PassData.FromPointer); // 0x100 M_PassData                  ( ModelClassType PassData PassData PassData Pointer )

            return value;
        }
    }
}
