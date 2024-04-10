using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_continuation                           00018667A650 ModelClassType Action Action Action Pointer
    // 018 M_invokeAction                           00018667A3C0 ModelClassType Action Action Action Pointer
    // 020 M_innerTask                              000186681890 ModelClassType Task Task Task Pointer
    public partial class ContinuationWrapper : DataModel
    {
        public Action?                                  M_continuation                          { get; set; }
        public Action?                                  M_invokeAction                          { get; set; }
        public Task?                                    M_innerTask                             { get; set; }

        public static ContinuationWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContinuationWrapper() { Pointer= p0 };

            value.M_continuation                            = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 024666D0EF80 0x10 M_continuation              ( 00018667A650 ModelClassType Action Action Action Pointer )
            value.M_invokeAction                            = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 024666D0EFA0 0x18 M_invokeAction              ( 00018667A3C0 ModelClassType Action Action Action Pointer )
            value.M_innerTask                               = GetObject<Task>(new IntPtr(p + 0x020), ReversePrism.DataModels.Task.FromPointer); // 024666D0EFC0 0x20 M_innerTask                 ( 000186681890 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
