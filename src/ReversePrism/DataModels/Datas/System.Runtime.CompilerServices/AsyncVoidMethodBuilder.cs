using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_synchronizationContext                 000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 018 M_coreState                              0001866F82A0 ModelEnumType AsyncMethodBuilderCore AsyncMethodBuilderCore AsyncMethodBuilderCore Int32
    // 028 M_task                                   000186680E70 ModelClassType Task Task Task Pointer
    public partial class AsyncVoidMethodBuilder
    {
        public SynchronizationContext?                  M_synchronizationContext                { get; set; }
        public AsyncMethodBuilderCore                   M_coreState                             { get; set; }
        public Task?                                    M_task                                  { get; set; }

        public static AsyncVoidMethodBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncVoidMethodBuilder();

            value.M_synchronizationContext                  = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 027003C2DD18 0x10 M_synchronizationContext    ( 000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.M_coreState                               = (AsyncMethodBuilderCore)GetInt32(new IntPtr(p + 0x018)); // 027003C2DD38 0x18 M_coreState                 ( 0001866F82A0 ModelEnumType AsyncMethodBuilderCore AsyncMethodBuilderCore AsyncMethodBuilderCore Int32 )
            value.M_task                                    = GetObject<Task>(new IntPtr(p + 0x028), ReversePrism.DataModels.Task.FromPointer); // 027003C2DD58 0x28 M_task                      ( 000186680E70 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
