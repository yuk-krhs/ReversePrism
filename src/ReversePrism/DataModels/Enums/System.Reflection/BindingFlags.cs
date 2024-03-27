using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum BindingFlags
    {
        Default,
        IgnoreCase,
        DeclaredOnly,
        Instance,
        Static,
        Public,
        NonPublic,
        FlattenHierarchy,
        InvokeMethod,
        CreateInstance,
        GetField,
        SetField,
        GetProperty,
        SetProperty,
        PutDispProperty,
        PutRefDispProperty,
        ExactBinding,
        SuppressChangeType,
        OptionalParamBinding,
        IgnoreReturn,
        DoNotWrapExceptions,
    }
}
