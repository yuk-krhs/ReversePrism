using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 M_antecedent                             000186680E70 ModelClassType Task Task Task Pointer
    public partial class ContinuationTaskFromTask
    {
        public Task?                                    M_antecedent                            { get; set; }

        public static ContinuationTaskFromTask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContinuationTaskFromTask();

            value.M_antecedent                              = GetObject<Task>(new IntPtr(p + 0x050), ReversePrism.DataModels.Task.FromPointer); // 0270D6B4F468 0x50 M_antecedent                ( 000186680E70 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
