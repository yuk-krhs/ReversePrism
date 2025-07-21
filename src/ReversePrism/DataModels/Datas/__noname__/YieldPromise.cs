using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<YieldPromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType YieldPromise YieldPromise YieldPromise Pointer
    // 018 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 020 CancellationTokenRegistration            ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 038 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class YieldPromise : DataModel
    {
        public YieldPromise?                            NextNode                                { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            CancellationTokenRegistration           { get; set; }

        public static YieldPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new YieldPromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<YieldPromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.YieldPromise.FromPointer); // 0x10 NextNode                    ( ModelClassType YieldPromise YieldPromise YieldPromise Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x018)); // 0x18 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CancellationTokenRegistration             = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x020)); // 0x20 CancellationTokenRegistration ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )

            return value;
        }
    }
}
