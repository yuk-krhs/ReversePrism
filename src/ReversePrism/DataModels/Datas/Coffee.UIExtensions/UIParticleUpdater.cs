using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_ActiveParticles                        List`1<UIParticle> IL2CPP_TYPE_GENERICINST
    // 008 s_Mpb                                    MaterialPropertyBlock IL2CPP_TYPE_CLASS
    // 010 S_Particles                              ModelEnumListType Particle[] Particle[] List<Particle> Pointer
    // 018 FrameCount                               ModelPrimitiveType int int int Int32
    public partial class UIParticleUpdater : DataModel
    {
        public List<Particle>?                          S_Particles                             { get; set; }
        public int                                      FrameCount                              { get; set; }

        public static UIParticleUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIParticleUpdater() { Pointer= p0 };

            value.S_Particles                               = GetEnumList<Particle>(new IntPtr(p + 0x010)); // 0x10 S_Particles                 ( ModelEnumListType Particle[] Particle[] List<Particle> Pointer )
            value.FrameCount                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 FrameCount                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
