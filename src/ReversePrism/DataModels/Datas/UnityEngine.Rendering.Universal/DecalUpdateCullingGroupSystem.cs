using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BoundingDistance                       ModelPrimitiveListType float[] float[] List<float> Pointer
    // 018 M_Camera                                 ModelClassType Camera Camera Camera Pointer
    // 020 M_EntityManager                          ModelClassType DecalEntityManager DecalEntityManager DecalEntityManager Pointer
    // 028 M_Sampler                                ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    public partial class DecalUpdateCullingGroupSystem : DataModel
    {
        public List<float>?                             M_BoundingDistance                      { get; set; }
        public Camera?                                  M_Camera                                { get; set; }
        public DecalEntityManager?                      M_EntityManager                         { get; set; }
        public ProfilingSampler?                        M_Sampler                               { get; set; }

        public static DecalUpdateCullingGroupSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalUpdateCullingGroupSystem() { Pointer= p0 };

            value.M_BoundingDistance                        = GetSingleList(new IntPtr(p + 0x010)); // 0x10 M_BoundingDistance          ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_Camera                                  = GetObject<Camera>(new IntPtr(p + 0x018), ReversePrism.DataModels.Camera.FromPointer); // 0x18 M_Camera                    ( ModelClassType Camera Camera Camera Pointer )
            value.M_EntityManager                           = GetObject<DecalEntityManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.DecalEntityManager.FromPointer); // 0x20 M_EntityManager             ( ModelClassType DecalEntityManager DecalEntityManager DecalEntityManager Pointer )
            value.M_Sampler                                 = GetObject<ProfilingSampler>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x28 M_Sampler                   ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )

            return value;
        }
    }
}
