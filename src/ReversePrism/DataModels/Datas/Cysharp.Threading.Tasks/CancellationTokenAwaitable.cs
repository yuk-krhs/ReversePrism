using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class CancellationTokenAwaitable
    {
        public CancellationToken                        CancellationToken                       { get; set; }

        public static CancellationTokenAwaitable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CancellationTokenAwaitable();

            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x010)); // 0270D8BAB8D8 0x10 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
