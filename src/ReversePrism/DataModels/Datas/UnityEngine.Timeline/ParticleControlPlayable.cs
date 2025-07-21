using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kUnsetTime                               float IL2CPP_TYPE_R4
    // 010 M_LastPlayableTime                       ModelPrimitiveType float float float Single
    // 014 M_LastParticleTime                       ModelPrimitiveType float float float Single
    // 018 M_RandomSeed                             ModelPrimitiveType uint uint uint UInt32
    // 020 ParticleSystem                           ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    public partial class ParticleControlPlayable : DataModel
    {
        public float                                    M_LastPlayableTime                      { get; set; }
        public float                                    M_LastParticleTime                      { get; set; }
        public uint                                     M_RandomSeed                            { get; set; }
        public ParticleSystem?                          ParticleSystem                          { get; set; }

        public static ParticleControlPlayable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParticleControlPlayable() { Pointer= p0 };

            value.M_LastPlayableTime                        = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_LastPlayableTime          ( ModelPrimitiveType float float float Single )
            value.M_LastParticleTime                        = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_LastParticleTime          ( ModelPrimitiveType float float float Single )
            value.M_RandomSeed                              = GetUInt32(new IntPtr(p + 0x018)); // 0x18 M_RandomSeed                ( ModelPrimitiveType uint uint uint UInt32 )
            value.ParticleSystem                            = GetObject<ParticleSystem>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x20 ParticleSystem              ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )

            return value;
        }
    }
}
