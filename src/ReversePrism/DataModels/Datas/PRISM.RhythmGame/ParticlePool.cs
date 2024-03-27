using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Prefab                                   0001867240F0 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 028 Parent                                   0001866AADB0 ModelClassType Transform Transform Transform Pointer
    public partial class ParticlePool
    {
        public ParticleSystem?                          Prefab                                  { get; set; }
        public Transform?                               Parent                                  { get; set; }

        public static ParticlePool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParticlePool();

            value.Prefab                                    = GetObject<ParticleSystem>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0270D5042BD0 0x20 Prefab                      ( 0001867240F0 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270D5042BF0 0x28 Parent                      ( 0001866AADB0 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
