using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<YieldPromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671B5D0 ModelClassType YieldPromise YieldPromise YieldPromise Pointer
    // 018 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 020 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class YieldPromise
    {
        public YieldPromise?                            NextNode                                { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static YieldPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new YieldPromise();

            value.NextNode                                  = GetObject<YieldPromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.YieldPromise.FromPointer); // 027003DDACD0 0x10 NextNode                    ( 00018671B5D0 ModelClassType YieldPromise YieldPromise YieldPromise Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x018)); // 027003DDACF0 0x18 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
