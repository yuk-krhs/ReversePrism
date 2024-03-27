using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Pass                                   000186584660 ModelClassType XRPass XRPass XRPass Pointer
    // 018 M_CombinedMesh                           0001866104D0 ModelClassType Mesh Mesh Mesh Pointer
    // 020 M_Material                               00018660BDD0 ModelClassType Material Material Material Pointer
    // 028 M_CombinedMeshHashCode                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 k_OcclusionMeshProfilingSampler          ProfilingSampler IL2CPP_TYPE_CLASS
    public partial class XROcclusionMesh
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
            var value   = new XROcclusionMesh();

            value.M_Pass                                    = GetObject<XRPass>(new IntPtr(p + 0x010), ReversePrism.DataModels.XRPass.FromPointer); // 0270035E6388 0x10 M_Pass                      ( 000186584660 ModelClassType XRPass XRPass XRPass Pointer )
            value.M_CombinedMesh                            = GetObject<Mesh>(new IntPtr(p + 0x018), ReversePrism.DataModels.Mesh.FromPointer); // 0270035E63A8 0x18 M_CombinedMesh              ( 0001866104D0 ModelClassType Mesh Mesh Mesh Pointer )
            value.M_Material                                = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0270035E63C8 0x20 M_Material                  ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_CombinedMeshHashCode                    = GetInt32(new IntPtr(p + 0x028)); // 0270035E63E8 0x28 M_CombinedMeshHashCode      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
