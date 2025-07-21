using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Prefab                                   ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 028 Parent                                   ModelClassType Transform Transform Transform Pointer
    public partial class ParticlePool : DataModel
    {
        public ParticleSystem?                          Prefab                                  { get; set; }
        public Transform?                               Parent                                  { get; set; }

        public static ParticlePool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParticlePool() { Pointer= p0 };

            value.Prefab                                    = GetObject<ParticleSystem>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x20 Prefab                      ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 Parent                      ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
