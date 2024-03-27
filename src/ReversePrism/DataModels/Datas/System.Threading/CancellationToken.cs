using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 000 s_actionToActionObjShunt                 Action`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class CancellationToken
    {
        public CancellationTokenSource?                 Source                                  { get; set; }

        public static CancellationToken? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CancellationToken();

            value.Source                                    = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 027002F30448 0x10 Source                      ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
