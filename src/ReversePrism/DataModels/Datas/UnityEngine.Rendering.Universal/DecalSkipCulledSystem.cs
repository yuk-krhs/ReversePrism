using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_EntityManager                          ModelClassType DecalEntityManager DecalEntityManager DecalEntityManager Pointer
    // 018 M_Sampler                                ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 020 M_Camera                                 ModelClassType Camera Camera Camera Pointer
    public partial class DecalSkipCulledSystem : DataModel
    {
        public DecalEntityManager?                      M_EntityManager                         { get; set; }
        public ProfilingSampler?                        M_Sampler                               { get; set; }
        public Camera?                                  M_Camera                                { get; set; }

        public static DecalSkipCulledSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalSkipCulledSystem() { Pointer= p0 };

            value.M_EntityManager                           = GetObject<DecalEntityManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.DecalEntityManager.FromPointer); // 0x10 M_EntityManager             ( ModelClassType DecalEntityManager DecalEntityManager DecalEntityManager Pointer )
            value.M_Sampler                                 = GetObject<ProfilingSampler>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x18 M_Sampler                   ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_Camera                                  = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 M_Camera                    ( ModelClassType Camera Camera Camera Pointer )

            return value;
        }
    }
}
