using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sampler                                  ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    public partial class ProfilingScopePassData : DataModel
    {
        public ProfilingSampler?                        Sampler                                 { get; set; }

        public static ProfilingScopePassData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilingScopePassData() { Pointer= p0 };

            value.Sampler                                   = GetObject<ProfilingSampler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x10 Sampler                     ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )

            return value;
        }
    }
}
