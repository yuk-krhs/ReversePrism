using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ShaderPathID
    {
        Lit,
        SimpleLit,
        Unlit,
        TerrainLit,
        ParticlesLit,
        ParticlesSimpleLit,
        ParticlesUnlit,
        BakedLit,
        SpeedTree7,
        SpeedTree7Billboard,
        SpeedTree8,
    }
}
