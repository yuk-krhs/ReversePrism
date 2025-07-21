using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Pass                                   ModelClassType XRPass XRPass XRPass Pointer
    // 018 M_CombinedMesh                           ModelClassType Mesh Mesh Mesh Pointer
    // 020 M_Material                               ModelClassType Material Material Material Pointer
    // 028 M_CombinedMeshHashCode                   ModelPrimitiveType int int int Int32
    // 000 k_OcclusionMeshProfilingSampler          ProfilingSampler IL2CPP_TYPE_CLASS
    public partial class XROcclusionMesh : DataModel
    {
        public XRPass?                                  M_Pass                                  { get; set; }
        public Mesh?                                    M_CombinedMesh                          { get; set; }
        public Material?                                M_Material                              { get; set; }
        public int                                      M_CombinedMeshHashCode                  { get; set; }

        public static XROcclusionMesh? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XROcclusionMesh() { Pointer= p0 };

            value.M_Pass                                    = GetObject<XRPass>(new IntPtr(p + 0x010), ReversePrism.DataModels.XRPass.FromPointer); // 0x10 M_Pass                      ( ModelClassType XRPass XRPass XRPass Pointer )
            value.M_CombinedMesh                            = GetObject<Mesh>(new IntPtr(p + 0x018), ReversePrism.DataModels.Mesh.FromPointer); // 0x18 M_CombinedMesh              ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_Material                                = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0x20 M_Material                  ( ModelClassType Material Material Material Pointer )
            value.M_CombinedMeshHashCode                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_CombinedMeshHashCode      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
