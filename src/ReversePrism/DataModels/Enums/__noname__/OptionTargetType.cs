using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum OptionTargetType
    {
        TargetTypeUnknown,
        TargetTypeFile,
        TargetTypeExtensionRange,
        TargetTypeMessage,
        TargetTypeField,
        TargetTypeOneof,
        TargetTypeEnum,
        TargetTypeEnumEntry,
        TargetTypeService,
        TargetTypeMethod,
    }
}
