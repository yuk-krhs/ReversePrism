using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Callback                                 000186747ED0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer
    // 018 <State>k__BackingField                   <object> IL2CPP_TYPE_OBJECT
    public partial class CompletionCallbackData
    {
        public BatchCompletionDelegate?                 Callback                                { get; set; }

        public static CompletionCallbackData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompletionCallbackData();

            value.Callback                                  = GetObject<BatchCompletionDelegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.BatchCompletionDelegate.FromPointer); // 02700409DE30 0x10 Callback                    ( 000186747ED0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer )

            return value;
        }
    }
}
