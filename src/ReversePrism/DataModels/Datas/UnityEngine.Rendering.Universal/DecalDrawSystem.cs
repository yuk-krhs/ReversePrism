using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_EntityManager                          ModelClassType DecalEntityManager DecalEntityManager DecalEntityManager Pointer
    // 018 M_WorldToDecals                          ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 020 M_NormalToDecals                         ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 028 M_DecalLayerMasks                        ModelPrimitiveListType float[] float[] List<float> Pointer
    // 030 M_Sampler                                ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 038 OverrideMaterial                         ModelClassType Material Material Material Pointer
    public partial class DecalDrawSystem : DataModel
    {
        public DecalEntityManager?                      M_EntityManager                         { get; set; }
        public List<Matrix4x4>?                         M_WorldToDecals                         { get; set; }
        public List<Matrix4x4>?                         M_NormalToDecals                        { get; set; }
        public List<float>?                             M_DecalLayerMasks                       { get; set; }
        public ProfilingSampler?                        M_Sampler                               { get; set; }
        public Material?                                OverrideMaterial                        { get; set; }

        public static DecalDrawSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalDrawSystem() { Pointer= p0 };

            value.M_EntityManager                           = GetObject<DecalEntityManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.DecalEntityManager.FromPointer); // 0x10 M_EntityManager             ( ModelClassType DecalEntityManager DecalEntityManager DecalEntityManager Pointer )
            value.M_WorldToDecals                           = GetEnumList<Matrix4x4>(new IntPtr(p + 0x018)); // 0x18 M_WorldToDecals             ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.M_NormalToDecals                          = GetEnumList<Matrix4x4>(new IntPtr(p + 0x020)); // 0x20 M_NormalToDecals            ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.M_DecalLayerMasks                         = GetSingleList(new IntPtr(p + 0x028)); // 0x28 M_DecalLayerMasks           ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_Sampler                                 = GetObject<ProfilingSampler>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x30 M_Sampler                   ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.OverrideMaterial                          = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 OverrideMaterial            ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
