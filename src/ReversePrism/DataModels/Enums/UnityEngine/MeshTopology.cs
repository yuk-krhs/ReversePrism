using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MeshTopology
    {
        Triangles,
        Quads,
        Lines,
        LineStrip,
        Points,
    }
}
