using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FunctionType
    {
        FuncLast,
        FuncPosition,
        FuncCount,
        FuncID,
        FuncLocalName,
        FuncNameSpaceUri,
        FuncName,
        FuncString,
        FuncBoolean,
        FuncNumber,
        FuncTrue,
        FuncFalse,
        FuncNot,
        FuncConcat,
        FuncStartsWith,
        FuncContains,
        FuncSubstringBefore,
        FuncSubstringAfter,
        FuncSubstring,
        FuncStringLength,
        FuncNormalize,
        FuncTranslate,
        FuncLang,
        FuncSum,
        FuncFloor,
        FuncCeiling,
        FuncRound,
        FuncUserDefined,
    }
}
