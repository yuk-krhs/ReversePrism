using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FieldPacking
    {
        NoPacking,
        R11G11B10,
        PackedFloat,
        PackedUint,
    }
}
