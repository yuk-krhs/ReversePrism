using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<WaitWhilePromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671AEB0 ModelClassType WaitWhilePromise WaitWhilePromise WaitWhilePromise Pointer
    // 018 predicate                                Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 020 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class WaitWhilePromise
    {
        public WaitWhilePromise?                        NextNode                                { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static WaitWhilePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitWhilePromise();

            value.NextNode                                  = GetObject<WaitWhilePromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.WaitWhilePromise.FromPointer); // 027003EF2548 0x10 NextNode                    ( 00018671AEB0 ModelClassType WaitWhilePromise WaitWhilePromise WaitWhilePromise Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 027003EF2588 0x20 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
