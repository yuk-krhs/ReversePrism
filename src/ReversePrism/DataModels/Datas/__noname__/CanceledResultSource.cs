using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CancellationToken                        00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class CanceledResultSource : DataModel
    {
        public CancellationToken                        CancellationToken                       { get; set; }

        public static CanceledResultSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CanceledResultSource() { Pointer= p0 };

            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x010)); // 0245A3CBD168 0x10 CancellationToken           ( 00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
