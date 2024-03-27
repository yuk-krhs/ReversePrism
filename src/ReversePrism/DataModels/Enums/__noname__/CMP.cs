using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum CMP
    {
        EQ_OQ,
        LT_OS,
        LE_OS,
        UNORD_Q,
        NEQ_UQ,
        NLT_US,
        NLE_US,
        ORD_Q,
        EQ_UQ,
        NGE_US,
        NGT_US,
        FALSE_OQ,
        NEQ_OQ,
        GE_OS,
        GT_OS,
        TRUE_UQ,
        EQ_OS,
        LT_OQ,
        LE_OQ,
        UNORD_S,
        NEQ_US,
        NLT_UQ,
        NLE_UQ,
        ORD_S,
        EQ_US,
        NGE_UQ,
        NGT_UQ,
        FALSE_OS,
        NEQ_OS,
        GE_OQ,
        GT_OQ,
        TRUE_US,
    }
}
