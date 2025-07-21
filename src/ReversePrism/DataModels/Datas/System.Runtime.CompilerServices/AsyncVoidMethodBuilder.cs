using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_synchronizationContext                 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 018 M_coreState                              ModelEnumType AsyncMethodBuilderCore AsyncMethodBuilderCore AsyncMethodBuilderCore Int32
    // 028 M_task                                   ModelClassType Task Task Task Pointer
    public partial class AsyncVoidMethodBuilder : DataModel
    {
        public SynchronizationContext?                  M_synchronizationContext                { get; set; }
        public AsyncMethodBuilderCore                   M_coreState                             { get; set; }
        public Task?                                    M_task                                  { get; set; }

        public static AsyncVoidMethodBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncVoidMethodBuilder() { Pointer= p0 };

            value.M_synchronizationContext                  = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0x10 M_synchronizationContext    ( ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.M_coreState                               = (AsyncMethodBuilderCore)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_coreState                 ( ModelEnumType AsyncMethodBuilderCore AsyncMethodBuilderCore AsyncMethodBuilderCore Int32 )
            value.M_task                                    = GetObject<Task>(new IntPtr(p + 0x028), ReversePrism.DataModels.Task.FromPointer); // 0x28 M_task                      ( ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
