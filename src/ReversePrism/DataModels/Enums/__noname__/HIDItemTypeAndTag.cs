using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum HIDItemTypeAndTag
    {
        Input,
        Output,
        Feature,
        Collection,
        EndCollection,
        UsagePage,
        LogicalMinimum,
        LogicalMaximum,
        PhysicalMinimum,
        PhysicalMaximum,
        UnitExponent,
        Unit,
        ReportSize,
        ReportID,
        ReportCount,
        Push,
        Pop,
        Usage,
        UsageMinimum,
        UsageMaximum,
        DesignatorIndex,
        DesignatorMinimum,
        DesignatorMaximum,
        StringIndex,
        StringMinimum,
        StringMaximum,
        Delimiter,
    }
}
