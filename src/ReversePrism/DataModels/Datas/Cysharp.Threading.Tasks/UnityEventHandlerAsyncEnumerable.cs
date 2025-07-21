using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnityEvent                               ModelClassType UnityEvent UnityEvent UnityEvent Pointer
    // 018 CancellationToken1                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class UnityEventHandlerAsyncEnumerable : DataModel
    {
        public UnityEvent?                              UnityEvent                              { get; set; }
        public CancellationToken                        CancellationToken1                      { get; set; }

        public static UnityEventHandlerAsyncEnumerable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityEventHandlerAsyncEnumerable() { Pointer= p0 };

            value.UnityEvent                                = GetObject<UnityEvent>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnityEvent.FromPointer); // 0x10 UnityEvent                  ( ModelClassType UnityEvent UnityEvent UnityEvent Pointer )
            value.CancellationToken1                        = (CancellationToken)GetInt32(new IntPtr(p + 0x018)); // 0x18 CancellationToken1          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
