using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sampler                                  00018666CA30 ModelClassType CustomSampler CustomSampler CustomSampler Pointer
    public partial class ProfileSampler
    {
        public CustomSampler?                           Sampler                                 { get; set; }

        public static ProfileSampler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSampler();

            value.Sampler                                   = GetObject<CustomSampler>(new IntPtr(p + 0x010), ReversePrism.DataModels.CustomSampler.FromPointer); // 027003FE6600 0x10 Sampler                     ( 00018666CA30 ModelClassType CustomSampler CustomSampler CustomSampler Pointer )

            return value;
        }
    }
}
