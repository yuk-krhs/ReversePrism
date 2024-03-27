using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<AutoResetUniTaskCompletionSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018658EC50 ModelClassType AutoResetUniTaskCompletionSource AutoResetUniTaskCompletionSource AutoResetUniTaskCompletionSource Pointer
    // 018 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class AutoResetUniTaskCompletionSource
    {
        public AutoResetUniTaskCompletionSource?        NextNode                                { get; set; }

        public static AutoResetUniTaskCompletionSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoResetUniTaskCompletionSource();

            value.NextNode                                  = GetObject<AutoResetUniTaskCompletionSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.AutoResetUniTaskCompletionSource.FromPointer); // 027003DE25A8 0x10 NextNode                    ( 00018658EC50 ModelClassType AutoResetUniTaskCompletionSource AutoResetUniTaskCompletionSource AutoResetUniTaskCompletionSource Pointer )

            return value;
        }
    }
}
