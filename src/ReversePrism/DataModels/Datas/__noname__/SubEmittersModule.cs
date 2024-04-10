using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ParticleSystem                         000186723E70 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    public partial class SubEmittersModule : DataModel
    {
        public ParticleSystem?                          M_ParticleSystem                        { get; set; }

        public static SubEmittersModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubEmittersModule() { Pointer= p0 };

            value.M_ParticleSystem                          = GetObject<ParticleSystem>(new IntPtr(p + 0x010), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0245A691F1E8 0x10 M_ParticleSystem            ( 000186723E70 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )

            return value;
        }
    }
}
