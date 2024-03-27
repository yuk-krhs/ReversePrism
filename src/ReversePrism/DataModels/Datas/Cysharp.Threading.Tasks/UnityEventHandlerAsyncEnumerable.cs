using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnityEvent                               0001866A1CF0 ModelClassType UnityEvent UnityEvent UnityEvent Pointer
    // 018 CancellationToken1                       00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class UnityEventHandlerAsyncEnumerable
    {
        public UnityEvent?                              UnityEvent                              { get; set; }
        public CancellationToken                        CancellationToken1                      { get; set; }

        public static UnityEventHandlerAsyncEnumerable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityEventHandlerAsyncEnumerable();

            value.UnityEvent                                = GetObject<UnityEvent>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnityEvent.FromPointer); // 0270D8FB5930 0x10 UnityEvent                  ( 0001866A1CF0 ModelClassType UnityEvent UnityEvent UnityEvent Pointer )
            value.CancellationToken1                        = (CancellationToken)GetInt32(new IntPtr(p + 0x018)); // 0270D8FB5950 0x18 CancellationToken1          ( 00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
