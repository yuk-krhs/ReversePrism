using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SIDD
    {
        UBYTE_OPS,
        UWORD_OPS,
        SBYTE_OPS,
        SWORD_OPS,
        CMP_EQUAL_ANY,
        CMP_RANGES,
        CMP_EQUAL_EACH,
        CMP_EQUAL_ORDERED,
        POSITIVE_POLARITY,
        NEGATIVE_POLARITY,
        MASKED_POSITIVE_POLARITY,
        MASKED_NEGATIVE_POLARITY,
        LEAST_SIGNIFICANT,
        MOST_SIGNIFICANT,
        BIT_MASK,
        UNIT_MASK,
    }
}
