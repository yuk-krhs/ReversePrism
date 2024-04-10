using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CancelDelegate                           Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 parent                                   Publish`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 cancellationTokenRegistration            CancellationTokenRegistration IL2CPP_TYPE_VALUETYPE
    // 000 isDisposed                               bool IL2CPP_TYPE_BOOLEAN
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    // 000 <Cysharp.Threading.Tasks.ITriggerHandler<TSource>.Prev>k__BackingField ITriggerHandler`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 <Cysharp.Threading.Tasks.ITriggerHandler<TSource>.Next>k__BackingField ITriggerHandler`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class _Publish : DataModel
    {

        public static _Publish? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Publish() { Pointer= p0 };


            return value;
        }
    }
}
