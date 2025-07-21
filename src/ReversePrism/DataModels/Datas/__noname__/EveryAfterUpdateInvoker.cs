using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    ModelPrimitiveType long long long Int64
    // 018 observer                                 IObserver`1<long> IL2CPP_TYPE_GENERICINST
    // 020 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class EveryAfterUpdateInvoker : DataModel
    {
        public long                                     Count                                   { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static EveryAfterUpdateInvoker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EveryAfterUpdateInvoker() { Pointer= p0 };

            value.Count                                     = GetInt64(new IntPtr(p + 0x010)); // 0x10 Count                       ( ModelPrimitiveType long long long Int64 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0x20 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
