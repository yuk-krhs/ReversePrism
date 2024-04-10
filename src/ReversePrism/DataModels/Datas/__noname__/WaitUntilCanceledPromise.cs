using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<WaitUntilCanceledPromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671A010 ModelClassType WaitUntilCanceledPromise WaitUntilCanceledPromise WaitUntilCanceledPromise Pointer
    // 018 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 020 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class WaitUntilCanceledPromise : DataModel
    {
        public WaitUntilCanceledPromise?                NextNode                                { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static WaitUntilCanceledPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitUntilCanceledPromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<WaitUntilCanceledPromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.WaitUntilCanceledPromise.FromPointer); // 024668C52308 0x10 NextNode                    ( 00018671A010 ModelClassType WaitUntilCanceledPromise WaitUntilCanceledPromise WaitUntilCanceledPromise Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x018)); // 024668C52328 0x18 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
