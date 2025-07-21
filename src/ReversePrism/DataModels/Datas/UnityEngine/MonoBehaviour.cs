using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_CancellationTokenSource                ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class MonoBehaviour : DataModel
    {
        public CancellationTokenSource?                 M_CancellationTokenSource               { get; set; }

        public static MonoBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBehaviour() { Pointer= p0 };

            value.M_CancellationTokenSource                 = GetObject<CancellationTokenSource>(new IntPtr(p + 0x018), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x18 M_CancellationTokenSource   ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
