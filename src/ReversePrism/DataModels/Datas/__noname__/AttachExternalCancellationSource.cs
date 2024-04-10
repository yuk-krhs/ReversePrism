using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 cancellationCallbackDelegate             Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 018 TokenRegistration                        00018653EBA0 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class AttachExternalCancellationSource : DataModel
    {
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            TokenRegistration                       { get; set; }

        public static AttachExternalCancellationSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachExternalCancellationSource() { Pointer= p0 };

            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x010)); // 024661AC0090 0x10 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.TokenRegistration                         = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x018)); // 024661AC00B0 0x18 TokenRegistration           ( 00018653EBA0 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )

            return value;
        }
    }
}
