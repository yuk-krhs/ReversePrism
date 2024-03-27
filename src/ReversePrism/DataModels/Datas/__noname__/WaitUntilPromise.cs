using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<WaitUntilPromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671A750 ModelClassType WaitUntilPromise WaitUntilPromise WaitUntilPromise Pointer
    // 018 predicate                                Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 020 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class WaitUntilPromise
    {
        public WaitUntilPromise?                        NextNode                                { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static WaitUntilPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitUntilPromise();

            value.NextNode                                  = GetObject<WaitUntilPromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.WaitUntilPromise.FromPointer); // 027003A35300 0x10 NextNode                    ( 00018671A750 ModelClassType WaitUntilPromise WaitUntilPromise WaitUntilPromise Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 027003A35340 0x20 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
