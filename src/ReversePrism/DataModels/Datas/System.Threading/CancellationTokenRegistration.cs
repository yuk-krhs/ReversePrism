using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_callbackInfo                           00018653C470 ModelClassType CancellationCallbackInfo CancellationCallbackInfo CancellationCallbackInfo Pointer
    // 018 m_registrationInfo                       SparselyPopulatedArrayAddInfo`1<CancellationCallbackInfo> IL2CPP_TYPE_GENERICINST
    public partial class CancellationTokenRegistration : DataModel
    {
        public CancellationCallbackInfo?                M_callbackInfo                          { get; set; }

        public static CancellationTokenRegistration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CancellationTokenRegistration() { Pointer= p0 };

            value.M_callbackInfo                            = GetObject<CancellationCallbackInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationCallbackInfo.FromPointer); // 024661AC00F0 0x10 M_callbackInfo              ( 00018653C470 ModelClassType CancellationCallbackInfo CancellationCallbackInfo CancellationCallbackInfo Pointer )

            return value;
        }
    }
}
