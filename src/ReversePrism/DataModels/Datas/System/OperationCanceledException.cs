using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CancellationToken                        00018653DAD0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class OperationCanceledException : DataModel
    {
        public CancellationToken                        CancellationToken                       { get; set; }

        public static OperationCanceledException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OperationCanceledException() { Pointer= p0 };

            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x090)); // 0245A3DE3740 0x90 CancellationToken           ( 00018653DAD0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
