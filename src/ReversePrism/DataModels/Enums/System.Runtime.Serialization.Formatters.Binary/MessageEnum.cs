using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MessageEnum
    {
        NoArgs,
        ArgsInline,
        ArgsIsArray,
        ArgsInArray,
        NoContext,
        ContextInline,
        ContextInArray,
        MethodSignatureInArray,
        PropertyInArray,
        NoReturnValue,
        ReturnValueVoid,
        ReturnValueInline,
        ReturnValueInArray,
        ExceptionInArray,
        GenericMethod,
    }
}
