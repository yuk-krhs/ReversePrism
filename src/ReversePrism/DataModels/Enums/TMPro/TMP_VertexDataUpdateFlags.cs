using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TMP_VertexDataUpdateFlags
    {
        None,
        Vertices,
        Uv0,
        Uv2,
        Uv4,
        Colors32,
        All,
    }
}
